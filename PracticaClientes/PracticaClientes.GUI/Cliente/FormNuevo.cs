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
    public partial class FormNuevo : Form
    {
        private FormCliente _frm;
        private Cliente _cliente;
        private AdmCliente _admCliente;
        public FormNuevo(FormCliente frm, Cliente cli)
        {
            InitializeComponent();
            _frm = frm;
            _cliente = cli;
            _admCliente = new AdmCliente();
        }

        private void FormNuevo_Load(object sender, EventArgs e)
        {
            //txtDni.Enabled = false;
            //txtNombre.ReadOnly = true;
            //txtDni.Text = "28323955";
            //txtNombre.Text = "Eugenio";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
                int dni = Validaciones.ValidarInt(txtDni.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;

                Cliente cli = new Cliente(dni, nombre, apellido);

                MessageBox.Show(_admCliente.Agregar(cli));

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
