namespace BibliotecaProjeto
{
    partial class frmPrincipal
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
            this.empréstimoDevoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
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
            // 
            // cunsultarToolStripMenuItem
            // 
            this.cunsultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.funcionárioToolStripMenuItem1});
            this.cunsultarToolStripMenuItem.Name = "cunsultarToolStripMenuItem";
            this.cunsultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.cunsultarToolStripMenuItem.Text = "Consultar";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.clienteToolStripMenuItem1.Text = "Clientes";
            // 
            // funcionárioToolStripMenuItem1
            // 
            this.funcionárioToolStripMenuItem1.Name = "funcionárioToolStripMenuItem1";
            this.funcionárioToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.funcionárioToolStripMenuItem1.Text = "Funcionários";
            // 
            // empréstimoDevoluçãoToolStripMenuItem
            // 
            this.empréstimoDevoluçãoToolStripMenuItem.Name = "empréstimoDevoluçãoToolStripMenuItem";
            this.empréstimoDevoluçãoToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.empréstimoDevoluçãoToolStripMenuItem.Text = "Empréstimo / Devolução";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 559);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

