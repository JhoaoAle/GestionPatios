using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoInventariosBD
{
    public class Propietario
    {
        public Propietario() { }
        private string Nombre;
        public string nombre
        {
            get { return Nombre; }

            set { Nombre = value; }
        }
        private int? Cedula;
        public int? cedula
        {
            get { return Cedula; }

            set { Cedula = value; }
        }
        private string Direccion;
        public string direccion
        {
            get { return Direccion; }

            set { Direccion = value; }
        }
        private int? Telefono;

        public int? telefono
        {
            get { return Telefono; }

            set { Telefono = value; }
        }

    }
}
