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
    public partial class lblUsuario : Form
    {
        public lblUsuario()
        {
            InitializeComponent();
        }

        private void funcionárioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCFuncionario ofrmCadastroFuncionario = new frmCFuncionario();
            AbrirForm(ofrmCadastroFuncionario);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja sair?", "Bilbioteca", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCCliente ofrmCadastrarCliente = new frmCCliente();
            AbrirForm(ofrmCadastrarCliente);
        }
        private void AbrirForm(Form pForm)
        {
            bool blnExiste = false;
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.Name == pForm.Name)
                {
                    blnExiste = true;
                    break;
                }
            }
            if (!blnExiste)
            {
                pForm.MdiParent = this;
                pForm.Show();
            }
        }

        private void tmrData_Tick(object sender, EventArgs e)
        {
            
        }

        private void lblUsuario_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToShortDateString();
            lblFuncionario.Text = "Usuário: " + Global.strNomeUsuario;
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarCliente ofrmConsultarCliente = new frmConsultarCliente();
            AbrirForm(ofrmConsultarCliente);
        }

        private void funcionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarFuncionario ofrmConsultarFuncionario = new frmConsultarFuncionario();
            AbrirForm(ofrmConsultarFuncionario);
        }

        private void livroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCLivros ofrmCLivros = new frmCLivros();
            AbrirForm(ofrmCLivros );
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarLivro ofrmConsultarLivro = new frmConsultarLivro();
            AbrirForm(ofrmConsultarLivro);
        }

        private void novoEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmprestar ofrmEmprestar = new frmEmprestar();
            AbrirForm(ofrmEmprestar);
        }

        private void empréstimoDevoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmprestimoDevolucao ofrmEmprestimoDevolucao = new frmEmprestimoDevolucao();
            AbrirForm(ofrmEmprestimoDevolucao);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre ofrmsobre = new frmSobre();
            AbrirForm(ofrmsobre);
        }
    }
}
