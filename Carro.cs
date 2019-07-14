using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ManejoInventariosBD
{
    public class Carro
    {
        public static MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c");
        public Carro() { }

        public static string BomDel;
        public static string Persiana;
        public static string FarIzq;
        public static string ParDel;
        public static string EspRetIzq;
        public static string GFDelIzq;
        public static string PDelIzq;
        public static string PTraIzq;
        public static string VPDelIzq;
        public void SetBomDel(string x)
        {
            BomDel = x;
        }

        public string GetBomDel()
        {
            return BomDel;
        }
        

        public void SetPersiana(string x)
        {
            Persiana = x;
        }
        public string GetPersiana()
        {
            return Persiana;
        }

        public void SetFarIzq(string x)
        {
            FarIzq = x;
        }
        public string GetFarIzq()
        {
            return FarIzq;
        }

        public void SetParDel(string x)
        {
            ParDel = x;
        }
        public string GetParDel()
        {
            return ParDel;
        }

        public void SetEspRetIzq(string x)
        {
            EspRetIzq = x;
        }
        public string GetEspRetIzq()
        {
            return EspRetIzq;
        }

        public void SetGFDelIzq(string x)
        {
            GFDelIzq = x;
        }
        public string GetGFDelIzq()
        {
            return GFDelIzq;
        }


        public void SetPDelIzq(string x)
        {
            PDelIzq = x;
        }
        public string GetPDelIzq()
        {
            return PDelIzq; ;
        }

        public void SetPTraIzq(string x)
        {
            PTraIzq = x;
        }
        public string GetPTraIzq()
        {
            return PTraIzq; ;
        }

        public void SetVPDelIzq(string x)
        {
            VPDelIzq = x;
        }
        public string GetVPDelIzq()
        {
            return VPDelIzq;
        }


        public static string VPTraIzq;

        public void SetVPTraIzq(string x)
        {
            VPTraIzq = x;
        }
        public string GetVPTraIzq()
        {
            return VPDelIzq;
        }

        public static string GFTraIzq;

        public void SetGFTraIzq(string x)
        {
            GFTraIzq = x;
        }
        public string GetGFTraIzq()
        {
            return GFTraIzq;
        }

        public static string ParTra;
        public void SetParTra(string x)
        {
            ParTra = x;
        }
        public string GetParTra()
        {
            return ParTra;
        }
        public static string BomTra;
        public void SetBomTra(string x)
        {
            BomTra = x;
        }
        public string GetBomTra()
        {
            return BomTra;
        }
        public static string StopIzq;
        public void SetStopIzq(string x)
        {
            StopIzq = x;
        }
        public string GetStopIzq()
        {
            return StopIzq;
        }
        public static string LFreAux;
        public void SetLFreAux(string x)
        {
            LFreAux = x;
        }
        public string GetLFreAux()
        {
            return LFreAux;
        }
        public static string ExpTra;
        public void SetExpTra(string x)
        {
            ExpTra = x;
        }
        public string GetExpTra()
        {
            return ExpTra;
        }

        public static string StopDer;
        public void SetStopDer(string x)
        {
            StopDer = x;
        }
        public string GetStopDer()
        {
            return StopDer;
        }

        public static string PTraDer;
        public void SetPTraDer(string x)
        {
            PTraDer = x;
        }
        public string GetPTraDer()
        {
            return PTraDer;
        }
        public static string GFTraDer;
        public void SetGFTraDer(string x)
        {
            GFTraDer = x;
        }

        public string GetGFTraDer()
        {
            return GFTraDer;
        }
        public static string PDelDer;
        public void SetPDelDer(string x)
        {
            PDelDer = x;
        }
        public string GetPDelDer()
        {
            return PDelDer;
        }
        public static string VPDelDer;
        public void SetVPDelDer(string x)
        {
            VPDelDer = x;
        }
        public string GetVPDelDer()
        {
            return VPDelDer;
        }

        public static string VPTraDer;
        public void SetVPTraDer(string x)
        {
            VPTraDer = x;
        }
        public string GetVPTraDer()
        {
            return VPTraDer;
        }
        public static string GFDelDer;
        public void SetGFDelDer(string x)
        {
            GFDelDer = x;
        }
        public string GetGFDelDer()
        {
            return GFDelDer;
        }
        public static string EspRetDer;
        public void SetEspRetDer(string x)
        {
            EspRetDer = x;
        }
        public string GetEspRetDer()
        {
            return EspRetDer;
        }
        public static string FarDer;
        public void SetFarDer(string x)
        {
            FarDer = x;
        }
        public string GetFarDer()
        {
            return FarDer;
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
        public static string ExpDel;
        public void SetExpDel(string x)
        {
            ExpDel = x;
        }
        public string GetExpDel()
        {
            return ExpDel;
        }
        public static string DirDelIzq;
        public void SetDirDelizq(string x)
        {
            DirDelIzq = x;
        }
        public string GetDirDelIzq()
        {
            return DirDelIzq;
        }
        public static string CojDel;
        public void SetCojDel(string x)
        {
            CojDel = x;
        }
        public string GetCojDel()
        {
            return CojDel;
        }
        public static string CojTra;
        public void SetCojTra(string x)
        {
            CojTra= x;
        }
        public string GetCojTra()
        {
            return CojTra;
        }
        public static string EspInt;
        public void SetEspInt(string x)
        {
            EspInt = x;
        }
        public string GetEspInt()
        {
            return EspInt;
        }
        public static string RadPas;
        public void SetRadPas(string x)
        {
            RadPas = x;
        }
        public string GetRadPas()
        {
            return RadPas;
        }
        public static string Par;
        public void SetPar(string x)
        {
            Par = x;
        }
        public string GetPar()
        {
            return Par;
        }
        public static string AntRadPas;
        public void SetAntradPas(string x)
        {
            AntRadPas = x;
        }
        public string GetAntRadPas()
        {
            return AntRadPas;
        }
        public static string Enc;
        public void SetEnc(string x)
        {
            Enc = x;
        }
        public string GetEnc()
        {
            return Enc;
        }
        public static string RadTel;
        public void SetRadTel(string x)
        {
            RadTel = x;
        }
        public string GetRadTel()
        {
            return RadTel;
        }
        public static string AntRadTel;
        public void SetAntRadTel(string x)
        {
            AntRadTel = x;
        }
        public string GetAntRadTel()
        {
            return AntRadTel;
        }
        public static string LlaRes;
        public void SetLlaRes(string x)
        {
            LlaRes = x;
        }
        public string GetLlaRes()
        {
            return LlaRes;
        }
        public static string Her;
        public void SetHer(string x)
        {
            Her = x;
        }
        public string GetHer()
        {
            return Her;
        }
        public static string Bat;
        public void SetBat(string x)
        {
            Bat = x;
        }
        public string GetBat()
        {
            return Bat;
        }
        public static string Lim;
        public void SetLim(string x)
        {
            Lim = x;
        }
        public string GetLim()
        {
            return Lim;
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
        public static string color;
        public void SetColor(string x)
        {
            color = x;
        }
        public string GetColor()
        {
            return color;
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
        public int Getdejallaves()
        {
            return dejallaves;
        }
        public static int NumPar;
        public void SetNumPar(int x)
        {
            NumPar = x;
        }
        public int GetNumPar()
        {
            return NumPar;
        }
        public static int NumParlantes;
        public void SetNumParlantes(int x)
        {
            NumParlantes = x;
        }
        public int GetNumParlantes()
        {
            return NumParlantes;
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



        Propietario p;

        public void runQuery(string tipo, string encargadodc, Propietario p1, string observaciones)
        {
            
            string query = "INSERT IGNORE INTO `invent_carros`(`Inventario`, `Fecha_Entrada`, `Hora_Entrada`, `Fecha_Salida`, `Hora_Salida`, `Autoridad`,`Motivo`, `Encargado DC`, `Tipo Vehiculo`, `Propietario`, `Direccion`, `CC`, `Telefono`, `BomperDel`, `Persiana`, `Far_Izq`, `Par_Del`, `EspRet_Izq`, `GF_Del_Izq`, `P_Del_Izq`, `P_Tra_Izq`, `VidP_Del_Izq`, `VidP_Tra_Izq`, `GF_Tra_Izq`, `Par_Tra`, `Bom_Tra`, `Stop_Izq`, `LuzFre_Aux`, `Exp_Tra`, `Stop_Der`, `P_Tra_Der`, `GF_Tra_Der`, `P_Del_Der`, `VidP_Del_Der`, `VidP_Tra_Der`, `GF_Del_Der`, `EspRet_Der`, `Far_Del`, `Dir_Del_Der`, `Exp_Der`, `Dir_Del_Izq`, `Coj_Del`, `Coj_Tra`, `Esp_Int`, `Rad_Pas`, `Parlantes`, `No_Par`, `Ant_Rad_Pas`, `Encendedor`, `Rad_tel`, `Ant_Rad_Tel`, `Lla_Res`, `Herramientas`, `Bateria`, `No_Lim_Par`, `Lim_Par`, `Otros`, `Observaciones`, `Debe_Grua`, `Dejan_Llaves`, `ValorPatios`, `Marca`, `PlacaNum`, `Color`)  VALUES ('" + inventario + "','"
                + fechaentrada.ToString("yyyy-MM-dd") + "','" + horaentrada.ToString("H:mm:ss") + "',NULL,NULL,'" + autoridad + "','" + motivo + "','" + encargadodc
                + "','" + tipo + "'," + (GetDbValue(p1.nombre)) + "," + (GetDbValue(p1.direccion)) + "," + (GetDbValue(p1.cedula.ToString()))
                + "," + (GetDbValue(p1.telefono.ToString())) + ",'" + BomDel + "','" + Persiana + "','" + FarIzq
                + "','" + ParDel + "','" + EspRetIzq + "','" + GFDelIzq + "','" + PDelIzq
                + "','" + PTraIzq + "','" + VPDelIzq + "','" + VPTraIzq + "','" + GFTraIzq
                + "','" + ParTra+ "','" + BomTra + "','" + StopIzq + "','" + LFreAux
                + "','" + ExpTra + "','" + StopDer + "','" + PTraDer + "','" + GFTraDer
                + "','" + PDelDer + "','" + VPDelDer+ "','" + VPTraDer + "','" + GFDelDer
                + "','" + EspRetDer + "','" + FarDer + "','" + DirDelDer + "','" + ExpDel
                + "','" + DirDelIzq + "','" + CojDel + "','" + CojTra + "','" + EspInt
                + "','" + RadPas+ "','" + Par + "','" + NumParlantes + "','" + AntRadPas+ "','" + Enc
                + "','" + RadTel + "','" + AntRadTel + "','" + LlaRes+ "','" + Her
                + "','" + Bat+ "','" + NumPar + "','" + Lim + "','" + Otros + "'," + (GetDbValue(observaciones)) + ",'" + debegrua
                + "','" + dejallaves + "',NULL," + (GetDbValue(Marca)) + "," + (GetDbValue(PlacaNum)) + ",'" + color + "');";
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

        private String GetDbValue(String data)
        {
            if (String.IsNullOrEmpty(data))
                return "NULL";
            else
                return "'" + data + "'";
        }







    }
}
