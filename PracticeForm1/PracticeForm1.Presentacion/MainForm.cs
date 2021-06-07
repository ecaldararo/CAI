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

namespace PracticeForm1.Presentacion
{
    public partial class MainForm : Form
    {
        //private List<Empresa> empresas;

        private ListForm frm2;

        private List<Cliente> listaClientes;

        private Empresa panaderia;

        private Cliente sel;
        public MainForm()
        {
            InitializeComponent();
            
            Empresa panaderia = new Empresa(1, "San Marcos", "Acoyte y Díaz Velez");
            //Empresa parrilla = new Empresa(1, "Lo de Velez", "Díaz Velez y Acoyte");

            //empresas.Add(panaderia);
            //empresas.Add(parrilla);

            panaderia.listClientes.Add(new Cliente("Rosa", "Lane",true,"Casado"));
            panaderia.listClientes.Add(new Cliente("Cielo", "Eastwood", true, "Casado"));
            panaderia.listClientes.Add(new Cliente("Rio", "Bethoveen", true, "Soltero"));
            
            listaClientes = EmpresaController.GetLista(panaderia);

            Cargar();

            /*lstClientes.DataSource = null;
            lstClientes.DataSource = listaClientes;*/



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
                listaClientes.Add(new Cliente(txtNombre.Text, txtApellido.Text, chkBoxActivo.Checked,cmbEC.Text));
                MessageBox.Show("Cliente agregado");
                Limpiar();
                Recargar();
                txtNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
        }
        public void Validar()
        {
            if (cmbEC.Text == "Seleccione")
                throw new Exception("Estado Civil no seleccionado");
            if (txtNombre.Text == string.Empty)
                throw new Exception("Nombre Vacío");
            if (txtApellido.Text == string.Empty)
                throw new Exception("Apellido Vacío");
        }
        public void Recargar()
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = listaClientes;
            
        }
        public void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lstClientes.DataSource = null;
        }
        public void Cargar()
        {
            lstClientes.DataSource = listaClientes;

            cmbEC.DataSource = EstadoCivilController.GetLista();
            cmbEC.DisplayMember = "Descripcion";
            cmbEC.ValueMember = "Codigo";
            cmbEC.SelectedIndex = 0;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm2 = new ListForm(this,listaClientes);
            //frm2.Owner = this;
            lstClientes.DataSource = null;
            frm2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            sel = (Cliente)lstClientes.SelectedValue;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyForm mod = new ModifyForm(sel, this, listaClientes);
            this.Hide();
            lstClientes.DataSource = null;
            mod.Show();
        }
    }
}
