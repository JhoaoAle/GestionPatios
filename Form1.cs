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
 
            textContraseña.Text = "";
            textContraseña.PasswordChar = '*';
            textContraseña.MaxLength = 13;

            
        }

        

        public static string obtenervalor;

        private void Login_Click(object sender, EventArgs e)
        {
            obtenervalor = textUsuario.Text;
            Usuario user = new Usuario();
            user.Seti(textUsuario.Text, textContraseña.Text);
            i = user.geti();
            
            
            if (i == 0)
            {
                label4.Visible = true;
            }
            else
            {

                if (user.getrol(textUsuario.Text, textContraseña.Text) == "Admin")
                {
                    this.Hide();
                    Form2 f = new Form2();
                    f.Show();

                }

                if (user.getrol(textUsuario.Text, textContraseña.Text) == "Encargado")
                {
                    this.Hide();
                    Form4 f = new Form4();
                    f.Show();

                }
                

            }



            


        }


    }
}
