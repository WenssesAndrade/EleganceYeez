using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejador;
namespace Diseño_Yeez
{
    public partial class ccinventario2 : Form
    {
        private ManejadorYeez _manejador;
        private Inventario _producto;
        public string banGuardar;

        public cventas Cventas { get; }

        public ccinventario2(cinventario cinventario)
        {
            InitializeComponent();
            _manejador = new ManejadorYeez();
            _producto = new Inventario();
        }

        public ccinventario2(cventas cventas)
        {
            Cventas = cventas;
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void AgregarInventario()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banGuardar == "guardar")
            {
                GuardarProductos();
                AgregarInventario();
                Close();
            }
            else
            {
                ActualizarProducto();
                Close();
            }
        }


        private void GuardarProductos()
        {

            _producto.IdProducto = txtNombre.Text;
            _producto.Descripcion = txtDesc.Text;
            _producto.Cantidad = int.Parse(txtCantidad.Text);
            _producto.Precio = double.Parse(txtPrecio.Text);
            _producto.Status = txtstatus.Text;

            var valida = _manejador.ValidarInventario(_producto);

            if (valida.Item1)
            {
                _manejador.GuardarInventario(_producto);
            }

            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarProducto()
        {
            _manejador.ActualizarInventario(new Inventario
            {
                IdProducto = txtNombre.Text,
                Descripcion = txtDesc.Text,
                Cantidad = int.Parse(txtCantidad.Text),
                Precio = double.Parse(txtPrecio.Text),
                Status = txtstatus.Text

            });
        }

       
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
