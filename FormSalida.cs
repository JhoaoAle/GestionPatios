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
    public partial class FormSalida : Form
    {
        public static MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c");

        public FormSalida()
        {
            InitializeComponent();
        }

        Actualizador act = new Actualizador();
        private void button1_Click(object sender, EventArgs e)
        {
            if (invnum.Text == "")
            {
                MessageBox.Show("No ha ingresado un número de inventario");
            }
            if(tipo.Text=="")
            {
                MessageBox.Show("No ha ingresado un tipo de vehiculo");
            }
            else
            {
                act.updatequery(tipo.Text, (Int32.Parse(invnum.Text)), dateTimePicker1.Value,dateTimePicker2.Value);
            }
        }

        
        
            

        private void FormSalida_Load(object sender, EventArgs e)
        {
            CrearTabla tabla = new CrearTabla();
            tipo.DataSource = tabla.recibetabla("tipos_veh");
            tipo.DisplayMember = "Tipo";
        }

        private void FormSalida_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form4 f = new Form4();
            this.Dispose();
            f.Show();
        }
    }
}
