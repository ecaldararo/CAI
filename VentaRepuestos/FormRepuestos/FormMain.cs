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

namespace FormRepuestos
{
    public partial class FormMain : Form
    {
        private Comercio comercio1;
        private Categoria auto;
        private Categoria moto;
        private List<Categoria> _categorias;
        public FormMain()
        {
            InitializeComponent();

            comercio1 = new Comercio("VentaRepuestos", "Ambrosetti 991");
            
            auto = new Categoria("Auto");
            moto = new Categoria("Moto");
            _categorias = new List<Categoria>();
            _categorias.Add(auto);
            _categorias.Add(moto);

            comercio1.AgregarRepuestoALista(new Repuesto("Volante", 3000, auto, 50));
            comercio1.AgregarRepuestoALista(new Repuesto("Paragolpe", 7500, moto, 10));
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FormListar frm = new FormListar(this,comercio1,_categorias);
            frm.Owner = this;
            frm.Show();
            this.Hide();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormNuevo frm = new FormNuevo(this, comercio1,_categorias);
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }
    }
}
