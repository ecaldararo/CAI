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

namespace FormRepuestos
{
    public partial class FormNuevo : Form
    {
        private FormMain _main;
        private NegocioController _comercio;
        private List<Categoria> _categorias;
        public FormNuevo(FormMain frm, NegocioController comercio, List<Categoria> categorias)
        {
            InitializeComponent();
            _main = frm;
            _comercio = comercio;
            _categorias = categorias;
            cmbCat.DataSource = _categorias;
        }
        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            _main.Show();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Repuesto rep = new Repuesto(txtNombre.Text, 100, (Categoria)cmbCat.SelectedValue, (int)numStock.Value);
            _comercio.Listar().Add(rep);
            MessageBox.Show("Producto agregado");
            _main.Show();
            this.Close();

        }
    }
}
