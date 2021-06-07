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
    public partial class FormLista : Form
    {
        public FormLista(List<Lata> latas)
        {
            InitializeComponent();
            listBox1.DataSource = latas;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
