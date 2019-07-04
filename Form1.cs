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

        public int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        public static string obtenervalor;

        private void Login_Click(object sender, EventArgs e)
        {
            if((textUsuario.Text == "caos") ^ (textUsuario.Text == "CAOS"))
            {
                if(textContraseña.Text == "soac")
                {
                    this.Hide();
                    Form2 f = new Form2();
                    f.Show();
                    

                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta para usuario caos");
                }
            }

            else if (textUsuario.Text == "Encargado1")
            {
                if (textContraseña.Text == "clave1")
                {
                    obtenervalor = textUsuario.Text;
                    this.Hide();
                    Form4 f = new Form4();
                    f.Show();
                    
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta para usuario Encargado1");
                }

            }

            else if (textUsuario.Text == "Encargado2")
            {
                if (textContraseña.Text == "clave2")
                {
                    obtenervalor = textUsuario.Text;
                    this.Hide();
                    Form4 f = new Form4();
                    f.Show();
                    
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta para usuario Encargado2");
                }
            }

            else if (textUsuario.Text == "Encargado2")
            {
                if (textContraseña.Text == "clave2")
                {
                    obtenervalor = textUsuario.Text;
                    this.Hide();
                    Form4 f = new Form4();
                    f.Show();
                    
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta para usuario Encargado2");
                }
            }

            else if (textUsuario.Text == "Contador")
            {
                if (textContraseña.Text != "")
                {
                    
                }
                else
                {
                    MessageBox.Show("El usuario Contador no requiere contraseña");
                }
            }

        }

      

        

    }
}
