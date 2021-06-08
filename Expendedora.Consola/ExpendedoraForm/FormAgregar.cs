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
    
    public partial class FormAgregar : Form
    {
        private List<Lata> _latas;
        private Expendedora exp;
        public FormAgregar(Form frm, List<Lata> l, Expendedora e)
        {
            InitializeComponent();
            exp = e;
            _latas = l;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
                exp._latas.Add(new Lata(txtCod.Text, txtNom.Text, (int)numCan.Value));
                this.Owner.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
        private void Validar()
        {
            if (txtCod.Text == "")
                throw new Exception("Código vacío"); 
            if (txtNom.Text == "")
                throw new Exception("Nombre vacío");
            if ((int)numCan.Value == 0)
                throw new Exception("Sin cantidad");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
