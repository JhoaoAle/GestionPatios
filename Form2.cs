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
        public static MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c");
        public Form2()
        {

            
            InitializeComponent();
        }

        CrearTabla ct = new CrearTabla();


        private void button2_Click(object sender, EventArgs e)
        {

            BindingSource bSource = new BindingSource();
            bSource.DataSource = ct.tablaforenc(comboBox1.Text);
            dataGridView1.DataSource = bSource;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BindingSource bSource = new BindingSource();
            bSource.DataSource = ct.tablaforfecha(dateTimePicker1.Value);
            dataGridView1.DataSource = bSource;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindingSource bSource = new BindingSource();
            bSource.DataSource = ct.tablaforinvent(textBox1.Text);
            dataGridView1.DataSource = bSource;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ct.recibetabla1cond("usuarios","Usuario","Rol","Encargado");
            comboBox1.DisplayMember = "Usuario";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroUsuario f = new RegistroUsuario();
            this.Hide();
            f.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTipo f = new FormTipo();
            this.Hide();
            f.Show();
        }
    }
}
