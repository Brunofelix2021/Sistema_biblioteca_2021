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
    public partial class frmConsultarFuncionario : Form
    {
        public frmConsultarFuncionario()
        {
            InitializeComponent();
        }
        bool blnLoad = false;
        CFuncionario oCFuncionario = new CFuncionario();
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
            picImagemFuncionario.Image = BibliotecaProjeto.Properties.Resources.usuario;
            oCFuncionario = new CFuncionario();
            oCFuncionario.Consultar();
            CarregarGrid();
            CarregarEstados();
            CarregarCargo();
        }

        private void frmConsultarFuncionario_Load(object sender, EventArgs e)
        {
            CarregarEstados();
            CarregarCargo();
            blnLoad = true;
            mskConsultarCPF.Focus();
            CarregarGrid();
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

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivo = new OpenFileDialog();
            arquivo.ShowDialog();
            picImagemFuncionario.ImageLocation = arquivo.FileName;
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
        private void CarregarGrid()
        {
            try
            {
                grdFuncionarios.DataSource = oCFuncionario.Consultar();

                grdFuncionarios.Columns[1].Visible = false;
                grdFuncionarios.Columns[3].Visible = false;
                grdFuncionarios.Columns[4].Visible = false;
                grdFuncionarios.Columns[5].Visible = false;
                grdFuncionarios.Columns[6].Visible = false;
                grdFuncionarios.Columns[7].Visible = false;
                grdFuncionarios.Columns[8].Visible = false;
                grdFuncionarios.Columns[9].Visible = false;
                grdFuncionarios.Columns[10].Visible = false;
                grdFuncionarios.Columns[11].Visible = false;
                grdFuncionarios.Columns[12].Visible = false;
                grdFuncionarios.Columns[14].Visible = false;
                grdFuncionarios.Columns[15].Visible = false;
                grdFuncionarios.Columns[16].Visible = false;
                grdFuncionarios.Columns[17].Visible = false;

                grdFuncionarios.Columns[0].HeaderText = "CPF";
                grdFuncionarios.Columns[2].HeaderText = "NOME";
                grdFuncionarios.Columns[13].HeaderText = "LOGIN";

                grdFuncionarios.Columns[0].Width = 100;
                grdFuncionarios.Columns[2].Width = 200;
                grdFuncionarios.Columns[13].Width = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "ERP Senac",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oCFuncionario.strCPF = grdFuncionarios.SelectedCells[0].Value.ToString();
            oCFuncionario.Consultar();
            PreencherForm();
        }
        private void PreencherForm()
        {
            txtNome.Text = oCFuncionario.strNome;
            txtBairro.Text = oCFuncionario.strBairro;
            txtComplemento.Text = oCFuncionario.strComplemento;
            txtEmail.Text = oCFuncionario.strEmail;
            txtEndereco.Text = oCFuncionario.strEndereco;
            txtNumero.Text = oCFuncionario.strNumero;
            mskCelular.Text = oCFuncionario.strCelular;
            mskCEP.Text = oCFuncionario.strCEP;
            mskCPF.Text = oCFuncionario.strCPF;
            mskTelefone.Text = oCFuncionario.strTelefone;
            cboEstado.SelectedValue = oCFuncionario.intCodigoEstado;
            cboCidade.SelectedValue = oCFuncionario.intCodigoCidade;
            cboCargo.SelectedValue = oCFuncionario.intCodigoCargo;
            txtLogin.Text = oCFuncionario.strLogin;
            txtSenha.Text = oCFuncionario.strSenha;
            txtConfirmacao.Text = oCFuncionario.strSenha;
            rdbAtivo.Checked = oCFuncionario.blnAtivo;
            rdbInativo.Checked = !oCFuncionario.blnAtivo;
            MemoryStream oMemoryStream = new MemoryStream(oCFuncionario.bytImagem);
            picImagemFuncionario.Image = Image.FromStream(oMemoryStream);
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

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                    oCFuncionario.strCPF = mskConsultarCPF.Text;
                    oCFuncionario.Consultar();
                    CarregarGrid();
                mskConsultarCPF.Text = string.Empty;
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
                    MessageBox.Show(strMsgErro, "ERP Senac",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    oCFuncionario.strCPF = mskCPF.Text;
                    oCFuncionario.Consultar();
                    if (oCFuncionario.intCodigo != 0)
                    {
                        PreencherClasse();
                        oCFuncionario.Alterar();
                        MessageBox.Show("Alteração efetuada com sucesso!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparCamposCliente.PerformClick();
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
            if (txtSenha.Text != txtConfirmacao.Text)
            {
                strMsg += "Senha e Confirmção diferentes.\n";
            }
            return strMsg;
        }
        private void PreencherClasse()
        {
            oCFuncionario.strCPF = mskCPF.Text;
            oCFuncionario.strNome = txtNome.Text;
            oCFuncionario.strEmail = txtEmail.Text;
            oCFuncionario.strEndereco = txtEndereco.Text;
            oCFuncionario.strBairro = txtBairro.Text;
            oCFuncionario.strComplemento = txtComplemento.Text;
            oCFuncionario.strNumero = txtNumero.Text;
            oCFuncionario.strCelular = mskCelular.Text;
            oCFuncionario.strCEP = mskCEP.Text;
            oCFuncionario.strTelefone = mskTelefone.Text;
            oCFuncionario.strLogin = txtLogin.Text;
            oCFuncionario.strSenha = txtSenha.Text;
            oCFuncionario.blnAtivo = rdbAtivo.Checked;
            oCFuncionario.intCodigoCidade = Convert.ToInt32(cboCidade.SelectedValue);
            MemoryStream oMemoryStream = new MemoryStream();
            picImagemFuncionario.Image.Save(oMemoryStream, ImageFormat.Jpeg);
            oCFuncionario.bytImagem = new byte[oMemoryStream.Length];
            oMemoryStream.Position = 0;
            oMemoryStream.Read(oCFuncionario.bytImagem, 0, oCFuncionario.bytImagem.Length);
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
