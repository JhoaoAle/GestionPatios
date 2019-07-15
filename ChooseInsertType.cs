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
    public partial class ChooseInsertType : Form
    {
        

        public static MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c");
        public ChooseInsertType()
        {
            InitializeComponent();
            label2.Text = Form1.obtenervalor;
            

        }



  


    private void ChooseInsertType_Load(object sender, EventArgs e)
        {
            CrearTabla tabla1=new CrearTabla();
            comboBox1.DataSource = tabla1.recibetabla("tipos_veh");
            comboBox1.DisplayMember = "Tipo";
            
        }

        public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                CrearConsulta cons = new CrearConsulta();

                if (cons.resultquery1cond("tipos_veh", "Form_Asociado", "Tipo", comboBox1.Text) == "Moto")
                {
                    this.Hide();
                    FormMotos f = new FormMotos(this.comboBox1.Text.ToString());
                    f.Show();
                }

                if (cons.resultquery1cond("tipos_veh", "Form_Asociado", "Tipo", comboBox1.Text) == "Carro")
                {
                    this.Hide();
                    FormVehiculos f = new FormVehiculos(this.comboBox1.Text.ToString());

                    f.Show();
                    this.Hide();

                }
            }
        }

        private void ChooseInsertType_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form4 f = new Form4();
            this.Dispose();
            f.Show();
        }
    }
}
