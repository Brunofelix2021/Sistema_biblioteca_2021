namespace BibliotecaProjeto
{
    partial class frmCLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCLivros));
            this.picImagemlivro = new System.Windows.Forms.PictureBox();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.btnEscolher = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravarDados = new System.Windows.Forms.Button();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdentificacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.txtExemplares = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemlivro)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagemlivro
            // 
            this.picImagemlivro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagemlivro.Image = global::BibliotecaProjeto.Properties.Resources.usuario;
            this.picImagemlivro.Location = new System.Drawing.Point(407, 24);
            this.picImagemlivro.Name = "picImagemlivro";
            this.picImagemlivro.Size = new System.Drawing.Size(124, 136);
            this.picImagemlivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagemlivro.TabIndex = 248;
            this.picImagemlivro.TabStop = false;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparCampos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.Image = global::BibliotecaProjeto.Properties.Resources.Eraser;
            this.btnLimparCampos.Location = new System.Drawing.Point(192, 217);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(156, 41);
            this.btnLimparCampos.TabIndex = 247;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparCampos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCamposCliente_Click);
            // 
            // btnEscolher
            // 
            this.btnEscolher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEscolher.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolher.Image = ((System.Drawing.Image)(resources.GetObject("btnEscolher.Image")));
            this.btnEscolher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEscolher.Location = new System.Drawing.Point(407, 166);
            this.btnEscolher.Name = "btnEscolher";
            this.btnEscolher.Size = new System.Drawing.Size(124, 42);
            this.btnEscolher.TabIndex = 246;
            this.btnEscolher.Text = "Incluir Imagem";
            this.btnEscolher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEscolher.UseVisualStyleBackColor = true;
            this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::BibliotecaProjeto.Properties.Resources.delete;
            this.btnSair.Location = new System.Drawing.Point(375, 217);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(156, 41);
            this.btnSair.TabIndex = 227;
            this.btnSair.Text = "Cancelar";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGravarDados
            // 
            this.btnGravarDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGravarDados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarDados.Image = global::BibliotecaProjeto.Properties.Resources.FloppyDisks;
            this.btnGravarDados.Location = new System.Drawing.Point(8, 217);
            this.btnGravarDados.Name = "btnGravarDados";
            this.btnGravarDados.Size = new System.Drawing.Size(156, 41);
            this.btnGravarDados.TabIndex = 225;
            this.btnGravarDados.Text = "Gravar";
            this.btnGravarDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravarDados.UseVisualStyleBackColor = true;
            this.btnGravarDados.Click += new System.EventHandler(this.btnGravarDados_Click);
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeLivro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivro.ForeColor = System.Drawing.Color.Black;
            this.txtNomeLivro.Location = new System.Drawing.Point(6, 24);
            this.txtNomeLivro.MaxLength = 50;
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(395, 26);
            this.txtNomeLivro.TabIndex = 224;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(3, 4);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(98, 20);
            this.lblNome.TabIndex = 240;
            this.lblNome.Text = "Nome do Livro";
            // 
            // txtAutor
            // 
            this.txtAutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAutor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.ForeColor = System.Drawing.Color.Black;
            this.txtAutor.Location = new System.Drawing.Point(7, 72);
            this.txtAutor.MaxLength = 50;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(304, 26);
            this.txtAutor.TabIndex = 249;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 250;
            this.label1.Text = "Autor";
            // 
            // txtAno
            // 
            this.txtAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.ForeColor = System.Drawing.Color.Black;
            this.txtAno.Location = new System.Drawing.Point(317, 72);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(84, 26);
            this.txtAno.TabIndex = 251;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(313, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 252;
            this.label2.Text = "Ano";
            // 
            // txtEditora
            // 
            this.txtEditora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEditora.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.ForeColor = System.Drawing.Color.Black;
            this.txtEditora.Location = new System.Drawing.Point(201, 125);
            this.txtEditora.MaxLength = 50;
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(200, 26);
            this.txtEditora.TabIndex = 255;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(197, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 256;
            this.label3.Text = "Editora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 254;
            this.label4.Text = "Gênero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(195, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 260;
            this.label5.Text = "Exemplares";
            // 
            // txtIdentificacao
            // 
            this.txtIdentificacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdentificacao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacao.ForeColor = System.Drawing.Color.Black;
            this.txtIdentificacao.Location = new System.Drawing.Point(9, 180);
            this.txtIdentificacao.MaxLength = 20;
            this.txtIdentificacao.Name = "txtIdentificacao";
            this.txtIdentificacao.Size = new System.Drawing.Size(182, 26);
            this.txtIdentificacao.TabIndex = 257;
            this.txtIdentificacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacao_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 258;
            this.label6.Text = "Código";
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenero.ForeColor = System.Drawing.Color.Black;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(8, 125);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(183, 28);
            this.cboGenero.TabIndex = 261;
            // 
            // txtExemplares
            // 
            this.txtExemplares.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExemplares.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExemplares.ForeColor = System.Drawing.Color.Black;
            this.txtExemplares.Location = new System.Drawing.Point(199, 180);
            this.txtExemplares.MaxLength = 2;
            this.txtExemplares.Name = "txtExemplares";
            this.txtExemplares.Size = new System.Drawing.Size(77, 26);
            this.txtExemplares.TabIndex = 262;
            this.txtExemplares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExemplares_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(279, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 263;
            this.label7.Text = "Valor Perda/Dano";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(282, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 20);
            this.label11.TabIndex = 301;
            this.label11.Text = "R$";
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Location = new System.Drawing.Point(313, 180);
            this.txtValor.MaxLength = 7;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(88, 26);
            this.txtValor.TabIndex = 264;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 268);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtExemplares);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdentificacao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picImagemlivro);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.btnEscolher);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravarDados);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Livros";
            this.Load += new System.EventHandler(this.frmCLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagemlivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagemlivro;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Button btnEscolher;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGravarDados;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdentificacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.TextBox txtExemplares;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValor;
    }
}