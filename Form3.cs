using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //  write down it at the top of the FORM



namespace ManejoInventariosBD
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SoundPlayer my_wave_file = new SoundPlayer("C:/Users/PC/Desktop/ProyectoBD/ManejoInventariosBD/177507__snapper4298__snap-6.wav");
            my_wave_file.PlaySync();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
