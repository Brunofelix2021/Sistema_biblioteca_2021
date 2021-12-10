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
    public partial class frmCFuncionario : Form
    {
        public frmCFuncionario()
        {
            InitializeComponent();
        }
        bool blnLoad = false;
        CFuncionario oFuncionario = new CFuncionario();

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivo = new OpenFileDialog();
            arquivo.ShowDialog();
            pctImagem.ImageLocation = arquivo.FileName;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimparCamposCliente_Click(object sender, EventArgs e)
        {
            mskCEP.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtNumero.Text = string.Empty;
            cboCargo.Text = string.Empty;
            cboCidade.Text = string.Empty;
            cboEstado.Text = string.Empty;
            mskCelular.Text = string.Empty;
            mskCPF.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            txtConfirmacao.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            rdbAtivo.Checked = true;
            pctImagem.Image = BibliotecaProjeto.Properties.Resources.usuario;
            oFuncionario = new CFuncionario();
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            CarregarEstados();
            CarregarCargo();
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
        private void CarregarCargo()
        {
            try
            {
                cboCargo.DataSource = Global.ConsultarCargo();
                cboCargo.DisplayMember = "CAR_CARGO";
                cboCargo.ValueMember = "CAR_CODIGO";
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
            }
        }

        private void btnGravarDados_Click(object sender, EventArgs e)
        {
            oFuncionario = new CFuncionario();
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
                    if (txtSenha.Text == txtConfirmacao.Text)
                    {
                        oFuncionario.strCPF = mskCPF.Text;
                        oFuncionario.strLogin = txtLogin.Text;
                        oFuncionario.Consultar();
                        if (oFuncionario.intCodigo == 0)
                        {
                            PreencherClasse();
                            oFuncionario.Gravar();
                            MessageBox.Show("Cadastro efetuado com sucesso!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLimparCamposCliente.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Usuário já cadastrado!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha e confirmação diferentes!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            oFuncionario.strCPF = mskCPF.Text;
            oFuncionario.strNome = txtNome.Text;
            oFuncionario.strEmail = txtEmail.Text;
            oFuncionario.strEndereco = txtEndereco.Text;
            oFuncionario.strBairro = txtBairro.Text;
            oFuncionario.strComplemento = txtComplemento.Text;
            oFuncionario.strNumero = txtNumero.Text;
            oFuncionario.strCelular = mskCelular.Text;
            oFuncionario.strCEP = mskCEP.Text;
            oFuncionario.strTelefone = mskTelefone.Text;
            oFuncionario.strLogin = txtLogin.Text;
            oFuncionario.strSenha = txtSenha.Text;
            oFuncionario.blnAtivo = rdbAtivo.Checked;
            oFuncionario.intCodigoCargo = Convert.ToInt32(cboCargo.SelectedValue);
            oFuncionario.intCodigoCidade = Convert.ToInt32(cboCidade.SelectedValue);
            MemoryStream oMemoryStream = new MemoryStream();
            pctImagem.Image.Save(oMemoryStream, ImageFormat.Jpeg);
            oFuncionario.bytImagem = new byte[oMemoryStream.Length];
            oMemoryStream.Position = 0;
            oMemoryStream.Read(oFuncionario.bytImagem, 0, oFuncionario.bytImagem.Length);
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
            if (cboCargo.Text == string.Empty)
            {
                strMsg += "Cargo em branco.\n";
            }
            return strMsg;
        }

        private void cboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(blnLoad)
            {
                bool blnAtivo = Convert.ToBoolean(Global.ConsultarCargo(Convert.ToInt32(cboCargo.SelectedValue)).Rows[0]["CAR_ATIVO"]);
                gpoLogin.Enabled = blnAtivo;
            }
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
