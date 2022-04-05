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
    public partial class cinventario : Form
    {
        private ManejadorYeez _manejador;
        private Inventario _inventario;
        public string banGuardar;
        public cinventario()
        {
            InitializeComponent();
            _manejador = new ManejadorYeez();
            _inventario = new Inventario();
            CargarInventario("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarInventario("");
            ccinventario2 cci2 = new ccinventario2(this);
            cci2.banGuardar = "guardar";
            cci2.UpdateEventHandler += Fp_UpdateEventHandler;
            cci2.ShowDialog();
            cci2.txtNombre.Focus();
        }

        private void Fp_UpdateEventHandler(object sender, ccinventario2.UpdateEventArgs args)
        {
            CargarInventario("");
        }

        public void CargarInventario(string filtro)
        {
            dtgInventario.DataSource = _manejador.ObtenerInventario (filtro);
          
        }
     

        private void dtgInventario_Load(object sender, EventArgs e)
        {
            CargarInventario("");
           
        }

        private void Eliminar()
        {
                var categoria = dtgInventario.CurrentRow.Cells["idproducto"].Value.ToString();
                _manejador.EliminarInventario(categoria);
            
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CargarInventario("");
            Eliminar();
          
        }

        private void dtgInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarInventario("");
            ccinventario2 cci2 = new ccinventario2(this);
            cci2.banGuardar = "actualizar";
            cci2.txtNombre.Text = dtgInventario.CurrentRow.Cells["idproducto"].Value.ToString();
            cci2.txtDesc.Text = dtgInventario.CurrentRow.Cells["pdescripcion"].Value.ToString();
            cci2.txtCantidad.Text = dtgInventario.CurrentRow.Cells["pcantidad"].Value.ToString();
            cci2.txtPrecio.Text = dtgInventario.CurrentRow.Cells["pprecio"].Value.ToString();
            cci2.txtstatus.Text = dtgInventario.CurrentRow.Cells["pstatus"].Value.ToString();
            cci2.ShowDialog();
           
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarInventario(txtBuscar.Text);
        }
    }
}
