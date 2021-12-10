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
    public partial class frmConsultarCliente : Form
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
        }
        bool blnLoad = false;
        CCliente oCCliente = new CCliente();

        private void btnLimparCamposCliente_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtBairro.Text = string.Empty;            
            txtNumero.Text = string.Empty;
            cboCidade.Text = string.Empty;
            cboEstado.Text = string.Empty;
            mskCelular.Text = string.Empty;
            mskCEP.Text = string.Empty;
            mskConsultarCPF.Text = string.Empty;
            mskCPF.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            picImagemCliente.Image = BibliotecaProjeto.Properties.Resources.usuario;
            oCCliente = new CCliente();
            oCCliente.Consultar();
            CarregarGrid();
            CarregarEstados();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivo = new OpenFileDialog();
            arquivo.ShowDialog();
            picImagemCliente.ImageLocation = arquivo.FileName;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarEstados();
                blnLoad = true;
                mskConsultarCPF.Focus();
                CarregarGrid();
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
                grdClientes.DataSource = oCCliente.Consultar();

                grdClientes.Columns[1].Visible = false;
                grdClientes.Columns[3].Visible = false;
                grdClientes.Columns[4].Visible = false;
                grdClientes.Columns[5].Visible = false;
                grdClientes.Columns[6].Visible = false;
                grdClientes.Columns[7].Visible = false;
                grdClientes.Columns[8].Visible = false;
                grdClientes.Columns[9].Visible = false;
                grdClientes.Columns[10].Visible = false;
                grdClientes.Columns[11].Visible = false;
                grdClientes.Columns[12].Visible = false;
                grdClientes.Columns[13].Visible = false;
                grdClientes.Columns[14].Visible = false;

                grdClientes.Columns[0].HeaderText = "CPF";
                grdClientes.Columns[2].HeaderText = "NOME";

                grdClientes.Columns[0].Width = 100;
                grdClientes.Columns[2].Width = 300;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                oCCliente.strCPF = grdClientes.SelectedCells[0].Value.ToString();
                oCCliente.Consultar();
                PreencherForm();
        }
        private void PreencherForm()
        {
                txtNome.Text = oCCliente.strNome;
                txtBairro.Text = oCCliente.strBairro;
                txtComplemento.Text = oCCliente.strComplemento;
                txtEmail.Text = oCCliente.strEmail;
                txtEndereco.Text = oCCliente.strEndereco;
                txtNumero.Text = oCCliente.strNumero;
                mskCelular.Text = oCCliente.strCelular;
                mskCEP.Text = oCCliente.strCEP;
                mskCPF.Text = oCCliente.strCPF;
                mskTelefone.Text = oCCliente.strTelefone;
                cboEstado.SelectedValue = oCCliente.intCodigoEstado;
                cboCidade.SelectedValue = oCCliente.intCodigoCidade;
            MemoryStream oMemoryStream = new MemoryStream(oCCliente.bytImagem);
            picImagemCliente.Image = Image.FromStream(oMemoryStream);
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

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                    oCCliente.strCPF = mskConsultarCPF.Text;
                    oCCliente.Consultar();
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
                    MessageBox.Show(strMsgErro, "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    oCCliente.strCPF = mskCPF.Text;
                    oCCliente.Consultar();
                    if (oCCliente.intCodigo != 0)
                    {
                        PreencherClasse();
                        oCCliente.Alterar();
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
            return strMsg;
        }
        private void PreencherClasse()
        {
            oCCliente.strCPF = mskCPF.Text;
            oCCliente.strNome = txtNome.Text;
            oCCliente.strEmail = txtEmail.Text;
            oCCliente.strEndereco = txtEndereco.Text;
            oCCliente.strBairro = txtBairro.Text;
            oCCliente.strComplemento = txtComplemento.Text;
            oCCliente.strNumero = txtNumero.Text;
            oCCliente.strCelular = mskCelular.Text;
            oCCliente.strCEP = mskCEP.Text;
            oCCliente.strTelefone = mskTelefone.Text;
            oCCliente.intCodigoCidade = Convert.ToInt32(cboCidade.SelectedValue);
            MemoryStream oMemoryStream = new MemoryStream();
            picImagemCliente.Image.Save(oMemoryStream, ImageFormat.Jpeg);
            oCCliente.bytImagem = new byte[oMemoryStream.Length];
            oMemoryStream.Position = 0;
            oMemoryStream.Read(oCCliente.bytImagem, 0, oCCliente.bytImagem.Length);
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
