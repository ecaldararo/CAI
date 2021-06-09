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
        public FormNuevo(FormCliente frm, Cliente cli)
        {
            InitializeComponent();
            _frm = frm;
            _cliente = cli;
        }

        private void FormNuevo_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
        }
    }
}
