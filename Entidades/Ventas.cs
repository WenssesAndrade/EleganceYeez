using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ventas
    {

        private string _idVenta;
        private string _FechayHora;
        private string _vDescripcion;
        private string _vServicio;

        public string IdVenta { get => _idVenta; set => _idVenta = value; }
        public string FechayHora { get => _FechayHora; set => _FechayHora = value; }
        public string VDescripcion { get => _vDescripcion; set => _vDescripcion = value; }
        public string VServicio { get => _vServicio; set => _vServicio = value; }
    }
}
