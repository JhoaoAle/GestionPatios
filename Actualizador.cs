using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ManejoInventariosBD
{
    class Actualizador
    {
        public static MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c");
        public Actualizador() { }
        public void updatequery(string tipo, int inventario, DateTime fechasal, DateTime horasal)
        {
            string query;

            if (tipo == "Moto" || tipo == "Motocarro")
            {
                query = "UPDATE `invent_motos` SET `Fecha_Salida`='" + fechasal.ToString("yyyy-MM-dd") + "', `Hora_Salida`='" + horasal.ToString("H:mm:ss") + "' WHERE (`Inventario`='" + inventario + "' AND `Tipo Vehiculo`='" + tipo + "')";
            }
            else
            {
                query = "UPDATE `invent_carros` SET `Fecha_Salida`='" + fechasal.ToString("yyyy-MM-dd") + "', `Hora_Salida`='" + horasal.ToString("H:mm:ss") + "' WHERE (`Inventario`='" + inventario + "' AND `Tipo Vehiculo`='" + tipo + "')";
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



    }
}
