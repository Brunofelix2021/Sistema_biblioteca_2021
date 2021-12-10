namespace BibliotecaProjeto
{
    partial class lblUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblUsuario));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoEmpréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.livroToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cunsultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empréstimoDevoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblFuncionario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.cunsultarToolStripMenuItem,
            this.empréstimoDevoluçãoToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoEmpréstimoToolStripMenuItem,
            this.funcionárioToolStripMenuItem});
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // novoEmpréstimoToolStripMenuItem
            // 
            this.novoEmpréstimoToolStripMenuItem.Name = "novoEmpréstimoToolStripMenuItem";
            this.novoEmpréstimoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.novoEmpréstimoToolStripMenuItem.Text = "Novo Empréstimo";
            this.novoEmpréstimoToolStripMenuItem.Click += new System.EventHandler(this.novoEmpréstimoToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem2,
            this.clienteToolStripMenuItem2,
            this.livroToolStripMenuItem2});
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.funcionárioToolStripMenuItem.Text = "Cadastrar";
            // 
            // funcionárioToolStripMenuItem2
            // 
            this.funcionárioToolStripMenuItem2.Name = "funcionárioToolStripMenuItem2";
            this.funcionárioToolStripMenuItem2.Size = new System.Drawing.Size(137, 22);
            this.funcionárioToolStripMenuItem2.Text = "Funcionário";
            this.funcionárioToolStripMenuItem2.Click += new System.EventHandler(this.funcionárioToolStripMenuItem2_Click);
            // 
            // clienteToolStripMenuItem2
            // 
            this.clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
            this.clienteToolStripMenuItem2.Size = new System.Drawing.Size(137, 22);
            this.clienteToolStripMenuItem2.Text = "Cliente";
            this.clienteToolStripMenuItem2.Click += new System.EventHandler(this.clienteToolStripMenuItem2_Click);
            // 
            // livroToolStripMenuItem2
            // 
            this.livroToolStripMenuItem2.Name = "livroToolStripMenuItem2";
            this.livroToolStripMenuItem2.Size = new System.Drawing.Size(137, 22);
            this.livroToolStripMenuItem2.Text = "Livro";
            this.livroToolStripMenuItem2.Click += new System.EventHandler(this.livroToolStripMenuItem2_Click);
            // 
            // cunsultarToolStripMenuItem
            // 
            this.cunsultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.funcionárioToolStripMenuItem1,
            this.livrosToolStripMenuItem});
            this.cunsultarToolStripMenuItem.Name = "cunsultarToolStripMenuItem";
            this.cunsultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.cunsultarToolStripMenuItem.Text = "Consultar";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.clienteToolStripMenuItem1.Text = "Clientes";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // funcionárioToolStripMenuItem1
            // 
            this.funcionárioToolStripMenuItem1.Name = "funcionárioToolStripMenuItem1";
            this.funcionárioToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.funcionárioToolStripMenuItem1.Text = "Funcionários";
            this.funcionárioToolStripMenuItem1.Click += new System.EventHandler(this.funcionárioToolStripMenuItem1_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.livrosToolStripMenuItem.Text = "Livros";
            this.livrosToolStripMenuItem.Click += new System.EventHandler(this.livrosToolStripMenuItem_Click);
            // 
            // empréstimoDevoluçãoToolStripMenuItem
            // 
            this.empréstimoDevoluçãoToolStripMenuItem.Name = "empréstimoDevoluçãoToolStripMenuItem";
            this.empréstimoDevoluçãoToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.empréstimoDevoluçãoToolStripMenuItem.Text = "Empréstimo / Devolução";
            this.empréstimoDevoluçãoToolStripMenuItem.Click += new System.EventHandler(this.empréstimoDevoluçãoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFuncionario,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.lblData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(777, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(50, 17);
            this.lblFuncionario.Text = "Usuário:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel3.Text = "Data:";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(64, 17);
            this.lblData.Text = "    /    /      /";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BibliotecaProjeto.Properties.Resources.Sem_título_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 415);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "lblUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.lblUsuario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cunsultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoEmpréstimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empréstimoDevoluçãoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblFuncionario;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
    }
}

