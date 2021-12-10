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
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {
            lblTexto.Text = "2016 Senac - Curso Tecnico de Informatica - TI49 \n";
            lblTexto.Text += "a Biblioteca  e sua interface do usuario sao protegido por marca \n";
            lblTexto.Text += "registro e outros dispositivos  propriedade intelectual existente ou \n";
            lblTexto.Text += "prendentes no Brasil e em outros Paises. Este produto estar licenciado sob o termos de licenca para \n";
            lblTexto.Text += "software Senac para: \n Administrador";

            lblSoftware.Text = "Biblioteca PassCoral";
            lblSoftware.Text += "Versao 1.0";
            lblSoftware.Text += "TI49 - Todos os direitos Reservados";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
