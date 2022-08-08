using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria
{
    public partial class frmPastelaria : Form
    {

        double valor = 0;

        public frmPastelaria()
        {
            InitializeComponent();
        }

        private void ckbCarne_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbCarne.Checked == true){
                txtPcarne.Visible = true;
                lblQuantidade.Visible = true;
            }
            else{
                txtPcarne.Visible = false;
                txtPcarne.Text = "0";
            }

        }

        private void ckbCarneQ_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCarneQ.Checked == true)
            {
                txtPcarneq.Visible = true;
                lblQuantidade.Visible = true;
            }
            else
            {
                txtPcarneq.Visible = false;
                txtPcarneq.Text = "0";
            }
        }

        private void ckbFrango_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFrango.Checked == true)
            {
                txtPfrango.Visible = true;
                lblQuantidade.Visible = true;
            }
            else
            {
                txtPfrango.Visible = false;
                txtPfrango.Text = "0";
            }
        }

        private void ckbFrangoC_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFrangoC.Checked == true)
            {
                txtPfrangoc.Visible = true;
                lblQuantidade.Visible = true;
            }
            else
            {
                txtPfrangoc.Visible = false;
                txtPfrangoc.Text = "0";
            }
        }

        private void ckbPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPizza.Checked == true)
            {
                txtPpizza.Visible = true;
                lblQuantidade.Visible = true;
            }
            else
            {
                txtPpizza.Visible = false;
                txtPpizza.Text = "0";
            }
        }

        private void ckbCalabresa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCalabresa.Checked == true)
            {
                txtPcalabresa.Visible = true;
                lblQuantidade.Visible = true;
            }
            else
            {
                txtPcalabresa.Visible = false;
                txtPcalabresa.Text = "0";
            }
        }

        private void ckbCalabresaQ_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCalabresaQ.Checked == true)
            {
                txtPcalabresaq.Visible = true;
                lblQuantidade.Visible = true;
            }
            else
            {
                txtPcalabresaq.Visible = false;
                txtPcalabresaq.Text = "0";
            }
        }

        private void ckbPalmito_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPalmito.Checked == true)
            {
                txtPpalmito.Visible = true;
                lblQuantidade.Visible = true;
            }
            else
            {
                txtPpalmito.Visible = false;
                txtPpalmito.Text = "0";
            }
        }

        private void ckbCarneSeca_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCarneSeca.Checked == true)
            {
                txtPcarneseca.Visible = true;
                lblQuantidade.Visible = true;
            }
            else
            {
                txtPcarneseca.Visible = false;
                txtPcarne.Text = "0";
            }
        }

        private void ckbModa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbModa.Checked == true)
            {
                txtPmoda.Visible = true;
                lblQuantidade.Visible = true;
            }
            else
            {
                txtPmoda.Visible = false;
                txtPcarne.Text = "0";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            valor = 0;
            double valorparcial = 0;

            if(rdbRefri.Checked == true)
            {
                valor += 10;
            }
            if (rdbCerveja.Checked == true)
            {
                valor += 12;
            }
            if (rdbSuco.Checked == true)
            {
                valor += 11;
            }
            if (rdbCana.Checked == true)
            {
                valor += 7;
            }
            if (rdbAgua.Checked == true)
            {
                valor += 5;
            }

            if (ckbCarne.Checked == true)
            {
                valor += Convert.ToDouble(txtPcarne.Text) * 5;
            }
            if (ckbCarneQ.Checked == true)
            {
                valor += Convert.ToDouble(txtPcarneq.Text) * 7;
            }
            if (ckbFrango.Checked == true)
            {
                valor += Convert.ToDouble(txtPfrango.Text) * 5;
            }
            if (ckbFrangoC.Checked == true)
            {
                valor += Convert.ToDouble(txtPfrangoc.Text) * 7;
            }
            if (ckbPizza.Checked == true)
            {
                valor += Convert.ToDouble(txtPpizza.Text) * 6.5;
            }
            if (ckbCalabresa.Checked == true)
            {
                valor += Convert.ToDouble(txtPcalabresa.Text) * 6;
            }
            if (ckbCalabresaQ.Checked == true)
            {
                valor += Convert.ToDouble(txtPcalabresaq.Text) * 8;
            }
            if (ckbPalmito.Checked == true)
            {
                valor += Convert.ToDouble(txtPpalmito.Text) * 7;
            }
            if (ckbCarneSeca.Checked == true)
            {
                valor += Convert.ToDouble(txtPcarneseca.Text) * 5;
            }
            if (ckbModa.Checked == true)
            {
                valor += Convert.ToDouble(txtPmoda.Text) * 10;
            }

            if (cbxPagamento.Text == "A Vista / Dinheiro")
            {
                valor -= valor * 0.05;
            }
            if (cbxPagamento.Text == "Cartão de Crédito")
            {
                valor += valor * 0.05;
            }
            if (cbxPagamento.Text == "PIX")
            {
                valor += valor * 0.02;
            }

            if (rdbMesa.Checked == true)
            {
                valorparcial = valor * 0.1;
                valor = valor + valorparcial;
                txtServico.Text = "R$" + Convert.ToString(valorparcial);
                txtEntrega.Text = "0";
            }
            if (rdbDelivery.Checked == true)
            {
                valorparcial = valor * 0.05;
                valor = valor + valorparcial;
                txtEntrega.Text = "R$" + Convert.ToString(valorparcial);
                txtServico.Text = "0";
            }

            txtTotal.Text = "R$" + Convert.ToString(valor);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rdbNenhum.Checked = true;
            ckbCarne.Checked = false;
            ckbCarneQ.Checked = false;
            ckbFrango.Checked = false;
            ckbFrangoC.Checked = false;
            ckbPizza.Checked = false;
            ckbCalabresa.Checked = false;
            ckbCalabresaQ.Checked = false;
            ckbPalmito.Checked = false;
            ckbCarneSeca.Checked = false;
            ckbModa.Checked = false;
            cbxPagamento.Text = "";
            rdbMesa.Checked = false;
            rdbDelivery.Checked = false;
            txtServico.Text = "0";
            txtEntrega.Text = "0";
            txtTotal.Text = "0";
            txtPago.Text = "0";
            txtTroco.Text = "0";
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            if(txtPago.Text == "0" || txtPago.Text == "")
            {
                btnPagar.Enabled = false;
            }
            else
            {
                btnPagar.Enabled = true;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

            if (txtPago.Text == "" || Convert.ToDouble(txtPago.Text) < valor)
            {
                MessageBox.Show("Valor Inválido ou Insuficiente" , "Erro", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if (Convert.ToDouble(txtPago.Text) >= valor) { 
            txtTroco.Text = "R$" + (Convert.ToDouble(txtPago.Text) - valor);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
