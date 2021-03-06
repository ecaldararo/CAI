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

namespace SegundoParcial.Presentacion
{
    public partial class FormPF : Form
    {
        private Controller _operador;
        private Operador _op;
        TipoPlazoFijo _tipo;
        PlazoFijo _simulado;
        PlazoFijo _alta;
        public FormPF()
        {
            InitializeComponent();
            // operador es el controller de la capa de negocio
            _operador = new Controller();
            _op = new Operador();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTasaInteres.Enabled = false;
            txtInteresARecibir.Enabled = false;
            txtMontoFinal.Enabled = false;
            CargarTiposPF();
            _tipo = (TipoPlazoFijo)cmbTipoPlazoFijo.SelectedItem;
            //CargarTasa();
            CargarPF();
            
        }
        private void CargarPF()
        {
            _op._listaPlazosFijos = _operador.TraerTodos();

            lstPlazoFijo.DataSource = null;
            lstPlazoFijo.DataSource = _op._listaPlazosFijos;
        }
        private void CargarTiposPF()
        {
            cmbTipoPlazoFijo.DataSource = null;
            cmbTipoPlazoFijo.DataSource = _operador._tiposPF;
            
        }
        private void CargarTasa()
        {
            txtTasaInteres.Text = _operador._tiposPF.FirstOrDefault(x => x.Id == _tipo.Id).Tasa.ToString();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                _simulado = new PlazoFijo();
                _simulado.Tasa = Validaciones.ValidarDouble(txtTasaInteres.Text);
                _simulado.CapitalInicial = Validaciones.ValidarDouble(txtCapitalAInvertir.Text);
                _simulado.Dias = Validaciones.ValidarInt(txtDias.Text);
                txtInteresARecibir.Text = _simulado.Interes.ToString();
                txtMontoFinal.Text = _simulado.MontoFinal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtCapitalAInvertir.Text = "";
            txtDias.Text = "";
            txtInteresARecibir.Text = "";
            txtMontoFinal.Text = "";
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(_operador.Alta(_simulado));
                CargarPF();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTipoPlazoFijo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTasaInteres.Text = ((TipoPlazoFijo)cmbTipoPlazoFijo.SelectedValue).Tasa.ToString();
        }

        private void lstPlazoFijo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMontoTotal.Text = _op.MontoTotal.ToString("0.00");
            txtComisionTotal.Text = _op.Comision.ToString("0.00");
        }
    }
}
