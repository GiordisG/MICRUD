using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICRUD.modelo
{
    class persona
    {
        private string nombres;
        private string direccion;
        private string cedula;
        private string telefono;
        private string documento;

        public persona()
        {
            this.nombres = "";
            this.direccion = "";
            this.cedula = "";
            this.telefono = "";
            this.documento = "";
        }

        public string Nombres { get => nombres; set => nombres = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Documento { get => documento; set => documento = value; }
    }
}
