using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCUAppCalculadora
{
    public partial class Calculadora : Form
    {

        string Operacion = "";
        string lblValorPrevio = "";

        #region "Eventos Nativos"

        public Calculadora()
        {
            InitializeComponent();
            lblResultado.Text = "0";
        }

        private void btnParentesisIzquierdo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnParentecisDerecho_Click(object sender, EventArgs e)
        {

        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            Operacion = "%";
            lblValorPrevio = lblResultado.Text;
            lblResultado.Text = "0";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }


        private void btnCero_Click(object sender, EventArgs e)
        {
            AgregarNumero("0");
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            AgregarNumero("1");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            AgregarNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            AgregarNumero("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            AgregarNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            AgregarNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            AgregarNumero("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            AgregarNumero("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            AgregarNumero("8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AgregarNumero("9");
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            AgregarNumero(".");
        }


        private void btnDividir_Click(object sender, EventArgs e)
        {
            Operacion = "/";
            lblValorPrevio = lblResultado.Text;
            lblResultado.Text = "0";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Operacion = "*";
            lblValorPrevio = lblResultado.Text;
            lblResultado.Text = "0";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Operacion = "-";
            lblValorPrevio = lblResultado.Text;
            lblResultado.Text = "0";
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Operacion = "+";
            lblValorPrevio = lblResultado.Text;
            lblResultado.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        #endregion

        #region "Metodos Privados"

        private void AgregarNumero(string num)
        {
            lblResultado.Text = lblResultado.Text + num;
        }

        private void Calcular()
        {
            switch (Operacion)
            {
                case "+":
                    lblResultado.Text = Convert.ToString(double.Parse(lblValorPrevio) + double.Parse(lblResultado.Text));
                    break;
                case "-":
                    lblResultado.Text = Convert.ToString(double.Parse(lblValorPrevio) - double.Parse(lblResultado.Text));
                    break;
                case "*":
                    lblResultado.Text = Convert.ToString(double.Parse(lblValorPrevio) * double.Parse(lblResultado.Text));
                    break;
                case "/":
                    lblResultado.Text = Convert.ToString(double.Parse(lblValorPrevio) / double.Parse(lblResultado.Text));
                    break;
                case "%":
                    lblResultado.Text = Convert.ToString(double.Parse(lblValorPrevio) % double.Parse(lblResultado.Text));
                    break;
                default:
                    lblResultado.Text = "";
                    break;
            }
        }

        #endregion

        private void lblResultado_TextChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Text == "") label.Text = "0";
        }
    }
}
