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
    public partial class ModifyForm : Form
    {
        private Cliente seleccionado;
        private Form formPrevio;
        private List<Cliente> listaClientes;
        public ModifyForm(Cliente sel, Form previo, List<Cliente> clientes)
        {
            InitializeComponent();
            seleccionado = sel;
            formPrevio = previo;
            listaClientes = clientes;
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            cmbEC.DataSource = EstadoCivilController.GetLista();

            txtApellido.Text = seleccionado.Apellido;
            txtNombre.Text = seleccionado.Nombre;
            cmbEC.Text = seleccionado.EstadoCivil;
            chkBoxActivo.Checked = seleccionado.Activo;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPrevio.Show();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();

                // Creo un nuevo cliente y borro el viejo
                //Cliente act = new Cliente(txtNombre.Text, txtApellido.Text, chkBoxActivo.Checked, cmbEC.Text);
                //listaClientes.Remove(seleccionado);
                //listaClientes.Add(act);


                // Actualizo el cliente sin borrar el viejo
                //foreach (Cliente i in listaClientes)
                //{
                //    if (i.Equals(seleccionado))
                //    {
                //        if (txtApellido.Text != seleccionado.Apellido)
                //            i.Apellido = txtApellido.Text;
                //        if (txtNombre.Text != seleccionado.Nombre)
                //            i.Nombre = txtNombre.Text;
                //        if (cmbEC.Text != seleccionado.EstadoCivil)
                //            i.EstadoCivil = cmbEC.Text;
                //        if (chkBoxActivo.Checked != seleccionado.Activo)
                //            i.Activo = chkBoxActivo.Checked;
                //    }
                //}

                // Sin el foreach
                //listaClientes.Find(x => x.Equals(seleccionado)).Nombre = txtNombre.Text;
                //listaClientes.Find(x => x.Equals(seleccionado)).Apellido = txtApellido.Text;
                //listaClientes.Find(x => x.Equals(seleccionado)).EstadoCivil = cmbEC.Text;
                //listaClientes.Find(x => x.Equals(seleccionado)).Activo = chkBoxActivo.Checked;

                // Busco una sola vez el objeto de la lista
                Cliente obj = listaClientes.FirstOrDefault(x => x.Equals(seleccionado));
                obj.Nombre = txtNombre.Text;
                obj.Apellido = txtApellido.Text;
                obj.EstadoCivil = cmbEC.Text;
                obj.Activo = chkBoxActivo.Checked;

                MessageBox.Show("Cliente Guardado");
                this.Close();
                formPrevio.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
