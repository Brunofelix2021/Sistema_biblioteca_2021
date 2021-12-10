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
    public partial class frmConsultarLivro : Form
    {
        public frmConsultarLivro()
        {
            InitializeComponent();
        }
        bool blnLoad = false;
        CLivro oCLivro = new CLivro();

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtAno.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtConsultarAutor.Text = string.Empty;
            txtConsultarCodigo.Text = string.Empty;
            txtConsultarNome.Text = string.Empty;
            txtEditora.Text = string.Empty;
            txtExemplares.Text = string.Empty;
            txtIdentificacao.Text = string.Empty;
            txtNomeLivro.Text = string.Empty;
            txtValor.Text = string.Empty;
            cboGenero.Text = string.Empty;
            picImagemLivro.Image = BibliotecaProjeto.Properties.Resources.usuario;
            oCLivro = new CLivro();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivo = new OpenFileDialog();
            arquivo.ShowDialog();
            picImagemLivro.ImageLocation = arquivo.FileName;
        }

        private void frmConsultarLivro_Load(object sender, EventArgs e)
        {
            try
            {
                blnLoad = true;
                CarregarGrid();
                CarregarGenero();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void CarregarGrid()
        {
            try
            {
                grdLivros.DataSource = oCLivro.Consultar();

                grdLivros.Columns[0].Visible = false;
                grdLivros.Columns[7].Visible = false;
                grdLivros.Columns[9].Visible = false;

                grdLivros.Columns[1].HeaderText = "NOME";
                grdLivros.Columns[2].HeaderText = "ANO";
                grdLivros.Columns[3].HeaderText = "EXEMPLARES";
                grdLivros.Columns[4].HeaderText = "CÓDIGO";
                grdLivros.Columns[5].HeaderText = "AUTOR";
                grdLivros.Columns[6].HeaderText = "EDITORA";
                grdLivros.Columns[8].HeaderText = "VALOR";
                grdLivros.Columns[10].HeaderText = "GÊNERO";

                grdLivros.Columns[1].Width = 217;
                grdLivros.Columns[2].Width = 50;
                grdLivros.Columns[3].Width = 40;
                grdLivros.Columns[4].Width = 100;
                grdLivros.Columns[5].Width = 200;
                grdLivros.Columns[6].Width = 200;
                grdLivros.Columns[8].Width = 80;
                grdLivros.Columns[10].Width = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oCLivro.strIdentificacao = grdLivros.SelectedCells[4].Value.ToString();
            oCLivro.Consultar();
            PreencherForm();
        }
        private void PreencherForm()
        {
            txtNomeLivro.Text = oCLivro.strNome;
            txtAutor.Text = oCLivro.strAutor;
            txtAno.Text = oCLivro.strAno;
            txtEditora.Text = oCLivro.strEditora;
            txtExemplares.Text = oCLivro.strExemplares;
            txtIdentificacao.Text = oCLivro.strIdentificacao;
            txtValor.Text = oCLivro.dcmValor.ToString();
            MemoryStream oMemoryStream = new MemoryStream(oCLivro.bytImagem);
            picImagemLivro.Image = Image.FromStream(oMemoryStream);   
            cboGenero.SelectedValue = oCLivro.intCodigoGen;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                oCLivro = new CLivro();
                if (txtConsultarAutor.Text != string.Empty)
                {
                    oCLivro.strAutor = txtConsultarAutor.Text;
                }
                else if (txtConsultarCodigo.Text != string.Empty)
                {
                    oCLivro.strIdentificacao = txtConsultarCodigo.Text;
                }
                else if (txtConsultarNome.Text != string.Empty)
                {
                    oCLivro.strNome = txtConsultarNome.Text;
                }
                oCLivro.Consultar();
                CarregarGrid();
                txtConsultarAutor.Text = string.Empty;
                txtConsultarCodigo.Text = string.Empty;
                txtConsultarNome.Text = string.Empty;

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
                    if (oCLivro.intCodigo != 0)
                    {
                        PreencherClasse();
                        oCLivro.Alterar();
                        MessageBox.Show("Alteração efetuada com sucesso!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparCampos.PerformClick();
                        CarregarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Usuário já Cadastrado!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro-->" + ex.Message, "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (txtExemplares.Text == string.Empty)
            {
                strMsg += "Quantiade de exemplares em branco.\n";
            }
            if (txtValor.Text == string.Empty)
            {
                strMsg += "Valor de multa em branco.\n";
            }
            if (txtAno.Text == string.Empty)
            {
                strMsg += "Ano em branco.\n";
            }
            if (txtEditora.Text == string.Empty)
            {
                strMsg += "Editora em branco.\n";
            }
            if (cboGenero.Text == string.Empty)
            {
                strMsg += "Genero em branco.\n";
            }
            return strMsg;
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
            picImagemLivro.Image.Save(oMemoryStream, ImageFormat.Jpeg);
            oCLivro.bytImagem = new byte[oMemoryStream.Length];
            oMemoryStream.Position = 0;
            oMemoryStream.Read(oCLivro.bytImagem, 0, oCLivro.bytImagem.Length);
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

        private void txtIdentificacao_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
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