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
    public partial class cventas : Form
    {
        private ManejadorYeez _manejador;
        private Inventario _inventario;
        // public string banGuardar;
        public cventas()
        {
            InitializeComponent();
            _manejador = new ManejadorYeez();
            _inventario = new Inventario();
            CargarInventario("");
        }

        public void CargarInventario(string filtro)
        {
            dtgVentas.DataSource = _manejador.ObtenerInventario(filtro);
        }
                               
        

        private void dtgVentas_Load(object sender, EventArgs e)
        {
            CargarInventario("");

        }

        private void txtBuscarN_TextChanged(object sender, EventArgs e)
        {
            CargarInventario(txtBuscarN.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarInventario("");
            ccinventario2 cci2 = new ccinventario2(this);
            cci2.banGuardar = "actualizar";
            cci2.txtNombre.Text = dtgVentas.CurrentRow.Cells["idproducto"].Value.ToString();
            cci2.txtDesc.Text = dtgVentas.CurrentRow.Cells["pdescripcion"].Value.ToString();
            cci2.txtCantidad.Text = dtgVentas.CurrentRow.Cells["pcantidad"].Value.ToString();
            cci2.txtPrecio.Text = dtgVentas.CurrentRow.Cells["pprecio"].Value.ToString();
            cci2.txtstatus.Text = dtgVentas.CurrentRow.Cells["pstatus"].Value.ToString();
            cci2.ShowDialog();

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            double Cantidad;
            double Precio;
            double Total2 = 0;
            int stock;


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dtgVender);
            fila.Cells[0].Value = dtgVentas.CurrentRow.Cells[0].Value.ToString();
            fila.Cells[1].Value = dtgVentas.CurrentRow.Cells[1].Value.ToString();
            fila.Cells[2].Value = txtCantidad.Text;
            fila.Cells[3].Value = dtgVentas.CurrentRow.Cells[3].Value.ToString();

            dtgVender.Rows.Add(fila);
            txtCantidad.Visible = true;
            txtCantidad.Text = "";

            foreach(DataGridViewRow row in dtgVender.Rows)
            {
                Cantidad = Convert.ToDouble(row.Cells[2].Value) ;
                Precio = Convert.ToDouble(row.Cells[3].Value);
                Total2 += Cantidad * Precio;
                txtTotal.Text = Total2.ToString();
                              
            }
                                 
          
        }
                              

        private void btnTicket_Click(object sender, EventArgs e)
        {


           MessageBox.Show("Fecha: "+ dtpFecha + "\nProductos: " + dtgVender+"\nTotal de Venta: " +txtTotal );
            // MessageBox.Show("Tu anterior saldo: " + s + "\nRetiro: " + p + "\nTu saldo actual:" + sal);
        }

      
    }
}
