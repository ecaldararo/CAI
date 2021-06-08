using LibreriaExpendedora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpendedoraForm
{
    public partial class FormListar : Form
    {
        private List<Lata> _latas;
        private Lata lata;
        public FormListar(List<Lata> latas)
        {
            InitializeComponent();
            _latas = latas;
            listBox1.DataSource = _latas;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lata = (Lata)listBox1.SelectedValue;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormModificar frm = new FormModificar(this, lata);
            frm.Owner = this;
            frm.Show();
            this.Hide();
            listBox1.DataSource = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Lata eliminar = _latas.FirstOrDefault(x => x.Equals(lata));

            if (eliminar != null)
                _latas.RemoveAll(x => x.Equals(lata));
                
            Recargar();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Recargar();
        }
        public void Recargar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _latas;
        }
    }
}
