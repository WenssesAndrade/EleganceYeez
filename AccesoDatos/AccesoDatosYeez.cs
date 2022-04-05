using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class AccesoDatosYeez
    {

        ConexionAccesoDatos _conexion;
        public AccesoDatosYeez()
        {
            try
            {
                _conexion = new ConexionAccesoDatos("127.0.0.1", "root", "", "yeez", 3306);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falló la conexion" + ex.Message);
            }
        }

        //*********************Inventario*******************    

        public void GuardarInventario(Inventario inventario)
        {
            try
            {
                string consulta = string.Format("insert into inventario values('{0}','{1}','{2}','{3}','{4}')", inventario.IdProducto, inventario.Descripcion, inventario.Cantidad, inventario.Precio, inventario.Status);
                     
            
            
                _conexion.EjecutarConsulta(consulta);
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
                string consulta = string.Format("update categoria set pdescripcion = '{0}', pcantidad = '{1}' , pprecio = '{2}', pstatus = '{3}' where idproducto = '{4}'", inventario.Descripcion, inventario.Cantidad, inventario.Precio, inventario.Status, inventario.IdProducto);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falló la actualización" + ex.Message);
            }
        }
        public List<Inventario> ObtenerInventario(string filtro)
        {
            var ListaInventario = new List<Inventario>();
            var ds = new DataSet();
            string consulta = string.Format("select * from inventario where idproducto like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "inventario");


            var dt = new DataTable();
            dt = ds.Tables[0];


            foreach (DataRow row in dt.Rows)
            {
                var inventario = new Inventario
                {
                    IdProducto = row["idproducto"].ToString(),
                    Descripcion = row["pdescripcion"].ToString(),
                    Cantidad = int.Parse(row["pcantidad"].ToString()),
                    Precio = double.Parse(row["pprecio"].ToString()),
                    Status = row["pstatus"].ToString()
                };

                ListaInventario.Add(inventario);
            }
         
            return ListaInventario;
        }
           
    
        public void EliminarInventario(string inventario)
        {
            try
            {
                string consulta = string.Format("delete from inventario where idproducto = '{0}'", inventario);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falló la eliminación" + ex.Message);
            }
        }

        //*********************Ventas*******************  
        public void GuardarVentas(Ventas ventas)
        {
            try
            {
                string consulta = string.Format("insert into ventas values('{0}','{1}','{2}','{3}')", ventas.IdVenta, ventas.FechayHora, ventas.VDescripcion, ventas.VServicio);
                _conexion.EjecutarConsulta(consulta);
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
                string consulta = string.Format("update ventas set fechayhora = '{0}', vdescripcion = '{1}', servicio = '{2}' where idventa = '{3}'", ventas.FechayHora, ventas.VDescripcion, ventas.VServicio, ventas.IdVenta);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la actualización" + ex.Message);
            }
        }
        public List<Ventas> ObtenerVentas(string filtro)
        {
            var ListaVentas = new List<Ventas>();
            var ds = new DataSet();
            string consulta = string.Format("select * from ventas where idventa like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "ventas");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var ventas = new Ventas
                {
                    IdVenta = row["idventa"].ToString(),
                    FechayHora = row["fechayhora"].ToString(),
                    VDescripcion = row["vdescripcion"].ToString(),
                    VServicio = row["servicio"].ToString()
                };
                ListaVentas.Add(ventas);
            }
            return ListaVentas;
        }
        public void EliminarVentas(string ventas)
        {
            try
            {
                string consulta = string.Format("delete from ventas where idventa = '{0}'", ventas);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la eliminación" + ex.Message);
            }
        }
       



        //*********************Citas*******************    //
        public void GuardarCitas(Citas citas)
        {
            try
            {
                string consulta = string.Format("insert into citas values('{0}','{1}','{2}','{3}','{4}')",  citas.IdCliente, citas.Fecha, citas.Hora, citas.Servicio, citas.Estatus);
                _conexion.EjecutarConsulta(consulta);
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
                string consulta = string.Format("update citas set fecha = '{0}', hora = '{1}', servicio = '{2}', estatus = '{2}' where idcliente = '{4}'", citas.Fecha, citas.Hora, citas.Servicio, citas.Estatus, citas.IdCliente);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la actualización" + ex.Message);
            }
        }
        public List<Citas> ObtenerCitas(string filtro)
        {
            var ListaCitas = new List<Citas>();
            var ds = new DataSet();
            string consulta = string.Format("select * from citas where idcliente like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "citas");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var citas = new Citas
                {
                    IdCliente = row["idcliente"].ToString(),
                    Fecha = row["fecha"].ToString(),
                    Hora = row["hora"].ToString(),
                    Servicio = row["servicio"].ToString(),
                    Estatus = row["estatus"].ToString()
                };
                ListaCitas.Add(citas);
            }
            return ListaCitas;
        }
        public void EliminarCitas(string citas)
        {
            try
            {
                string consulta = string.Format("delete from citas where idcliente = '{0}'", citas);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la eliminación" + ex.Message);
            }
        }
    

    }
}
