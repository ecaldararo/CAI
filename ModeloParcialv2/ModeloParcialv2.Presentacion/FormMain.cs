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

namespace ModeloParcialv2.Presentacion
{
    public partial class FormMain : Form
    {
        AdmPrestamo _admPrestamo;
        Prestamo _alta;
        public FormMain()
        {
            InitializeComponent();
            _admPrestamo = new AdmPrestamo();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _alta = new Prestamo();
                string rdo = _admPrestamo.IngresarPrestamo(_alta);
                MessageBox.Show(rdo);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _admPrestamo.GetPrestamos();
        }
    }
}
