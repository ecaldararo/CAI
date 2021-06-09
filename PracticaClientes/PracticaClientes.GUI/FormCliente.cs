using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace PracticaClientes.GUI
{
    public partial class FormCliente : Form
    {
        private Cliente _cliente;
        private AdmCliente _admCliente;
        public FormCliente(FormMain frm)
        {
            InitializeComponent();
            _cliente = new Cliente();
            _admCliente = new AdmCliente();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            listClientes.DataSource = null;
            listClientes.DataSource = _admCliente.TraerTodos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listClientes.DataSource = null;
            listClientes.DataSource = _admCliente.TraerTodos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormNuevo frm = new FormNuevo(this,_cliente);
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
