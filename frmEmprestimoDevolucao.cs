using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;


namespace BibliotecaProjeto
{
    public partial class frmEmprestimoDevolucao : Form
    {
        public frmEmprestimoDevolucao()
        {
            InitializeComponent();
        }
        bool blnLoad = false;
        Emprestimo oEmprestimo = new Emprestimo();

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {           
            if(grdLivros.SelectedCells[3].Value.ToString() == "Emprestado")
            {
                frmDevolucao ofrmDevolucao = new frmDevolucao();
                ofrmDevolucao.txtCodigo.Text = grdLivros.SelectedCells[0].Value.ToString();
                ofrmDevolucao.txtLivro.Text = grdLivros.SelectedCells[9].Value.ToString();
                ofrmDevolucao.ShowDialog();
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Devolução já efetuada!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void frmEmprestimoDevolucao_Load(object sender, EventArgs e)
        {
            blnLoad = true;
            CarregarGrid();
            cboExibir.Items.Add("Todos".ToString());
            cboExibir.Items.Add("Devolvidos".ToString());
            cboExibir.Items.Add("Emprestados".ToString());
        }
        private void CarregarGrid()
        {
            try
            {
                grdLivros.DataSource = oEmprestimo.Consultar();

                grdLivros.Columns[5].Visible = false;
                grdLivros.Columns[8].Visible = false;
                grdLivros.Columns[10].Visible = false;
                grdLivros.Columns[12].Visible = false;
                grdLivros.Columns[13].Visible = false;

                grdLivros.Columns[0].HeaderText = "Nº Empréstimo";
                grdLivros.Columns[1].HeaderText = "Data Empréstimo";
                grdLivros.Columns[2].HeaderText = "Data Devolução";
                grdLivros.Columns[3].HeaderText = "Status";
                grdLivros.Columns[4].HeaderText = "Obsrevação";
                grdLivros.Columns[6].HeaderText = "CPF";
                grdLivros.Columns[7].HeaderText = "Cliente";
                grdLivros.Columns[9].HeaderText = "Cód.Livro";
                grdLivros.Columns[11].HeaderText = "Livro";
                grdLivros.Columns[14].HeaderText = "Valor Pago";


                grdLivros.Columns[0].Width = 110;
                grdLivros.Columns[1].Width = 170;
                grdLivros.Columns[2].Width = 170;
                grdLivros.Columns[3].Width = 65;
                grdLivros.Columns[4].Width = 217;
                grdLivros.Columns[6].Width = 85;
                grdLivros.Columns[7].Width = 200;
                grdLivros.Columns[9].Width = 80;
                grdLivros.Columns[11].Width = 250;
                grdLivros.Columns[14].Width = 100;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                oEmprestimo = new Emprestimo();
                if (txtConsultarEmprestimo.Text != string.Empty)
                {
                    oEmprestimo.strNumeroemprestimo = txtConsultarEmprestimo.Text;
                }
                else if (txtConsultarCodigo.Text != string.Empty)
                {
                    oEmprestimo.strIdentificacao = txtConsultarCodigo.Text;
                }
                else if (txtConsultarCPF.Text != string.Empty)
                {
                    oEmprestimo.strCPF = txtConsultarCPF.Text;
                }
                CarregarGrid();
                txtConsultarCPF.Text = string.Empty;
                txtConsultarCodigo.Text = string.Empty;
                txtConsultarEmprestimo.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void cboExibir_SelectedIndexChanged(object sender, EventArgs e)
        {
            oEmprestimo = new Emprestimo();
            if(cboExibir.SelectedItem.ToString() == "Todos")
            {
                CarregarGrid();
            }
            else if(cboExibir.SelectedItem.ToString() == "Devolvidos")
            {
                oEmprestimo.strStatusEmprestimo = "Devolvido";
                CarregarGrid();
            }
            else if(cboExibir.SelectedItem.ToString() == "Emprestados")
            {
                oEmprestimo.strStatusEmprestimo = "Emprestado";
                CarregarGrid();
            }

        }
    }
}
