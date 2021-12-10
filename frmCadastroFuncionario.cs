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
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivo = new OpenFileDialog();
            arquivo.ShowDialog();
            picImagemFuncionario.ImageLocation = arquivo.FileName;
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
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            CarregarEstados();
            CarregarCargo();
            cboCargo.Text = string.Empty;
            cboEstado.Text = string.Empty;
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
    }
}
