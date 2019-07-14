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
    public partial class FormTipo : Form
    {
        private bool fail1;
        private bool fail2;
        private string forma;
        public static MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c");

        public FormTipo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacío");
                fail1 = true;

            }
            

            if (comboBox1.Text != "Moto" && comboBox1.Text != "Carro")
            {
                MessageBox.Show("FormAsociado no valido");
                fail2 = true;
            }
            if(!(fail1 && fail2))
            {
                DialogResult dialogResult = MessageBox.Show("Esta operación no se puede deshacer. ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "INSERT IGNORE INTO `tipos_veh`(`Tipo`, `Form_Asociado`) VALUES ('"+textBox1.Text+"','"+comboBox1.Text+"')";
                    MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                    commandDatabase.CommandText = query;
                    databaseConnection.Open();
                    commandDatabase.ExecuteNonQuery();
                    databaseConnection.Close();
                    MessageBox.Show("Operación completada");
                }
                else if (dialogResult == DialogResult.No)
                {
                    textBox1.Text = "";
                    comboBox1.Text = "";

                }
            }

        }

        private void FormTipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f = new Form2();
            this.Dispose();
            f.Show();
        }
    }
}
