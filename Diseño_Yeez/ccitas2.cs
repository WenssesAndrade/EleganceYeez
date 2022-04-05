using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;
using Entidades;
namespace Diseño_Yeez
{
    public partial class ccitas2 : Form
    {
        private ManejadorYeez _Manejador;
        private Citas _citas;
        public string banderaGuardar;


        public ccitas2(Citas cita)
        {
            InitializeComponent();
            _Manejador = new ManejadorYeez();
            _citas = new Citas();
                      
        }


        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }


        public ccitas2()
        {
            InitializeComponent();
            _Manejador = new ManejadorYeez();
            _citas = new Citas();
            banderaGuardar = "guardar";
        }

       

        private void btnCalcelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected void Agregard()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void GuardarCitas()
        {
            _citas.Fecha = dateTimePicker1.Value.Year
       + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day;
            _citas.Hora = txtHora.Text;
            _citas.IdCliente = txtNombre.Text;
            _citas.Servicio = txtServicio.Text;
            _citas.Estatus = txtStatus.Text;

          var valida = _Manejador.ValidarCitas(_citas);

              if (valida.Item1)
              {
                  _Manejador.GuardarCitas(_citas);
              }
              else
              {
                  MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
        }

        private void ActualizarCitas()
        {
            _Manejador.ActualizarCitas(new Citas
            {
                IdCliente = txtNombre.Text,
                Hora = txtHora.Text,
                Fecha = txtHora.Text,
                Servicio = txtServicio.Text,
                Estatus = txtStatus.Text
            }); 
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar == "guardar")
            {
                GuardarCitas();
                Close();
            }
            else
            {
                ActualizarCitas();
                Close();
            }
        }

        private void btnCalcelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

