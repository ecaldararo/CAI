using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeForm1.Presentacion
{
    public partial class ListForm : Form
    {
        private List<Cliente> _clientes;
        private Form _previo;
        private Cliente seleccionado;
        public ListForm(Form previo, List<Cliente> clientes)
        {
            InitializeComponent();
            _clientes = clientes;
            _previo = previo;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void CargarLista()
        {
            lstCli.DataSource = null;
            lstCli.DataSource = _clientes;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _previo.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(_clientes.Exists(x => x.Equals(seleccionado)))
                _clientes.RemoveAll(x => x.Equals(seleccionado));
            lstCli.DataSource = null;
            lstCli.DataSource = _clientes;

        }

        private void lstCli_SelectedValueChanged(object sender, EventArgs e)
        {
            seleccionado = (Cliente)lstCli.SelectedValue;
        }
    }
}
