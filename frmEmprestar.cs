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
    public partial class frmEmprestar : Form
    {
        public frmEmprestar()
        {
            InitializeComponent();
        }
        Emprestimo oEmprestimo = new Emprestimo();
        CCliente oCliente = new CCliente();
        CLivro oLivro = new CLivro();

        private void button1_Click(object sender, EventArgs e)
        {

            oLivro.strIdentificacao = txtConsultarCodigo.Text;
            oLivro.Consultar();
            if (oLivro.intCodigo != 0)
            {
                txtNomeLivro.Text = oLivro.strNome;
                txtValor.Text = oLivro.dcmValor.ToString();
                txtAutor.Text = oLivro.strAutor;
                int intExemplares = Convert.ToInt32(oLivro.strExemplares);
                if (intExemplares > 0)
                {
                    lblStatusLivro.Text = "DISPONIVEL";
                    lblStatusLivro.BackColor = Color.Green;
                }
                else
                {
                    lblStatusLivro.Text = "INDISPONIVEL";
                    lblStatusLivro.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Livro não cadastrado.", "Biblioteca");
                txtConsultarCodigo.Text = string.Empty;
            }
        }

        private void txtConsultarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            oCliente.strCPF = mskCPF.Text;
            oCliente.Consultar();
            if (oCliente.intCodigo != 0)
            {
                txtNomeCliente.Text = oCliente.strNome;
                Emprestimo emprestimo = new Emprestimo();
                emprestimo.strCPF = oCliente.strCPF;
                emprestimo.Consultar();
                if (emprestimo.strNumeroemprestimo != string.Empty)
                {

                }
                    if (oCliente.blnStatus)
                    {
                        lblStatusCliente.Text = "ATIVO";
                        lblStatusCliente.BackColor = Color.Green;
                    }
                    else
                    {
                        lblStatusCliente.Text = "INATIVO";
                        lblStatusCliente.BackColor = Color.Red;
                    }
            }
            else
            {
                MessageBox.Show("Cliente não cadastrado.", "Biblioteca");
                mskCPF.Text = string.Empty;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime DataEmprestimo = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime DataDevolucao = Convert.ToDateTime(dateTimePicker2.Text);

            if (DataDevolucao > DataEmprestimo)
            {
                TimeSpan date = DataDevolucao - DataEmprestimo;
                int intTotalDias = date.Days;
                lblDias.Text = intTotalDias.ToString() + " Dias";
            }
            else
            {
                lblDias.Text = string.Empty;
            }
        }

        private void frmEmprestar_Load(object sender, EventArgs e)
        {
            txtNumeroEmprestimo.Text = DateTime.Now.ToString("yyyyMMddhhmmssfff");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            string strErro = string.Empty;
            if (txtNomeLivro.Text == string.Empty)
            {
                strErro += "Nenhum livro selecionado. \n";
            }
            if (txtNomeCliente.Text == string.Empty)
            {
                strErro += "Nenhum cliente selecionado. \n";
            }
            if (lblDias.Text == string.Empty)
            {
                strErro += "Data de devolução menor que data do dia. \n";
            }
            if (strErro == string.Empty)
            {
                if (lblStatusLivro.Text == "DISPONIVEL")
                {
                    if (lblStatusCliente.Text == "ATIVO")
                    {
                        oEmprestimo.strDataEmprestimo = dateTimePicker1.Text;
                        oEmprestimo.strDataDevolucao = dateTimePicker2.Text;
                        oEmprestimo.strStatusEmprestimo = "Emprestado";
                        oEmprestimo.intCodigoLivro = oLivro.intCodigo;
                        oEmprestimo.intCodigoCliente = oCliente.intCodigo;
                        oEmprestimo.strNumeroemprestimo = txtNumeroEmprestimo.Text;
                        oEmprestimo.decValorEmprestimo = (decimal)0.00;
                        oEmprestimo.Gravar();
                        MessageBox.Show("Empréstimo efetuado com sucesso!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int intExemplares = Convert.ToInt32(oLivro.strExemplares) - 1;
                        oLivro.strIdentificacao = txtConsultarCodigo.Text;
                        oLivro.strExemplares = intExemplares.ToString();
                        oLivro.AlterarExemplar();
                        txtAutor.Text = string.Empty;
                        txtConsultarCodigo.Text = string.Empty;
                        mskCPF.Text = string.Empty;
                        txtNomeCliente.Text = string.Empty;
                        txtNomeLivro.Text = string.Empty;
                        txtNumeroEmprestimo.Text = string.Empty;
                        txtValor.Text = string.Empty;
                        lblDias.Text = string.Empty;
                        lblStatusCliente.Text = string.Empty;
                        lblStatusCliente.BackColor = Color.Gray;
                        lblStatusLivro.Text = string.Empty;
                        lblStatusLivro.BackColor = Color.Gray;
                    }
                    else
                    {
                        MessageBox.Show("Cliente inativo", "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Livro indisponivel", "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(strErro, "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
