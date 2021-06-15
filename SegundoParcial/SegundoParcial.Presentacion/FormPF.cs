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
        private AdmPrestamos _admPrestamos;
        private Operador _operador;
        TipoPlazoFijo _tipo;
        PlazoFijo _simulado;
        PlazoFijo _alta;
        public FormPF()
        {
            InitializeComponent();
            // operador es el controller de la capa de negocio
            _admPrestamos = new AdmPrestamos();
            _operador = new Operador();

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
            _tipo = (TipoPlazoFijo)cmbTipoPlazoFijo.SelectedValue;
            //CargarTasa();
            CargarPF();
            
        }
        private void CargarPF()
        {
            _operador._listaPlazosFijos = _admPrestamos.TraerTodos();
            

            foreach (PlazoFijo p in _operador._listaPlazosFijos)
            {
                if(p.Tipo >= 1 ) // me faltó incluir la validación al dar de alta con campos vacíos, y agregué un pf con tipo 0
                {
                    p.Tipo = _admPrestamos._tiposPF.FirstOrDefault(x => x.Id == p.Tipo).Id;
                    p.TipoPlazoFijo = _admPrestamos._tiposPF.FirstOrDefault(x => x.Id == p.Tipo);
                }
                
            }

            lstPlazoFijo.DataSource = null;
            lstPlazoFijo.DataSource = _operador._listaPlazosFijos;
        }
        private void CargarTiposPF()
        {
            cmbTipoPlazoFijo.DataSource = null;
            cmbTipoPlazoFijo.DataSource = _admPrestamos._tiposPF;
            
        }
        private void CargarTasa()
        {
            txtTasaInteres.Text = _admPrestamos._tiposPF.FirstOrDefault(x => x.Id == _tipo.Id).Tasa.ToString();
        }

        private void Validar()
        {
            if (txtTasaInteres.Text == "")
                throw new Exception("Faltan datos");
            if (txtCapitalAInvertir.Text == "")
                throw new Exception("Faltan datos");
            if (txtDias.Text == "")
                throw new Exception("Faltan datos");
            if (txtInteresARecibir.Text == "")
                throw new Exception("Faltan datos");
            if (txtMontoFinal.Text == "")
                throw new Exception("Faltan datos");
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                _simulado = new PlazoFijo();
                _simulado.Tasa = Validaciones.ValidarDouble(txtTasaInteres.Text);
                _simulado.CapitalInicial = Validaciones.ValidarDouble(txtCapitalAInvertir.Text);
                _simulado.Dias = Validaciones.ValidarInt(txtDias.Text);
                _simulado.TipoPlazoFijo = _tipo;
                txtInteresARecibir.Text = _simulado.Interes.ToString("0.00");
                txtMontoFinal.Text = _simulado.MontoFinal.ToString("#,##0");
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
                Validar();
                MessageBox.Show(_admPrestamos.Alta(_simulado));
                CargarPF();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTipoPlazoFijo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tipo = (TipoPlazoFijo)cmbTipoPlazoFijo.SelectedItem;
            txtTasaInteres.Text = _tipo.Tasa.ToString();
        }

        private void lstPlazoFijo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMontoTotal.Text = _operador.MontoTotal.ToString("#,##0.00");
            txtComisionTotal.Text = _operador.Comision.ToString("#,##0.00");
        }

        private void txtInteresARecibir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
