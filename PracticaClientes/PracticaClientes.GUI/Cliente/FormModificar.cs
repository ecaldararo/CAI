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
using Negocio;

namespace PracticaClientes.GUI
{
    public partial class FormModificar : Form
    {
        private Form _frm;
        private Cliente _cliente;
        private AdmCliente _admCliente;
        public FormModificar(FormCliente frm, Cliente cli)
        {
            InitializeComponent();
            _frm = frm;
            _cliente = cli;
            _admCliente = new AdmCliente();
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            txtDni.Text = (_cliente.Dni).ToString(); ;
            txtNombre.Text = _cliente.Nombre;
            txtApellido.Text = _cliente.Apellido;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
                _cliente.Dni = Validaciones.ValidarInt(txtDni.Text);
                _cliente.Nombre = txtNombre.Text;
                _cliente.Apellido = txtApellido.Text;


                MessageBox.Show(_admCliente.Actualizar(_cliente));

                _frm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Validar()
        {
            if (txtNombre.Text == "")
                throw new Exception("Nombre vacío");
            if (txtApellido.Text == "")
                throw new Exception("Apellido vacío");
            
        }
    }
}
