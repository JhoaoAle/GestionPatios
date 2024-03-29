﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ManejoInventariosBD
{
    public class Moto
    {

        public static MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c");



        public Moto() { }

        public Propietario propietario;


        public static string Farola;
        public void SetFarola(string x)
        {
            Farola = x;
        }

        public string GetFarola()
        {
            return Farola;
        }
        public static string Exploradora;
        public void SetExploradora(string x)
        {
            Exploradora = x;
        }

        public string GetExploradora()
        {
            return Exploradora;
        }
        public static string Carenaje;
        public void SetCarenaje(string x)
        {
            Carenaje = x;
        }

        public string GetCarenaje()
        {
            return Carenaje;
        }
        public static string Pito;
        public void SetPito(string x)
        {
            Pito = x;
        }

        public string GetPito()
        {
            return Pito;
        }
        public static string GBDel;
        public void SetGBDel(string x)
        {
            GBDel = x;
        }

        public string GetGBDel()
        {
            return GBDel;
        }
        public static string FrenoDisco;
        public void SetFrenoDisco(string x)
        {
            FrenoDisco = x;
        }

        public string GetFrenoDisco()
        {
            return FrenoDisco;
        }
        public static string Tablero;
        public void SetTablero(string x)
        {
            Tablero = x;
        }

        public string GetTablero()
        {
            return Tablero;
        }
        public static string DirDelIzq;
        public void SetDirDelIzq(string x)
        {
            DirDelIzq = x;
        }

        public string GetDirDelIz()
        {
            return DirDelIzq;
        }
        public static string EspIzq;
        public void SetEspizq(string x)
        {
            EspIzq = x;
        }

        public string GetEspizq()
        {
            return EspIzq;
        }
        public static string ManDirIzq;
        public void SetManDirIzq(string x)
        {
            ManDirIzq = x;
        }

        public string GetManDirIzq()
        {
            return ManDirIzq;
        }
        public static string ManIzq;
        public void SetManIzq(string x)
        {
            ManIzq = x;
        }

        public string GetManIzq()
        {
            return ManIzq;
        }
        public static string PrManIzq;
        public void SetPrManIzq(string x)
        {
            PrManIzq = x;
        }

        public string GetPrManIzq()
        {
            return PrManIzq;
        }
        public static string DirDelDer;
        public void SetDirDelDer(string x)
        {
            DirDelDer = x;
        }

        public string GetDirDelDer()
        {
            return DirDelDer;
        }
        public static string EspDer;
        public void SetEspDer(string x)
        {
            EspDer = x;
        }

        public string GetEspDer()
        {
            return EspDer;
        }
        public static string ManDirDer;
        public void SetManDirDer(string x)
        {
            ManDirDer = x;
        }

        public string GetManDirDer()
        {
            return ManDirDer;
        }
        public static string ManFreDer;
        public void SetManFreDer(string x)
        {
            ManFreDer = x;
        }

        public string GetManFreDer()
        {
            return ManFreDer;
        }
        public static string PrManFreDer;
        public void SetPrManFreDer(string x)
        {
            PrManFreDer = x;
        }

        public string GetPrManFreDer()
        {
            return PrManFreDer;
        }
        public static string TanCom;
        public void SetTanCom(string x)
        {
            TanCom = x;
        }

        public string GetTanCom()
        {
            return TanCom;
        }
        public static string TTanCom;
        public void SetTTanCom(string x)
        {
            TTanCom = x;
        }

        public string GetTTanCom()
        {
            return TTanCom;
        }
        public static string Barbero;
        public void SetBarbero(string x)
        {
            Barbero = x;
        }

        public string GetBarbero()
        {
            return Barbero;
        }
        public static string Pata;
        public void SetPata(string x)
        {
            Pata = x;
        }

        public string GetPata()
        {
            return Pata;
        }
        public static string Gato;
        public void SetGato(string x)
        {
            Gato = x;
        }

        public string GetGato()
        {
            return Gato;
        }
        public static string TapLatIzq;
        public void SetTapLatIzq(string x)
        {
            TapLatIzq = x;
        }

        public string GetTapLatIzq()
        {
            return TapLatIzq;
        }
        public static string GCad;
        public void SetGCad(string x)
        {
            GCad = x;
        }

        public string GetGCad()
        {
            return GCad;
        }
        public static string Sillin;
        public void SetSillin(string x)
        {
            Sillin = x;
        }

        public string GetSillin()
        {
            return Sillin;
        }
        public static string Parrilla;
        public void SetParrilla(string x)
        {
            Parrilla = x;
        }

        public string GetParrilla()
        {
            return Parrilla;
        }
        public static string GBarTra;
        public void SetGBarTra(string x)
        {
            GBarTra = x;
        }

        public string GetGBarTra()
        {
            return GBarTra;
        }
        public static string DirTraIzq;
        public void SetDirTraIzq(string x)
        {
            DirTraIzq = x;
        }

        public string GetDirTraIzq()
        {
            return DirTraIzq;
        }
        public static string Amortiguadores;
        public void SetAmortiguadores(string x)
        {
            Amortiguadores = x;
        }

        public string GetAmortiguadores()
        {
            return Amortiguadores;
        }
        public static string Exosto;
        public void SetExosto(string x)
        {
            Exosto = x;
        }

        public string GetExosto()
        {
            return Exosto;
        }
        public static string Placa;
        public void SetPlaca(string x)
        {
            Placa = x;
        }

        public string GetPlaca()
        {
            return Placa;
        }
        public static string DirTraDer;
        public void SetDirTraDer(string x)
        {
            DirTraDer = x;
        }

        public string GetDirTraDer()
        {
            return DirTraDer;
        }

        public static string TapLatDer;
        public void SetTapLatDer(string x)
        {
            TapLatDer = x;
        }

        public string GetTapLatDer()
        {
            return TapLatDer;
        }
        public static string Bateria;
        public void SetBateriaa(string x)
        {
            Bateria = x;
        }

        public string GetBateria()
        {
            return Bateria;
        }
        public static string Tacos;
        public void SetTacos(string x)
        {
            Tacos = x;
        }

        public string GetTacos()
        {
            return Tacos;
        }
        public static string PalFrePie;
        public void SetPalFrePie(string x)
        {
            PalFrePie = x;
        }

        public string GetPalFrePie()
        {
            return PalFrePie;
        }
        public static string Cran;
        public void SetCran(string x)
        {
            Cran = x;
        }

        public string GetCran()
        {
            return Cran;
        }
        public static string Otros;
        public void SetOtros(string x)
        {
            Otros = x;
        }

        public string GetOtros()
        {
            return Otros;
        }
        public static string Marca;
        public void SetMarca(string x)
        {
            Marca = x;
        }
        public string GetMarca()
        {
            return Marca;
        }

        public static string PlacaNum;
        public void SetPlacaNum(string x)
        {
            PlacaNum = x;
        }
        public string GetPlacaNum()
        {
            return PlacaNum;
        }
        public static string Color;
        public void SetColor(string x)
        {
            Color = x;
        }
        public string GetColor()
        {
            return Color;
        }
        public static int debegrua;
        public void Setdebegrua(int x)
        {
            debegrua = x;
        }
        public int Getdebegrua()
        {
            return debegrua;
        }
        public static int dejallaves;
        public void Setdejallaves(int x)
        {
            dejallaves = x;
        }

        public static DateTime fechaentrada;
        public static DateTime horaentrada;

        public void setHoraEntrada(DateTime x)
        {
            horaentrada = x;
        }

        public void setFechaEntrada(DateTime x)
        {
            fechaentrada = x;
        }

        public DateTime getHoraEntrada(DateTime x)
        {
            return horaentrada;
        }

        public DateTime getFechaEntrada(DateTime x)
        {
            return fechaentrada;
        }


        public int Getdejallaves()
        {
            return dejallaves;
        }

        public int inventario;
        public void setInventario(int x)
        {
            inventario = x;
        }

        public int getInventario()
        {
            return inventario;
        }

        public string autoridad;
        public void setAutoridad(string x)
        {
            autoridad = x;
        }

        public string getAutoridad()
        {
            return autoridad;
        }

        public string motivo;
        public void setMotivo(string x)
        {
            motivo = x;
        }

        public string getMotivo()
        {
            return motivo;
        }



        public void runQuery(string tipo, string encargadodc, Propietario p1, string observaciones)
        {
            



            string query = "INSERT IGNORE INTO `invent_motos`(`Inventario`, `Fecha_Entrada`, `Hora_Entrada`, `Fecha_Salida`, `Hora_Salida`, `Autoridad`,`Motivo`, `Encargado DC`, `Tipo Vehiculo`, `Propietario`, `Direccion`, `CC`, `Telefono`, `Farola`, `Exploradora`, " +
                "`Carenaje`, `Pito`, `GB_Del`, `FrenoDisco`, `Tablero`, `DirDel_Izq`, `Esp_zq`, `ManDir_Izq`, `Man_Izq`, `ProtMan_Izq`, `DirDel_Der`, `Esp_Der`, `ManDir_Der`, `ManFre_Der`, `ProtMan_Der`, `TC`, `Tapa_TC`, `Babero`, `Pata`, `Gato`, `TapLat_Izq`, `GuardaCadena`, `Sillin`, `Parrilla`, `GB_Trasero`, `DirTra_Izq`, `Amortiguadores`, `Exosto`, `Placa`, `DirTra_Der`, `TapLat_Der`, `Bateria`, `Tacos`, `PalFre_Pie`, `Cran`, `Otros`, `Observaciones`, `Debe_Grua`, `Dejan_Llaves`, `Valor`, `Marca`, `PlacaNum`, `Color`) VALUES ('" + inventario
                + "','" + fechaentrada.ToString("yyyy-MM-dd") + "','" + horaentrada.ToString("H:mm:ss") + "',NULL,NULL,'" + autoridad + "','"+motivo+"','" + encargadodc
                + "','" + tipo + "'," + (GetDbValue(p1.nombre)) + "," + (GetDbValue(p1.direccion)) + "," + (GetDbValue(p1.cedula.ToString()))
                + "," + (GetDbValue(p1.telefono.ToString())) + ",'" + Farola + "','" + Exploradora + "','" + Carenaje
                + "','" + Pito + "','" + GBDel + "','" + FrenoDisco + "','" + Tablero + "','" + DirDelIzq
                + "','" + EspIzq + "','" + ManDirIzq + "','" + ManIzq + "','" + PrManIzq + "','" + DirDelDer
                + "','" + EspDer + "','" + ManDirDer + "','" + ManFreDer + "','" + PrManFreDer + "','" + TanCom
                + "','" + TTanCom + "','" + Barbero+ "','" + Pata + "','" + Gato + "','" + TapLatIzq
                + "','" + GCad + "','" + Sillin + "','" + Parrilla+ "','" + GBarTra + "','" + DirTraIzq
                + "','" + Amortiguadores+ "','" + Exosto + "','" + Placa + "','" + DirTraDer + "','" + TapLatDer
                + "','" + Bateria+ "','" + Tacos+ "','" + PalFrePie + "','" + Cran + "','" + Otros
                + "'," + (GetDbValue(observaciones)) + ",'" + debegrua+ "','" + dejallaves+ "',NULL,'" + Marca + "','" + PlacaNum
                + "','" + Color + "');";



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

        private String GetDbValue(String data)
        {
            if (String.IsNullOrEmpty(data))
                return "NULL";
            else
                return "'" + data + "'";
        }

    }
}
