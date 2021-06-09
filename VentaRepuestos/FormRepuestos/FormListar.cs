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
    public partial class FormListar : Form
    {
        FormMain _main;
        NegocioController _comercio;
        Repuesto _repuestoSeleccionado;
        List<Categoria> _categorias;
        public FormListar(FormMain frm, NegocioController comercio, List<Categoria> categorias)
        {
            InitializeComponent();
            _main = frm;
            _comercio = comercio;
            _categorias = categorias;
            listBox1.DataSource = null;
            listBox1.DataSource = _comercio.Listar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            _main.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _repuestoSeleccionado = (Repuesto)listBox1.SelectedValue;
        }

        public void Recargar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _comercio.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(_comercio.Listar().Exists(x => x.Equals(_repuestoSeleccionado)))
                _comercio.QuitarRepuesto(_repuestoSeleccionado.Codigo);
            Recargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificar frm = new FormModificar(this, _comercio, _categorias, _repuestoSeleccionado);
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recargar();
        }
    }
}
