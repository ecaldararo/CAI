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
    
    public partial class FormModificar : Form
    {
        private Lata _lata;
        private Expendedora exp;
        public FormModificar(Form frm, Lata lata)
        {
            InitializeComponent();
            //exp = e;
            _lata = lata;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();

                Lata lata = _lata;
                lata.Codigo = txtCod.Text;
                lata.Nombre = txtNom.Text;
                lata.Cantidad = (int)numCan.Value;
                
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

        private void FormModificar_Load(object sender, EventArgs e)
        {
            txtCod.Text = _lata.Codigo;
            txtNom.Text = _lata.Nombre;
            numCan.Value = (int)_lata.Cantidad;
        }
    }
}
