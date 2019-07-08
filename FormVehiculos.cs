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
using ManejoInventariosBD;

namespace ManejoInventariosBD
{
    public partial class FormVehiculos : Form
    {
        private bool bool1;
        private bool p1;
        private bool p2;
        private bool p3;
        private bool p4;
        private bool p5;
        private bool p6;
        private bool p7;
   

        string tipo;
        public FormVehiculos(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            


            

        }
        Carro cochereg = new Carro();

        private void Button4_Click(object sender, EventArgs e)
        {
            if (!((tableLayoutPanel2.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel3.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel4.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel5.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel6.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel7.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel8.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel9.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel10.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel11.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel12.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel13.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel14.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel15.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel16.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel17.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel18.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel19.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel20.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel22.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel23.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel24.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel25.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel26.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel27.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel28.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel29.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel30.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel31.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel32.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel33.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel34.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel35.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel36.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel37.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel38.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel39.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel40.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel41.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel42.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&

                (panel1.Controls.OfType<RadioButton>().Any(x => x.Checked)) && (panel2.Controls.OfType<RadioButton>().Any(x => x.Checked))
                ))
            {
                MessageBox.Show("Registros incompletos, intente nuevamente");
                p1 = true;
            }
            else
                p1 = false;
            int parsedValue;


            if (numpar.Text == "")
            {
                bool1 = true;
                MessageBox.Show("No ha insertado un número de parlantes");
            }
            if (!int.TryParse(numpar.Text, out parsedValue))
            {
                MessageBox.Show("El número de parlantes no acepta caracteres");
                return;
            }
            else
            {
                int j = int.Parse(numpar.Text);
                if (!(j <= 15 && j >= 0))
                {
                    MessageBox.Show("No ha insertado un número de parlantes valido");
                    p5 = true;
                    return;
                }
                else
                {
                    bool1 = false;
                    p5 = false;
                }
            }


            if (numlimp.Text == "")
            {
                p6 = true;
                MessageBox.Show("No ha insertado un número de limpiaparabrisas");
            }
            if (!int.TryParse(numlimp.Text, out parsedValue))
            {
                MessageBox.Show("El número de limpiaparabrisas no acepta caracteres");
                return;
            }
            else
            {
                int j = int.Parse(numlimp.Text);
                if (!(j <= 3 && j >= 0))
                {
                    MessageBox.Show("No ha insertado un número de limpiaparabrisas valido");
                    p7 = true;
                    return;
                }
                else
                {
                    p7 = false;
                    p6 = false;
                }
            }



            if (motivo.Text != "Patios" && motivo.Text != "Accidente")
            {
                MessageBox.Show("Motivo de ingreso no valido, intente nuevamente");
                p1 = true;
            }
            else p1 = false;

            if (patioscuenta.Text != "Policía" && patioscuenta.Text != "Transito" && patioscuenta.Text != "Policia de Tránsito y Transporte" && patioscuenta.Text != "Juzgado" && patioscuenta.Text != "Fiscalía" && patioscuenta.Text != "Otro")
            {
                MessageBox.Show("Autoridad que ingresa no valida, intente nuevamente");

                p2 = true;
            }
            else
                p2 = false;





            if (numinvent.Text == "")
            {
                p3 = true;
                MessageBox.Show("No ha insertado un número de inventario");
            }
            if (!int.TryParse(numinvent.Text, out parsedValue))
            {
                MessageBox.Show("El número de inventario no acepta caracteres");
                return;
            }
            else if ((!(int.TryParse(numinvent.Text, out parsedValue))))
            {
                int j = int.Parse(numinvent.Text);
                if (!(j <= 9999 && j >= 1000))
                {
                    MessageBox.Show("No ha insertado un número de inventario valido");
                    p4 = true;
                    return;
                }
            }
            else
            {
                p3 = false;
                p4 = false;
            }



            if (bool1 == false && p1 == false && p2 == false && p3 == false && p4 == false && p5 == false && p6 == false && p7 == false)
            {
                //De aquí hacia arriba todo funciona
                if (this.radioButton1.Checked == true)
                {
                    cochereg.SetBomDel("B");
                    
                }
                    



                //De aquí hacia abajo todo funciona
                runQueryVeh();
                
                MessageBox.Show("Registro exitoso");
                Form4 f = new Form4();
                this.Dispose();
                f.Show();
            }

        }
        private void runQueryVeh()
        {
            string texto = comboBox2.Text;
            string query = "INSERT INTO `prueba`(`Id`, `Holamundo`) VALUES ('" + comboBox2.Text + "')";
            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            commandDatabase.CommandText = query;
            databaseConnection.Open();
            commandDatabase.ExecuteNonQuery();
            databaseConnection.Close();

            /*
            try
            {
                databaseConnection.Open();

                
            }catch(Exception e)
            {
                MessageBox.Show("Query Error: " + e.Message);
            }
            MySqlDataReader reader = commandDatabase.ExecuteReader();*/
        }





        private void button3_Click(object sender, EventArgs e)
        {
            int parsedValue;

            if (int.TryParse(propietario.Text, out parsedValue))
            {
                MessageBox.Show("El campo 'Propietario' solo acepta caracteres, intente nuevamente");
                return;
            }
            else if (propietario.Text != "")
            {
                groupBox2.Visible = true;

            }
            else if (textBox1.Text == "")
            {
                groupBox2.Visible = false;
            }
        }

        private void FormVehiculos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form4 f = new Form4();
            this.Dispose();
            f.Show();
        }
    }
}       

