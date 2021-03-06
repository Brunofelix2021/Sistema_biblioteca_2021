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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        bool blnLoad = false;

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
            mskCEP.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            mskCEP.Text = string.Empty;
            txtComplemento.Text = string.Empty;
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
            }
        }
    }
}
