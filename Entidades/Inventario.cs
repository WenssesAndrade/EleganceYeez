using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventario
    {      
        private string _idProducto;
        private string _pDescripcion;
        private int _pCantidad;
        private double _pPrecio;
        private string _pstatus;


        public string IdProducto { get => _idProducto; set => _idProducto = value; }
        public string Descripcion { get => _pDescripcion; set => _pDescripcion = value; }
        public int Cantidad { get => _pCantidad; set => _pCantidad = value; }
        public double Precio { get => _pPrecio; set => _pPrecio = value; }
        public string Status { get => _pstatus; set => _pstatus = value; }
       
    }
}
