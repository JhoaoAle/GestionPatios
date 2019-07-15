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
    //Desde aquí se gestiona lac reacion de tablas con consultas SELECT
    public class CrearTabla
    {
        public static MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c");
        public CrearTabla() { }

        //Simplemente obtiene la tabla, sin filtros ni condiciones
        public DataTable recibetabla(string tablabase)
        {
            MySqlCommand cmd;
            cmd = new MySqlCommand("SELECT * FROM `" + tablabase + "`", databaseConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable("myTable");
            da.Fill(tabla);
            return tabla;
        }
        //Obtiene los elemento de la tabla donde cierto valor de columna cumpla con la condición dada
        public DataTable recibetabla1cond(string tablabase, string campod, string campoc, string cond1)
        {
            MySqlCommand cmd;
            cmd = new MySqlCommand("SELECT `"+campod+"` FROM `"+tablabase+"` WHERE `"+campoc+"`='"+cond1+"'", databaseConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable("myTable");
            da.Fill(tabla);
            return tabla;
        }

        //Retorna el resultado de buscar por numero de inventario en las tablas de inventario, unicamente con los campos que el programador (o sease mi persona) consideró adecuados
        public DataTable tablaforinvent(string inv_num)
        {
            MySqlCommand cmd1;
            cmd1 = new MySqlCommand("SELECT `Fecha_Entrada`,`Hora_Entrada`,`Fecha_Salida`,`Hora_Salida`,`Encargado DC`,`Tipo Vehiculo`,`PlacaNum` FROM `invent_carros` WHERE `Inventario` = '" + inv_num + "' UNION SELECT `Fecha_Entrada`,`Hora_Entrada`,`Fecha_Salida`,`Hora_Salida`,`Encargado DC`,`Tipo Vehiculo`,`PlacaNum` FROM `invent_motos` WHERE `Inventario` = '" + inv_num + "'", databaseConnection);
            

            MySqlDataAdapter sda = new MySqlDataAdapter(cmd1);
            
            DataTable tabla = new DataTable("myTable");
            sda.Fill(tabla);
            return tabla;
        }

        //Retorna el resultado de buscar por encargado en las tablas de inventario, unicamente con los campos que el programador (o sease mi persona) consideró adecuados
        public DataTable tablaforenc(string enc)
        {
            MySqlCommand cmd1;
            cmd1 = new MySqlCommand("SELECT `Inventario`,`Tipo Vehiculo`,`PlacaNum` FROM `invent_carros` WHERE `Encargado DC`='" + enc + "' UNION SELECT `Inventario`,`Tipo Vehiculo`,`PlacaNum` FROM `invent_motos` WHERE `Encargado DC`='" + enc + "'", databaseConnection);


            MySqlDataAdapter sda = new MySqlDataAdapter(cmd1);

            DataTable tabla = new DataTable("myTable");
            sda.Fill(tabla);
            return tabla;
        }
        //Retorna el resultado de buscar por fecha de entrada en las tablas de inventario, unicamente con los campos que el programador (o sease mi persona) consideró adecuados
        public DataTable tablaforfecha(DateTime fecha)
        {
            MySqlCommand cmd1;
            cmd1 = new MySqlCommand("SELECT `Inventario`,`Tipo Vehiculo`,`PlacaNum` FROM `invent_carros` WHERE `Fecha_Entrada`='" + fecha.ToString("yyyy-MM-dd") + "' UNION SELECT `Inventario`,`Tipo Vehiculo`,`PlacaNum` FROM `invent_motos` WHERE `Fecha_Entrada`='" + fecha.ToString("yyyy-MM-dd") + "'", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd1);
            DataTable tabla = new DataTable("myTable");
            sda.Fill(tabla);
            return tabla;
        }

        //Esta consulta se usa para ver si el color y autoridad cortresponde a un carro, moto, o ambos. Se puede usar para procesos más generales pero no le vi necesidad
        public DataTable tablaor(string tablaor, string campod,string campoc, string cond1, string cond2)
        {
            MySqlCommand cmd1;
            cmd1 = new MySqlCommand("SELECT `"+campod+"` FROM `"+tablaor+"` WHERE `"+campoc+"` ='" +cond1+ "' OR `"+campoc+ "`='"+cond2+"'", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd1);
            DataTable tabla = new DataTable("myTable");
            sda.Fill(tabla);
            return tabla;
        }

    }
}
