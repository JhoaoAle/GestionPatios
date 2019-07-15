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
    public class CrearConsulta
    {
        public static MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c");

        public CrearConsulta() { }

        public string resultquery1cond(string tabla, string campod, string campoc, string cond1)
        {
            string res;
            MySqlCommand cmd1;
            cmd1 = new MySqlCommand("SELECT `"+campod+"` FROM `"+tabla+"` WHERE `"+campoc+"` = '" + cond1 + "'", databaseConnection);
            databaseConnection.Open();
            res = cmd1.ExecuteScalar().ToString();
            databaseConnection.Close();
            return res;
        }

        public void insertTipo(string nuevotipo, string asociado)
        {
            string query = "INSERT IGNORE INTO `tipos_veh`(`Tipo`, `Form_Asociado`) VALUES ('" + nuevotipo + "','" + asociado + "')";
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            commandDatabase.CommandText = query;
            databaseConnection.Open();
            commandDatabase.ExecuteNonQuery();
            databaseConnection.Close();
        }

    }
}
