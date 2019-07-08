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
                    cochereg.SetBomDel("B");
                if (this.radioButton2.Checked == true)
                    cochereg.SetBomDel("R");
                if (this.radioButton3.Checked == true)
                    cochereg.SetBomDel("M");
                if (this.radioButton4.Checked == true)
                    cochereg.SetBomDel("N/A");
                if (this.radioButton5.Checked == true)
                    cochereg.SetBomDel("N/V");

                if (this.radioButton6.Checked == true)
                    cochereg.SetPersiana("B");
                if (this.radioButton7.Checked == true)
                    cochereg.SetPersiana("R");
                if (this.radioButton8.Checked == true)
                    cochereg.SetPersiana("M");
                if (this.radioButton9.Checked == true)
                    cochereg.SetPersiana("N/A");
                if (this.radioButton10.Checked == true)
                    cochereg.SetPersiana("N/V");

                if (this.radioButton11.Checked == true)
                    cochereg.SetFarIzq("B");
                if (this.radioButton12.Checked == true)
                    cochereg.SetFarIzq("R");
                if (this.radioButton13.Checked == true)
                    cochereg.SetFarIzq("M");
                if (this.radioButton14.Checked == true)
                    cochereg.SetFarIzq("N/A");
                if (this.radioButton15.Checked == true)
                    cochereg.SetFarIzq("N/V");

                if (this.radioButton16.Checked == true)
                    cochereg.SetParDel("B");
                if (this.radioButton17.Checked == true)
                    cochereg.SetParDel("R");
                if (this.radioButton18.Checked == true)
                    cochereg.SetParDel("M");
                if (this.radioButton19.Checked == true)
                    cochereg.SetParDel("N/A");
                if (this.radioButton20.Checked == true)
                    cochereg.SetParDel("N/V");

                if (this.radioButton21.Checked == true)
                    cochereg.SetEspRetIzq("B");
                if (this.radioButton22.Checked == true)
                    cochereg.SetEspRetIzq("R");
                if (this.radioButton23.Checked == true)
                    cochereg.SetEspRetIzq("M");
                if (this.radioButton24.Checked == true)
                    cochereg.SetEspRetIzq("N/A");
                if (this.radioButton25.Checked == true)
                    cochereg.SetEspRetIzq("N/V");

                if (this.radioButton26.Checked == true)
                    cochereg.SetGFDelIzq("B");
                if (this.radioButton27.Checked == true)
                    cochereg.SetGFDelIzq("R");
                if (this.radioButton28.Checked == true)
                    cochereg.SetGFDelIzq("M");
                if (this.radioButton29.Checked == true)
                    cochereg.SetGFDelIzq("N/A");
                if (this.radioButton30.Checked == true)
                    cochereg.SetGFDelIzq("N/V");

                if (this.radioButton31.Checked == true)
                    cochereg.SetPDelIzq("B");
                if (this.radioButton32.Checked == true)
                    cochereg.SetPDelIzq("R");
                if (this.radioButton33.Checked == true)
                    cochereg.SetPDelIzq("M");
                if (this.radioButton34.Checked == true)
                    cochereg.SetPDelIzq("N/A");
                if (this.radioButton35.Checked == true)
                    cochereg.SetPDelIzq("N/V");

                if (this.radioButton36.Checked == true)
                    cochereg.SetPTraIzq("B");
                if (this.radioButton37.Checked == true)
                    cochereg.SetPTraIzq("R");
                if (this.radioButton38.Checked == true)
                    cochereg.SetPTraIzq("M");
                if (this.radioButton39.Checked == true)
                    cochereg.SetPTraIzq("N/A");
                if (this.radioButton40.Checked == true)
                    cochereg.SetPTraIzq("N/V");

                if (this.radioButton41.Checked == true)
                    cochereg.SetVPDelIzq("B");
                if (this.radioButton42.Checked == true)
                    cochereg.SetVPDelIzq("R");
                if (this.radioButton43.Checked == true)
                    cochereg.SetVPDelIzq("M");
                if (this.radioButton44.Checked == true)
                    cochereg.SetVPDelIzq("N/A");
                if (this.radioButton45.Checked == true)
                    cochereg.SetVPDelIzq("N/V");

                if (this.radioButton46.Checked == true)
                    cochereg.SetVPTraIzq("B");
                if (this.radioButton47.Checked == true)
                    cochereg.SetVPTraIzq("R");
                if (this.radioButton48.Checked == true)
                    cochereg.SetVPTraIzq("M");
                if (this.radioButton49.Checked == true)
                    cochereg.SetVPTraIzq("N/A");
                if (this.radioButton50.Checked == true)
                    cochereg.SetVPTraIzq("N/V");

                if (this.radioButton51.Checked == true)
                    cochereg.SetGFTraIzq("B");
                if (this.radioButton52.Checked == true)
                    cochereg.SetGFTraIzq("R");
                if (this.radioButton53.Checked == true)
                    cochereg.SetGFTraIzq("M");
                if (this.radioButton54.Checked == true)
                    cochereg.SetGFTraIzq("N/A");
                if (this.radioButton55.Checked == true)
                    cochereg.SetGFTraIzq("N/V");

                if (this.radioButton56.Checked == true)
                    cochereg.SetParTra("B");
                if (this.radioButton57.Checked == true)
                    cochereg.SetParTra("R");
                if (this.radioButton58.Checked == true)
                    cochereg.SetParTra("M");
                if (this.radioButton59.Checked == true)
                    cochereg.SetParTra("N/A");
                if (this.radioButton60.Checked == true)
                    cochereg.SetParTra("N/V");

                if (this.radioButton61.Checked == true)
                    cochereg.SetBomTra("B");
                if (this.radioButton62.Checked == true)
                    cochereg.SetBomTra("R");
                if (this.radioButton63.Checked == true)
                    cochereg.SetBomTra("M");
                if (this.radioButton64.Checked == true)
                    cochereg.SetBomTra("N/A");
                if (this.radioButton65.Checked == true)
                    cochereg.SetBomTra("N/V");

                if (this.radioButton66.Checked == true)
                    cochereg.SetStopIzq("B");
                if (this.radioButton67.Checked == true)
                    cochereg.SetStopIzq("R");
                if (this.radioButton68.Checked == true)
                    cochereg.SetStopIzq("M");
                if (this.radioButton69.Checked == true)
                    cochereg.SetStopIzq("N/A");
                if (this.radioButton70.Checked == true)
                    cochereg.SetStopIzq("N/V");

                if (this.radioButton71.Checked == true)
                    cochereg.SetLFreAux("B");
                if (this.radioButton72.Checked == true)
                    cochereg.SetLFreAux("R");
                if (this.radioButton73.Checked == true)
                    cochereg.SetLFreAux("M");
                if (this.radioButton74.Checked == true)
                    cochereg.SetLFreAux("N/A");
                if (this.radioButton75.Checked == true)
                    cochereg.SetLFreAux("N/V");

                if (this.radioButton76.Checked == true)
                    cochereg.SetExpTra("B");
                if (this.radioButton77.Checked == true)
                    cochereg.SetExpTra("R");
                if (this.radioButton78.Checked == true)
                    cochereg.SetExpTra("M");
                if (this.radioButton79.Checked == true)
                    cochereg.SetExpTra("N/A");
                if (this.radioButton80.Checked == true)
                    cochereg.SetExpTra("N/V");

                if (this.radioButton81.Checked == true)
                    cochereg.SetStopDer("B");
                if (this.radioButton82.Checked == true)
                    cochereg.SetStopDer("R");
                if (this.radioButton83.Checked == true)
                    cochereg.SetStopDer("M");
                if (this.radioButton84.Checked == true)
                    cochereg.SetStopDer("N/A");
                if (this.radioButton85.Checked == true)
                    cochereg.SetStopDer("N/V");

                if (this.radioButton86.Checked == true)
                    cochereg.SetPTraDer("B");
                if (this.radioButton87.Checked == true)
                    cochereg.SetPTraDer("R");
                if (this.radioButton88.Checked == true)
                    cochereg.SetPTraDer("M");
                if (this.radioButton89.Checked == true)
                    cochereg.SetPTraDer("N/A");
                if (this.radioButton90.Checked == true)
                    cochereg.SetPTraDer("N/V");

                if (this.radioButton200.Checked == true)
                    cochereg.SetGFTraDer("B");
                if (this.radioButton201.Checked == true)
                    cochereg.SetGFTraDer("R");
                if (this.radioButton202.Checked == true)
                    cochereg.SetGFTraDer("M");
                if (this.radioButton203.Checked == true)
                    cochereg.SetGFTraDer("N/A");
                if (this.radioButton204.Checked == true)
                    cochereg.SetGFTraDer("N/V");

                if (this.radioButton195.Checked == true)
                    cochereg.SetPDelDer("B");
                if (this.radioButton196.Checked == true)
                    cochereg.SetPDelDer("R");
                if (this.radioButton197.Checked == true)
                    cochereg.SetPDelDer("M");
                if (this.radioButton198.Checked == true)
                    cochereg.SetPDelDer("N/A");
                if (this.radioButton199.Checked == true)
                    cochereg.SetPDelDer("N/V");

                if (this.radioButton91.Checked == true)
                    cochereg.SetVPDelDer("B");
                if (this.radioButton92.Checked == true)
                    cochereg.SetVPDelDer("R");
                if (this.radioButton93.Checked == true)
                    cochereg.SetVPDelDer("M");
                if (this.radioButton94.Checked == true)
                    cochereg.SetVPDelDer("N/A");
                if (this.radioButton95.Checked == true)
                    cochereg.SetVPDelDer("N/V");

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

