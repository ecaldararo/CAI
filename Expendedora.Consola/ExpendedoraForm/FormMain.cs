using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaExpendedora;

namespace ExpendedoraForm
{
    public partial class FormMain : Form
    {
        private List<Lata> _latas;
        private Expendedora exp;
        public FormMain()
        {
            InitializeComponent();
            exp = new Expendedora();
            exp.EncenderMaquina();
            exp._latas.Add(new Lata("1", "Coca", 20,200,69,"Sin sabor"));
            exp._latas.Add(new Lata("2", "Sprite", 20, 200, 59, "Sin sabor"));
            exp._latas.Add(new Lata("3", "Fanta", 20, 200, 49, "Sin sabor"));
            exp._latas.Add(new Lata("4", "Fernet", 20, 200, 149, "Sin sabor"));
            exp._latas.Add(new Lata("5", "Ron", 20, 200, 249, "Sin sabor"));
            _latas = exp._latas;
        }

        private void btnListarLatas_Click(object sender, EventArgs e)
        {
            FormListar frm = new FormListar(_latas);
            frm.Owner = this;
            this.Hide();
            frm.Show();
            
        }

        private void btnAddLata_Click(object sender, EventArgs e)
        {
            FormAgregar frm = new FormAgregar(this, _latas, exp);
            frm.Owner = this;
            this.Hide();
            frm.Show();
        }
    }
}
