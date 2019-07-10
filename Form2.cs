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
    public partial class Form2 : Form
    {
        public Form2()
        {
           

            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            
            Form3 f = new Form3();
            f.Show();
            runQuery();

        }
        private void runQuery()
        {
            string query = "DROP TABLE `invent_carros`, `invent_motos`;";
            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c";

            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            commandDatabase.CommandText = query;
            databaseConnection.Open();
            commandDatabase.ExecuteNonQuery();
            databaseConnection.Close();

            
            try
            {
                databaseConnection.Open();

                
            }catch(Exception e)
            {
                MessageBox.Show("Query Error: " + e.Message);
            }
            MySqlDataReader reader = commandDatabase.ExecuteReader();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT `Inventario`,`Tipo Vehiculo`,`PlacaNum` FROM `invent_carros` WHERE `Encargado DC`='Encargado1' UNION SELECT `Inventario`,`Tipo Vehiculo`,`PlacaNum` FROM `invent_motos` WHERE `Encargado DC`='Encargado1'";
            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            commandDatabase.CommandText = query;
            

            
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = commandDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);



                

            }
            catch(Exception exc)
            {
                MessageBox.Show("Query Error: " + exc.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT `Inventario`,`Tipo Vehiculo`,`PlacaNum` FROM `invent_carros` WHERE `Encargado DC`='Encargado2' UNION SELECT `Inventario`,`Tipo Vehiculo`,`PlacaNum` FROM `invent_motos` WHERE `Encargado DC`='Encargado2'";
            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            commandDatabase.CommandText = query;



            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = commandDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);





            }
            catch (Exception exc)
            {
                MessageBox.Show("Query Error: " + exc.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT `Inventario`,`Tipo Vehiculo`,`PlacaNum` FROM `invent_carros` WHERE `Fecha_Entrada`='"+ dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' UNION SELECT `Inventario`,`Tipo Vehiculo`,`PlacaNum` FROM `invent_motos` WHERE `Fecha_Entrada`='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'";
            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            commandDatabase.CommandText = query;



            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = commandDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);





            }
            catch (Exception exc)
            {
                MessageBox.Show("Query Error: " + exc.Message);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT `Fecha_Entrada`,`Hora_Entrada`,`Encargado DC`,`Tipo Vehiculo`,`PlacaNum` FROM `invent_carros` WHERE `Inventario` = '"+textBox1.Text+ "' UNION SELECT `Fecha_Entrada`,`Hora_Entrada`,`Encargado DC`,`Tipo Vehiculo`,`PlacaNum` FROM `invent_motos` WHERE `Inventario` = '" + textBox1.Text + "'";
            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            commandDatabase.CommandText = query;



            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = commandDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);





            }
            catch (Exception exc)
            {
                MessageBox.Show("Query Error: " + exc.Message);
            }
        }
    }
}
