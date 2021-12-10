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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void funcionárioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario ofrmCadastroFuncionario = new frmCadastroFuncionario();
            ofrmCadastroFuncionario.Show();
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
            frmCadastrarCliente ofrmCadastrarCliente = new frmCadastrarCliente();
            ofrmCadastrarCliente.Show();
        }
    }
}
