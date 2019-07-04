using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ManejoInventariosBD
{
    public partial class ChooseInsertType : Form
    {
        

        public ChooseInsertType()
        {
            InitializeComponent();
            label2.Text = Form1.obtenervalor;
        }

        
        
        /* woooooooo cambio*/
        

        private void ChooseInsertType_Load(object sender, EventArgs e)
        {

        }

        public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

            if (comboBox1.Text == "Moto" || comboBox1.Text == "Motocarro")
            {
                this.Hide();
                FormMotos f = new FormMotos(this.comboBox1.SelectedItem.ToString());
                f.Show();
                this.Hide();
                
            }

            else 
            {
                this.Hide();
                FormVehiculos f = new FormVehiculos(this.comboBox1.SelectedItem.ToString());

                f.Show();
                this.Hide();
              
            }
            
        }

        
       
    }
}
