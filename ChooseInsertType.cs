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
        public string formres;

        public static MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c");
        public ChooseInsertType()
        {
            InitializeComponent();
            label2.Text = Form1.obtenervalor;
            

    }



  


    private void ChooseInsertType_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            cmd = new MySqlCommand("SELECT * FROM `tipos_veh`", databaseConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myTable");
            da.Fill(table);
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "Tipo";
            
        }

        public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                MySqlCommand cmd1;
                cmd1 = new MySqlCommand("SELECT `Form_Asociado` FROM `tipos_veh` WHERE `Tipo` = '" + comboBox1.Text + "'", databaseConnection);
                databaseConnection.Open();
                formres = cmd1.ExecuteScalar().ToString();
                databaseConnection.Close();
            }


            if (formres=="Moto")
            {
                this.Hide();
                FormMotos f = new FormMotos(this.comboBox1.Text.ToString());
                f.Show();
            }

            if (formres == "Carro")
            {
                this.Hide();
                FormVehiculos f = new FormVehiculos(this.comboBox1.Text.ToString());

                f.Show();
                this.Hide();
              
            }
            
        }

        
       
    }
}
