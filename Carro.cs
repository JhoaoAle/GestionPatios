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

        public static string PTraDer { get; set; }
        public static string GFTraDer { get; set; }
        public static string PDelDer { get; set; }
        public static string VPDelDer { get; set; }
        public static string VPTraDer { get; set; }
        public static string GFDelDer { get; set; }
        public static string EspRetDer { get; set; }
        public static string FarDer { get; set; }
        public static string DirDelDer { get; set; }
        public static string ExpDel { get; set; }
        public static string DirDelIzq { get; set; }
        public static string CojDel { get; set; }
        public static string CojTra { get; set; }
        public static string EspInt { get; set; }
        public static string RadPas { get; set; }
        public static string Par { get; set; }
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
