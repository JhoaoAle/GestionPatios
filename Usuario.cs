using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ManejoInventariosBD
{
    class Usuario
    {
        public static MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c");
        public Usuario() { }


        public int i;
        public string nombre;
        public void setUsuario(string x)
        {
            nombre = x;
        }

        public int geti()
        {
            return i;
        }
        

        public string clave;
        public void setClave(string x)
        {
            clave = x;
        }


        public string rol;
        public void setRol(string x)
        {
            rol = x;
        }


        public void runQuery()
        {
            string query = "INSERT IGNORE INTO `usuarios`(`Usuario`, `Clave`, `Rol`) VALUES ('" + nombre + "','" + clave + "','" + rol + "')";
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

        public int Seti(string usuario, string cont)
        {
            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM `usuarios` WHERE `Usuario`='" + usuario + "' AND `Clave`='" + cont + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            databaseConnection.Close();
            return i;
        }

        public string getrol(string usuario, string cont)
        {
            string activ;
            MySqlCommand cmd1;
            cmd1 = new MySqlCommand("SELECT `Rol` FROM `usuarios` where `Usuario`='" + usuario + "' AND `Clave`='" + cont + "'", databaseConnection);
            databaseConnection.Open();
            activ = cmd1.ExecuteScalar().ToString();
            databaseConnection.Close();
            return activ;
        }



    }
}
