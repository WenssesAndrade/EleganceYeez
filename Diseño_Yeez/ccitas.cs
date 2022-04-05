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
    public partial class ccitas : Form
    {
        private ManejadorYeez _ManejadorYeez;
        private Citas _citas;
        public string banderaGuardar;

        public ccitas()
        {
            InitializeComponent();

            _citas = new Citas();
            _ManejadorYeez = new ManejadorYeez();
            CargarCitas("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            ccitas2 cc2 = new ccitas2();
            cc2.banderaGuardar = "guardar";
            cc2.UpdateEventHandler += Fp_UpdateEventHandler;
            cc2.ShowDialog();
            cc2.txtNombre.Focus();

          
             CargarCitas("");
        }

        private void Fp_UpdateEventHandler(object sender, ccitas2.UpdateEventArgs args)
        {
            CargarCitas("");
        }

        public void CargarCitas(string filtro)
        {
            dtgDatos.DataSource = _ManejadorYeez.ObtenerCitas(filtro);
            dtgDatos.AutoResizeColumns();
        }

  
        private void ccitas_Load(object sender, EventArgs e)
        {
           CargarCitas(txtBuscar.Text);
        }

        private void EliminarC()
        {
            {
                var citas = dtgDatos.CurrentRow.Cells["idcliente"].Value.ToString();
                _ManejadorYeez.EliminarCitas(citas);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarC();
            CargarCitas("");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ccitas2 cc2 = new ccitas2(_citas);
            cc2.banderaGuardar = "actualizar";
            

            _citas.IdCliente = dtgDatos.CurrentRow.Cells["idcliente"].Value.ToString();
            _citas.Hora = dtgDatos.CurrentRow.Cells["hora"].Value.ToString();
            _citas.Fecha = dtgDatos.CurrentRow.Cells["fecha"].Value.ToString();
            _citas.Servicio = dtgDatos.CurrentRow.Cells["servicio"].Value.ToString();
            _citas.Estatus = dtgDatos.CurrentRow.Cells["estatus"].Value.ToString();
          
            cc2.ShowDialog();
            CargarCitas("");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarCitas(txtBuscar.Text);
        }

    }
}
