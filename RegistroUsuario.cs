using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ManejoInventariosBD
{
    public partial class RegistroUsuario : Form
    {
        public static MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c");
        public string rol;
        private bool fail1;
        private bool fail2;


        public RegistroUsuario()
        {
            InitializeComponent();
            textBox1.MaxLength = 30;
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 13;

            textBox3.PasswordChar = '*';
            textBox3.MaxLength = 13;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text || textBox2.Text == "" || textBox3.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Las contraseñas no coinciden o alguno de los campos está vacio");
                fail1 = true;
            }
            else
                fail1 = false;


            if (comboBox1.Text == "Administrador")
            {
                rol = "admin";
                fail2 = false;
            }
            else if (comboBox1.Text == "Encargado")
            {
                rol = "encargado";
                fail2 = false;
            }
            else
            {
                MessageBox.Show("Rol no valido");
                fail2 = true;
            }
            if (fail1 == false && fail2==false)
            {
                DialogResult dialogResult = MessageBox.Show("Esta operación no se puede deshacer. ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "INSERT IGNORE INTO `usuarios`(`Usuario`, `Clave`, `Rol`) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + rol + "')";
                    MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                    commandDatabase.CommandText = query;
                    databaseConnection.Open();
                    commandDatabase.ExecuteNonQuery();
                    databaseConnection.Close();
                    MessageBox.Show("operación completada");
                }
                else if (dialogResult == DialogResult.No)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";

                }
                
            }
            


        }

        private void RegistroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f= new Form2();
            this.Dispose();
            f.Show();
        }
    }
}
