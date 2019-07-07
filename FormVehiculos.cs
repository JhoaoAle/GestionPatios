using System;
using System.Linq;
using System.Windows.Forms;

namespace ManejoInventariosBD
{
    public partial class FormVehiculos : Form
    {
        private bool fail;
        string tipo;
        public FormVehiculos(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            


           //Esto es un cambio

        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormVehiculos_Load(object sender, EventArgs e)
        {

        }

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

                (panel1.Controls.OfType<RadioButton>().Any(x => x.Checked)) && (panel2.Controls.OfType<RadioButton>().Any(x => x.Checked))
                ))
            {
                MessageBox.Show("Registros incompletos, intente nuevamente");
                fail = true;
            }
            else
                fail = false;



            if (comboBox4.Text != "Patios" && comboBox4.Text != "Accidente")
            {
                MessageBox.Show("Motivo de ingreso no valido, intente nuevamente");
            }

            if (comboBox3.Text != "Policía" && comboBox3.Text != "Transito" && comboBox3.Text != "Policia de Tránsito y Transporte" && comboBox3.Text != "Juzgado" && comboBox3.Text != "Fiscalía" && comboBox3.Text != "Otro")
            {
                MessageBox.Show("Autoridad que ingresa no valida, intente nuevamente");

                fail = true;
            }
            else
                fail = false;

            int parsedValue;
            

            
            if (textBox10.Text == "")
            {
                fail = true;
                MessageBox.Show("No ha insertado un número de inventario");


            }
            else if ((!(int.TryParse(textBox6.Text, out parsedValue))))
            {
                int i = int.Parse(textBox10.Text);
                if (!(i <= 9999 && i >= 1000))
                {
                    MessageBox.Show("No ha insertado un número de inventario valido");
                    fail = true;
                    return;
                }
            }
            else
                fail = false;

            if (groupBox2.Visible == true)
            {
                if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("No ha ingresado información adicional del propietario");
                    fail = true;
                }
            }

            if (fail == false)
            {
                MessageBox.Show("Registro exitoso");
                Form4 f = new Form4();
                this.Dispose();
                f.Show();
            }
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int parsedValue;

            if (int.TryParse(textBox9.Text, out parsedValue))
            {
                MessageBox.Show("El campo 'Propietario' solo acepta caracteres, intente nuevamente");
                return;
            }
            else if (textBox9.Text != "")
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

