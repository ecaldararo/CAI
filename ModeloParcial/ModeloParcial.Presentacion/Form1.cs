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

namespace ModeloParcial.Presentacion
{
    public partial class Form1 : Form
    {
        private List<TipoPrestamo> _listaTipo;
        private Prestamo _prestamoSimulado;
        private Prestamo _prestamoAlta;
        private TipoPrestamo _tipoPrestamo;

        private AdmPrestamo _admPrestamo;
        private AdmTipoPrestamo _admTipo;
        public Form1()
        {
            InitializeComponent();
            _admTipo = new AdmTipoPrestamo();
            _admPrestamo = new AdmPrestamo();

            _listaTipo = new List<TipoPrestamo>();
            _prestamoSimulado = new Prestamo();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarListaTipo();
            txtLinea.Enabled = false;
            txtTNA.Enabled = false;
            CargarListaPrestamos();
            btnAlta.Enabled = false;
        }

        private void CargarListaTipo()
        {
            listTiposPrestamo.DataSource = null;
            listTiposPrestamo.DataSource = _admTipo.TraerTodos();
        }
        private void CargarListaPrestamos()
        {
            listPrestamos.DataSource = null;
            listPrestamos.DataSource = _admPrestamo.TraerTodos();
        }

        private void listTiposPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _tipoPrestamo = (TipoPrestamo)listTiposPrestamo.SelectedValue;
                txtLinea.Text = _tipoPrestamo.Linea;
                txtTNA.Text = _tipoPrestamo.TNA.ToString();
                txtMonto.Text = "";
                txtPlazo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            
            try
            {
                ValidarTipo();
                _prestamoSimulado.Linea = _tipoPrestamo.Linea;
                _prestamoSimulado.TNA = _tipoPrestamo.TNA;
                _prestamoSimulado.IdTipo = _tipoPrestamo.Id;
                _prestamoSimulado.Monto = Validaciones.ValidarDouble(txtMonto.Text);
                _prestamoSimulado.Plazo = Validaciones.ValidarInt(txtPlazo.Text);
                if (_prestamoSimulado.Plazo != 0)
                {
                    double capital = (_prestamoSimulado.Monto / (Double)_prestamoSimulado.Plazo);
                    double TNA = _prestamoSimulado.TNA;
                    txtCuotaCapital.Text = capital.ToString("0.00");
                    txtCuotaInteres.Text = (capital * TNA / 12 / 100).ToString("0.00");
                    txtCuotaTotal.Text = (capital + (capital * TNA / 12 / 100)).ToString("0.00");
                    btnAlta.Enabled = true;
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void ValidarTipo()
        {
            if (txtLinea.Text == "")
                throw new Exception("Faltan datos");
            if(txtTNA.Text == "")
                throw new Exception("Faltan datos");
            if (txtMonto.Text == "")
                throw new Exception("Faltan datos");
            if (txtPlazo.Text == "")
                throw new Exception("Faltan datos");
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarTipo();

                _prestamoAlta = new Prestamo();
                _prestamoAlta.TNA = _prestamoSimulado.TNA;
                _prestamoAlta.Monto = _prestamoSimulado.Monto;
                _prestamoAlta.Plazo = _prestamoSimulado.Plazo;
                _prestamoAlta.Linea = _prestamoSimulado.Linea;
                _prestamoAlta.IdTipo = _prestamoSimulado.IdTipo;
                _prestamoAlta.CuotaTotal = _prestamoSimulado.CuotaTotal;

                string rdo = _admPrestamo.Alta(_prestamoAlta);
                MessageBox.Show(rdo);
                CargarListaPrestamos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void listPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
