using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProjeto
{
    public partial class frmDevolucao : Form
    {
        public frmDevolucao()
        {
            InitializeComponent();
        }
        Emprestimo oEmprestimo = new Emprestimo();
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                txtObs.Enabled = false;
                oEmprestimo = new Emprestimo();
                oEmprestimo.strNumeroemprestimo = txtCodigo.Text;
                oEmprestimo.Consultar();
                DateTime dtDevolucao = Convert.ToDateTime(oEmprestimo.strDataDevolucao);
                DateTime dtHoje = Convert.ToDateTime(DateTime.Now.ToString());
                if(dtDevolucao >= dtHoje)
                {
                    label2.Text = "Está dentro do prazo de devolução!";
                    label2.ForeColor = Color.Green;
                    txtValor.Text = "0,00";
                    txtObs.Text = string.Empty;
                }
                else
                {
                    TimeSpan date = dtHoje - dtDevolucao;
                    decimal decTotalDias = date.Days;
                    label2.Text = "Houve atraso de " + decTotalDias + " dias na devolução!";
                    label2.ForeColor = Color.Red;
                    decimal decMulta = Global.decMulta + (decTotalDias * Global.decMora);
                    txtValor.Text = Convert.ToString(decMulta);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txtObs.Enabled = true;
                label2.Text = "Abaixo informe o estado em que o livro se encontra!";
                label2.ForeColor = Color.Black;
                oEmprestimo = new Emprestimo();
                oEmprestimo.strNumeroemprestimo = txtCodigo.Text;
                oEmprestimo.Consultar();
                txtValor.Text = oEmprestimo.strValorLivro;
            }
        }

        private void btnLimparCamposCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar devolução do exemplar?", "Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if(radioButton1.Checked == true)
                {
                    CLivro oLivro = new CLivro();
                    oLivro.strIdentificacao = txtLivro.Text;
                    oLivro.Consultar();
                    int intExemplares = Convert.ToInt32(oLivro.strExemplares) + 1;
                    oLivro.strExemplares = intExemplares.ToString();
                    oLivro.AlterarExemplar();

                    oEmprestimo.decValorEmprestimo = Convert.ToDecimal(txtValor.Text);
                    oEmprestimo.strNumeroemprestimo = txtCodigo.Text;
                    oEmprestimo.strObservacao = txtObs.Text;
                    oEmprestimo.strStatusEmprestimo = "Devolvido";
                    oEmprestimo.Alterar();
                    this.Close();
                }
                else
                {
                    oEmprestimo.decValorEmprestimo = Convert.ToDecimal(txtValor.Text);
                    oEmprestimo.strNumeroemprestimo = txtCodigo.Text;
                    oEmprestimo.strObservacao = txtObs.Text;
                    oEmprestimo.strStatusEmprestimo = "Devolvido";
                    oEmprestimo.Alterar();
                    this.Close();
                }
            }
        }

    }
}
