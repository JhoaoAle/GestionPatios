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
                runQuery();
            }
        }

        private void runQuery()
        {
            string query;

            if(tipo.Text=="Moto" || tipo.Text == "Motocarro")
            {
                query = "UPDATE `invent_motos` SET `Fecha_Salida`='"+ dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', `Hora_Salida`='" + dateTimePicker2.Text + "' WHERE (`Inventario`='"+ (Int32.Parse(invnum.Text)) + "' AND `Tipo Vehiculo`='"+tipo.Text+"')";
            }
            else
            {
                query = "UPDATE `invent_carros` SET `Fecha_Salida`='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', `Hora_Salida`='" + dateTimePicker2.Text + "' WHERE (`Inventario`='" + (Int32.Parse(invnum.Text)) + "' AND `Tipo Vehiculo`='" + tipo.Text + "')";
            }
                
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

        private void FormSalida_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            cmd = new MySqlCommand("SELECT * FROM `tipos_veh`", databaseConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myTable");
            da.Fill(table);
            tipo.DataSource = table;
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
