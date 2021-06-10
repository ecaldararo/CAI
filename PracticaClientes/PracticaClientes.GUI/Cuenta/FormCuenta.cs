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

namespace PracticaClientes.GUI
{
    public partial class FormCuenta : Form
    {
        AdmCuenta _admCuenta;
        AdmCliente _admCliente;
        List<Cuenta> _listaCuentas;
        List<Cliente> _listaClientes;
        public FormCuenta()
        {
            InitializeComponent();
            _admCuenta = new AdmCuenta();
            _admCliente = new AdmCliente();

            // esto iría en la capa de negocios?
            _listaCuentas = _admCuenta.TraerTodos(); 
            _listaClientes = _admCliente.TraerTodos();
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void FormCuenta_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = _listaClientes;
        }

        private void Recargar()
        {
            _listaClientes = _admCliente.TraerTodos();
            cmbCliente.DataSource = _listaClientes;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cuenta cuenta = ((Cliente)cmbCliente.SelectedValue).Cuenta;
                if (cuenta != null)
                {
                    txtNroCuenta.Enabled = false;
                    txtNroCuenta.Text = cuenta.NroCuenta.ToString();

                    txtDescripcion.Enabled = false;
                    txtDescripcion.Text = cuenta.Descripcion.ToString();

                    txtSaldo.Enabled = true;
                    txtSaldo.Text = cuenta.Saldo.ToString();
                } else
                {
                    Limpiar();
                    
                    txtSaldo.Enabled = false;
                    txtNroCuenta.Enabled = false;
                    txtDescripcion.Enabled = true;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Limpiar()
        {
            txtNroCuenta.Text = "";
            txtDescripcion.Text = "";
            txtSaldo.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta cuentaSeleccionada = ((Cliente)cmbCliente.SelectedValue).Cuenta;
                if (cuentaSeleccionada == null)
                {
                    Cuenta cuenta = new Cuenta();
                    cuenta.Descripcion = txtDescripcion.Text;
                    cuenta.IdCliente = ((Cliente)cmbCliente.SelectedValue).Id;
                    _admCuenta.Agregar(cuenta);
                    Recargar();
                }
                else
                {
                    cuentaSeleccionada.Saldo = Validaciones.ValidarDouble(txtSaldo.Text);
                    _admCuenta.Modificar(cuentaSeleccionada);
                    Recargar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
