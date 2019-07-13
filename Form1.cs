using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace ManejoInventariosBD
{

    
    public partial class Form1 : Form
    {
        public static MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c");
        int i;
        public string rol;
        public Form1()
        {
            

            InitializeComponent();
            // Set to no text.  
            textContraseña.Text = "";
            // The password character is an asterisk.  
            textContraseña.PasswordChar = '*';
            // The control will allow no more than 14 characters.  
            textContraseña.MaxLength = 14;

            
    }

        

        public static string obtenervalor;

        private void Login_Click(object sender, EventArgs e)
        {
            obtenervalor = textUsuario.Text;
            i = 0;
            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM `usuarios` WHERE `Usuario`='"+textUsuario.Text+"' AND `Clave`='"+textContraseña.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            databaseConnection.Close();
            if (i == 0)
            {
                label4.Visible = true;
            }
            else
            {

                
                MySqlCommand cmd1;
                cmd1 = new MySqlCommand("SELECT `Rol` FROM `usuarios` where `Usuario`='"+textUsuario.Text+"' AND `Clave`='"+textContraseña.Text+"'", databaseConnection);
                databaseConnection.Open();
                rol = cmd1.ExecuteScalar().ToString();
                databaseConnection.Close();

                if (rol == "admin")
                {
                    this.Hide();
                    Form2 f = new Form2();
                    f.Show();

                }

                if (rol == "encargado")
                {
                    this.Hide();
                    Form4 f = new Form4();
                    f.Show();

                }
                databaseConnection.Close();

            }



            


        }


    }
}
