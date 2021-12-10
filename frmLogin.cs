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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == Global.strLogin && txtSenha.Text == Global.strSenha)
            {
                MessageBox.Show("Bem vindo ADMINISTRADOR", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                try
                {
                    string strMsg = string.Empty;
                    CFuncionario oFuncionario = new CFuncionario();
                    oFuncionario.strLogin = txtLogin.Text;
                    oFuncionario.Consultar();
                    if (oFuncionario.intCodigo == 0)
                    {
                        strMsg = "Usuário inválido.";
                    }
                    else if (oFuncionario.strSenha != txtSenha.Text)
                    {
                        strMsg = "Senha inválida.";
                    }
                    else if (!oFuncionario.blnAtivo)
                    {
                        strMsg = "Usuário Inativo.";
                    }
                    if (strMsg != string.Empty)
                    {
                        MessageBox.Show(strMsg, "Biblioteca", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        txtLogin.Focus();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Bem vindo {0}", oFuncionario.strNome + "."),
                            "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        Global.intCodigoUsuario = oFuncionario.intCodigo;
                        Global.strNomeUsuario = oFuncionario.strNome;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro-->" + ex.Message, "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }
    }
}
