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
    public partial class FormModificar : Form
    {
        private Form _main;
        private Comercio _comercio;
        private List<Categoria> _categorias;
        private Repuesto _repuesto;
        
        public FormModificar(Form frm, Comercio comercio, List<Categoria> categorias, Repuesto repuesto)
        {
            InitializeComponent();
            _main = frm;
            _comercio = comercio;
            _categorias = categorias;
            _repuesto = repuesto;
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            _main.Show();
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _repuesto.Nombre = txtNombre.Text;
            //_repuesto.Precio = (int)txtPrecio.Text;
            _repuesto.Categoria = (Categoria)cmbCat.SelectedValue;
            _repuesto.Stock = (int)numStock.Value;
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            cmbCat.DataSource = _categorias;
            txtNombre.Text = _repuesto.Nombre;
            txtPrecio.Text = _repuesto.Precio.ToString();
            cmbCat.SelectedItem = _repuesto.Categoria;
            numStock.Value = (int)_repuesto.Stock;
        }
    }
}
