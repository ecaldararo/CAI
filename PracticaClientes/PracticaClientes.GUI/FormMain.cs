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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            FormCuenta frm = new FormCuenta();
            frm.Owner = this;
            frm.Show();
            //this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente(this);
            frm.Owner = this;
            frm.Show();
            //this.Hide();
        }
    }
}
