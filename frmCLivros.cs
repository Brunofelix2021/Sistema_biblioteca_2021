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
    public partial class frmCLivros : Form
    {
        public frmCLivros()
        {
            InitializeComponent();
        }
        CLivro oCLivro = new CLivro();
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivo = new OpenFileDialog();
            arquivo.ShowDialog();
            picImagemlivro.ImageLocation = arquivo.FileName;
        }

        private void btnLimparCamposCliente_Click(object sender, EventArgs e)
        {
            txtAno.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtEditora.Text = string.Empty;
            txtExemplares.Text = string.Empty;
            txtIdentificacao.Text = string.Empty;
            txtNomeLivro.Text = string.Empty;
            cboGenero.Text = string.Empty;
            picImagemlivro.Image = BibliotecaProjeto.Properties.Resources.usuario;
            txtValor.Text = string.Empty;
            oCLivro = new CLivro();
        }

        private void frmCLivros_Load(object sender, EventArgs e)
        {
            CarregarGenero();
        }
        private void CarregarGenero()
        {
            try
            {
                cboGenero.DataSource = Global.ConsultarGenero();
                cboGenero.DisplayMember = "GEN_GENERO";
                cboGenero.ValueMember = "GEN_CODIGO";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravarDados_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsgErro = ValidarPreenchimento();

                if (strMsgErro != string.Empty)
                {
                    MessageBox.Show(strMsgErro, "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    oCLivro.strIdentificacao = txtIdentificacao.Text;
                    oCLivro.Consultar();
                    if (oCLivro.intCodigo == 0)
                    {
                        PreencherClasse();
                        oCLivro.Gravar();
                        MessageBox.Show("Cadastro efetuada com sucesso!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparCampos.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Livro já Cadastrado!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        oCLivro.intCodigo = 0;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro-->" + ex.Message, "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherClasse()
        {
            oCLivro.strNome = txtNomeLivro.Text;
            oCLivro.strAno = txtAno.Text;
            oCLivro.strIdentificacao = txtIdentificacao.Text;
            oCLivro.strAutor = txtAutor.Text;
            oCLivro.dcmValor = Convert.ToDecimal(txtValor.Text);
            oCLivro.strExemplares = txtExemplares.Text;
            oCLivro.strEditora = txtEditora.Text;
            oCLivro.intCodigoGen = Convert.ToInt32(cboGenero.SelectedValue);
            MemoryStream oMemoryStream = new MemoryStream();
            picImagemlivro.Image.Save(oMemoryStream, ImageFormat.Jpeg);
            oCLivro.bytImagem = new byte[oMemoryStream.Length];
            oMemoryStream.Position = 0;
            oMemoryStream.Read(oCLivro.bytImagem, 0, oCLivro.bytImagem.Length);
        }
        private string ValidarPreenchimento()
        {
            string strMsg = string.Empty;
            if (txtNomeLivro.Text == string.Empty)
            {
                strMsg += "Nome do Livro em branco.\n";
            }
            if (txtAutor.Text == string.Empty)
            {
                strMsg += "Autor em branco.\n";
            }
            if (txtAno.Text == string.Empty)
            {
                strMsg += "Ano em branco.\n";
            }
            if (cboGenero.Text == string.Empty)
            {
                strMsg += "Gênero em branco.\n";
            }
            if (txtEditora.Text == string.Empty)
            {
                strMsg += "Editora em branco.\n";
            }
            if (txtIdentificacao.Text == string.Empty)
            {
                strMsg += "Código em branco.\n";
            }
            if (txtExemplares.Text == string.Empty)
            {
                strMsg += "Quantiade de Exemplares em branco.\n";
            }
            if (txtValor.Text == string.Empty)
            {
                strMsg += "Valor em branco.\n";
            }
            return strMsg;
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtExemplares_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtIdentificacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
