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
        private List<Lata> latas;
        public FormMain()
        {
            InitializeComponent();
            Expendedora exp = new Expendedora();
            exp.EncenderMaquina();
            exp._latas.Add(new Lata("1", "Coca", 20));
            exp._latas.Add(new Lata("2", "Sprite", 20));
            exp._latas.Add(new Lata("3", "Fanta", 20));
            exp._latas.Add(new Lata("4", "Fernet", 20));
            exp._latas.Add(new Lata("5", "Ron", 20));
            latas = exp._latas;
        }

        private void btnListarLatas_Click(object sender, EventArgs e)
        {
            FormLista frm = new FormLista(latas);
            frm.Owner = this;
            this.Hide();
            frm.Show();
            
        }
    }
}
