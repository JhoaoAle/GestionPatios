using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoInventariosBD
{
    public class Carro
    {
        public Carro() { }

        public static string BomDel;
        public static string Persiana;
        public static string FarIzq;
        public static string ParDel;
        public static string EspRetIzq;
        public static string GFDelIzq;
        public static string PDelIzq;
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

        public void SetEsptretIzq(string x)
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
        public static string AntRadPas { get; set; }
        public static string Encendedor { get; set; }
        public static string RadTel { get; set; }
        public static string AntRadTel { get; set; }
        public static string LlaRes { get; set; }
        public static string Herramientas { get; set; }
        public static string Bateria { get; set; }
        public static string Limpiabrisas { get; set; }
        public static string Otros { get; set; }
        public static string Marca { get; set; }
        public static string PlacaNum { get; set; }
        public static string Color { get; set; }
        public static Boolean debegrua { get; set; }
        public static Boolean dejallaves { get; set; }
        public static int NumPar { get; set; }
        public static int NumParlantes { get; set; }
        









    }
}
