using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Citas
    {
        private string _idCliente;
        private string _Fecha;
        private string _Hora;
        private string _Servicio;
        private string _Estatus;
       
        public string IdCliente { get => _idCliente; set => _idCliente = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string Hora { get => _Hora; set => _Hora = value; }
        public string Servicio { get => _Servicio; set => _Servicio = value; }
        public string Estatus { get => _Estatus; set => _Estatus = value; }
       
    }
}
