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
    public partial class frmCCliente : Form
    {
        public frmCCliente()
        {
            InitializeComponent();
        }
        bool blnLoad = false;
        CCliente oCliente = new CCliente();

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivo = new OpenFileDialog();
            arquivo.ShowDialog();
            picImagemCliente.ImageLocation = arquivo.FileName;
        }

        private void btnLimparCamposCliente_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtNumero.Text = string.Empty;
            cboCidade.Text = string.Empty;
            cboEstado.Text = string.Empty;
            mskCelular.Text = string.Empty;
            mskCPF.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            mskCEP.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            picImagemCliente.Image = BibliotecaProjeto.Properties.Resources.usuario;
            oCliente = new CCliente();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarCliente_Load(object sender, EventArgs e)
        {
            CarregarEstados();
            cboEstado.Text = string.Empty;
            blnLoad = true;
        }
        private void CarregarEstados()
        {
            try
            {
                cboEstado.DataSource = Global.ConsultarEstado();
                cboEstado.DisplayMember = "EST_ESTADO";
                cboEstado.ValueMember = "EST_CODIGO";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro-->" + ex.Message, "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blnLoad)
            {
                cboCidade.DataSource = Global.ConsultarCidade(Convert.ToInt32(cboEstado.SelectedValue));
                cboCidade.DisplayMember = "CID_CIDADE";
                cboCidade.ValueMember = "CID_CODIGO";
                cboCidade.Text = string.Empty;
            }
        }

        private void btnGravarDados_Click(object sender, EventArgs e)
        {
            oCliente = new CCliente();
            string strMsgErro = ValidarPreenchimento();

            if (strMsgErro != string.Empty)
            {
                MessageBox.Show(strMsgErro, "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                oCliente.strCPF = mskCPF.Text;
                oCliente.Consultar();
                if (oCliente.intCodigo == 0)
                {
                    PreencherClasse();
                    oCliente.Gravar();
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimparCamposCliente.PerformClick();
                }
                else
                {
                    MessageBox.Show("Usuário já cadastrado!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void PreencherClasse()
        {
            oCliente.strCPF = mskCPF.Text;
            oCliente.strNome = txtNome.Text;
            oCliente.strEmail = txtEmail.Text;
            oCliente.strEndereco = txtEndereco.Text;
            oCliente.strBairro = txtBairro.Text;
            oCliente.strComplemento = txtComplemento.Text;
            oCliente.strNumero = txtNumero.Text;
            oCliente.strCelular = mskCelular.Text;
            oCliente.strCEP = mskCEP.Text;
            oCliente.blnStatus = true;
            oCliente.strTelefone = mskTelefone.Text;
            oCliente.intCodigoCidade = Convert.ToInt32(cboCidade.SelectedValue);
            MemoryStream oMemoryStream = new MemoryStream();
            picImagemCliente.Image.Save(oMemoryStream, ImageFormat.Jpeg);
            oCliente.bytImagem = new byte[oMemoryStream.Length];
            oMemoryStream.Position = 0;
            oMemoryStream.Read(oCliente.bytImagem, 0, oCliente.bytImagem.Length);
        }
        private string ValidarPreenchimento()
        {
            string strMsg = string.Empty;
            if (mskCPF.Text == "   ,   ,   -")
            {
                strMsg = "CPF em branco.\n";
            }
            if (txtNome.Text == string.Empty)
            {
                strMsg += "Nome em branco.\n";
            }
            if (txtEndereco.Text == string.Empty)
            {
                strMsg += "Endereço em branco.\n";
            }
            if (txtNumero.Text == string.Empty)
            {
                strMsg += "Número em branco.\n";
            }
            if (txtBairro.Text == string.Empty)
            {
                strMsg += "Bairro em branco.\n";
            }
            if (mskCEP.Text == "     -")
            {
                strMsg += "CEP em branco.\n";
            }
            if (cboCidade.Text == string.Empty)
            {
                strMsg += "Cidade em branco.\n";
            }
            if (cboEstado.Text == string.Empty)
            {
                strMsg += "Estado em branco.\n";
            }
            return strMsg;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
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
