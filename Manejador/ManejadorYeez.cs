using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;
namespace Manejador
{
    public class ManejadorYeez
    {
        AccesoDatosYeez _accesodatosyeez = new AccesoDatosYeez();

        //*********************Inventario*******************      
        public Tuple<bool, string> ValidarInventario(Inventario inventario)
        {
            bool error = true;
            string cadenaErrores = "";

            if (inventario.IdProducto.Length == 0 || inventario.IdProducto == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Nombre\" no puede ser vacio. \n";
                error = false;
            }
            if (inventario.Descripcion.Length == 0 || inventario.Descripcion == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Descripción\" no puede ser vacio. \n";
                error = false;
            }
          
            if (inventario.Cantidad == null)
            {
                cadenaErrores = cadenaErrores + "El campo Cantidad no puede ser vacio \n";
                error = false;
            }

            if (inventario.Precio == null)
            {
                cadenaErrores = cadenaErrores + "El campo PRECIO no puede ser vacio \n";
                error = false;
            }
            if (inventario.Status.Length == 0 || inventario.Status == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Status\" no puede ser vacio. \n";
                error = false;
            }
           
            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }


        public void GuardarInventario(Inventario inventario)
        {
            try
            {
                _accesodatosyeez.GuardarInventario(inventario);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló el guardado" + ex.Message);
            }
        }
        public void ActualizarInventario(Inventario inventario)
        {
            try
            {
                _accesodatosyeez.ActualizarInventario(inventario);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la actualización" + ex.Message);
            }
        }
        public List<Inventario> ObtenerInventario(string filtro)
        {
            var listaInventario = _accesodatosyeez.ObtenerInventario(filtro);
            return listaInventario;
        }
        public void EliminarInventario(string categoria)
        {
            try
            {
                _accesodatosyeez.EliminarInventario(categoria);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la eliminación" + ex.Message);
            }
        }
        //*********************Ventas*******************
        public Tuple<bool, string> ValidarVentas(Ventas ventas)
        {
            bool error = true;
            string cadenaErrores = "";

            if (ventas.IdVenta.Length == 0 || ventas.IdVenta == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"IdVenta\" no puede ser vacio. \n";
                error = false;
            }
            if (ventas.FechayHora.Length == 0 || ventas.FechayHora == null)
              {
                  cadenaErrores = cadenaErrores + "El campo \"FechayHora\" no puede ser vacio. \n";
                  error = false;
              }
            
            if (ventas.VDescripcion.Length == 0 || ventas.VDescripcion == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Descripcion\" no puede ser vacio. \n";
                error = false;
            }
            if (ventas.VServicio.Length == 0 || ventas.VServicio == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Servicio\" no puede ser vacio. \n";
                error = false;
            }
            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }
        public void GuardarVentas(Ventas ventas)
        {
            try
            {
                _accesodatosyeez.GuardarVentas(ventas);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló el guardado" + ex.Message);
            }
        }
        public void ActualizarVentas(Ventas ventas)
        {
            try
            {
                _accesodatosyeez.ActualizarVentas(ventas);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la actualización" + ex.Message);
            }
        }
        public List<Ventas> ObtenerVentas(string filtro)
        {
            var listaVentas = _accesodatosyeez.ObtenerVentas(filtro);
            return listaVentas;
        }
        public void EliminarVentas(string ventas)
        {
            try
            {
                _accesodatosyeez.EliminarVentas(ventas);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la eliminación" + ex.Message);
            }
        }
      


        //*********************Citas*******************
        public Tuple<bool, string> ValidarCitas(Citas citas)
        {
            bool error = true;
            string cadenaErrores = "";

            if (citas.IdCliente.Length == 0 || citas.IdCliente == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"IdCliente\" no puede ser vacio. \n";
                error = false;
            }
            if (citas.Fecha.Length == 0 || citas.Fecha == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Fecha\" no puede ser vacio. \n";
                error = false;
            }
            if (citas.Hora.Length == 0 || citas.Hora == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Hora\" no puede ser vacio. \n";
                error = false;
            }
            if (citas.Servicio.Length == 0 || citas.Servicio == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Servicio\" no puede ser vacio. \n";
                error = false;
            }
            if (citas.Estatus.Length == 0 || citas.Estatus == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Estatus\" no puede ser vacio. \n";
                error = false;
            }
            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }
        public void GuardarCitas(Citas citas)
        {
            try
            {
                _accesodatosyeez.GuardarCitas(citas);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló el guardado" + ex.Message);
            }
        }
        public void ActualizarCitas(Citas citas)
        {
            try
            {
                _accesodatosyeez.ActualizarCitas(citas);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la actualización" + ex.Message);
            }
        }
        public List<Citas> ObtenerCitas(string filtro)
        {
            var listaCitas = _accesodatosyeez.ObtenerCitas(filtro);
            return listaCitas;
        }
       
        public void EliminarCitas(string citas)
        {
            try
            {
                _accesodatosyeez.EliminarCitas(citas);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la eliminación" + ex.Message);
            }
        }

     
    }
}

