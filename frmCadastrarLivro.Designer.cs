namespace BibliotecaProjeto
{
    partial class frmCadastrarLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarLivro));
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.PicImagenLivro = new System.Windows.Forms.PictureBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.lbleditora = new System.Windows.Forms.Label();
            this.MskPreco = new System.Windows.Forms.MaskedTextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblFotoLivro = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnLimparCamposCliente = new System.Windows.Forms.Button();
            this.btnEscolher = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravarDados = new System.Windows.Forms.Button();
            this.lblAno = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCategoria
            // 
            this.cboCategoria.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(20, 219);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(158, 28);
            this.cboCategoria.TabIndex = 87;
            // 
            // PicImagenLivro
            // 
            this.PicImagenLivro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicImagenLivro.Location = new System.Drawing.Point(413, 31);
            this.PicImagenLivro.Name = "PicImagenLivro";
            this.PicImagenLivro.Size = new System.Drawing.Size(164, 179);
            this.PicImagenLivro.TabIndex = 86;
            this.PicImagenLivro.TabStop = false;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAutor.Location = new System.Drawing.Point(20, 105);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(351, 26);
            this.txtAutor.TabIndex = 85;
            // 
            // txtEditora
            // 
            this.txtEditora.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEditora.Location = new System.Drawing.Point(22, 157);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(349, 26);
            this.txtEditora.TabIndex = 84;
            // 
            // lbleditora
            // 
            this.lbleditora.AutoSize = true;
            this.lbleditora.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbleditora.Location = new System.Drawing.Point(18, 134);
            this.lbleditora.Name = "lbleditora";
            this.lbleditora.Size = new System.Drawing.Size(51, 20);
            this.lbleditora.TabIndex = 83;
            this.lbleditora.Text = "Editora";
            // 
            // MskPreco
            // 
            this.MskPreco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskPreco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MskPreco.Location = new System.Drawing.Point(274, 219);
            this.MskPreco.Mask = " ______,__";
            this.MskPreco.Name = "MskPreco";
            this.MskPreco.Size = new System.Drawing.Size(97, 26);
            this.MskPreco.TabIndex = 82;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPreco.Location = new System.Drawing.Point(270, 196);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(45, 20);
            this.lblPreco.TabIndex = 81;
            this.lblPreco.Text = "Preço";
            // 
            // lblFotoLivro
            // 
            this.lblFotoLivro.AutoSize = true;
            this.lblFotoLivro.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFotoLivro.ForeColor = System.Drawing.Color.Black;
            this.lblFotoLivro.Location = new System.Drawing.Point(435, 6);
            this.lblFotoLivro.Name = "lblFotoLivro";
            this.lblFotoLivro.Size = new System.Drawing.Size(122, 22);
            this.lblFotoLivro.TabIndex = 77;
            this.lblFotoLivro.Text = "Foto do Livro";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategoria.Location = new System.Drawing.Point(18, 196);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 20);
            this.lblCategoria.TabIndex = 76;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAutor.Location = new System.Drawing.Point(18, 84);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(40, 20);
            this.lblAutor.TabIndex = 75;
            this.lblAutor.Text = "Autor";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNome.Location = new System.Drawing.Point(21, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(350, 26);
            this.txtNome.TabIndex = 74;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.Location = new System.Drawing.Point(18, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(98, 20);
            this.lblNome.TabIndex = 73;
            this.lblNome.Text = "Nome do Livro";
            // 
            // btnLimparCamposCliente
            // 
            this.btnLimparCamposCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparCamposCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCamposCliente.Image = global::BibliotecaProjeto.Properties.Resources.Eraser;
            this.btnLimparCamposCliente.Location = new System.Drawing.Point(216, 289);
            this.btnLimparCamposCliente.Name = "btnLimparCamposCliente";
            this.btnLimparCamposCliente.Size = new System.Drawing.Size(167, 41);
            this.btnLimparCamposCliente.TabIndex = 193;
            this.btnLimparCamposCliente.Text = "Limpar Campos";
            this.btnLimparCamposCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparCamposCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparCamposCliente.UseVisualStyleBackColor = true;
            // 
            // btnEscolher
            // 
            this.btnEscolher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEscolher.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolher.Image = ((System.Drawing.Image)(resources.GetObject("btnEscolher.Image")));
            this.btnEscolher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEscolher.Location = new System.Drawing.Point(413, 221);
            this.btnEscolher.Name = "btnEscolher";
            this.btnEscolher.Size = new System.Drawing.Size(164, 57);
            this.btnEscolher.TabIndex = 192;
            this.btnEscolher.Text = "Escolher Imagem";
            this.btnEscolher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEscolher.UseVisualStyleBackColor = true;
            this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::BibliotecaProjeto.Properties.Resources.delete;
            this.btnSair.Location = new System.Drawing.Point(413, 289);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(167, 41);
            this.btnSair.TabIndex = 191;
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
            this.btnGravarDados.Location = new System.Drawing.Point(18, 289);
            this.btnGravarDados.Name = "btnGravarDados";
            this.btnGravarDados.Size = new System.Drawing.Size(167, 41);
            this.btnGravarDados.TabIndex = 190;
            this.btnGravarDados.Text = "Gravar Dados";
            this.btnGravarDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravarDados.UseVisualStyleBackColor = true;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAno.Location = new System.Drawing.Point(180, 196);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(81, 20);
            this.lblAno.TabIndex = 194;
            this.lblAno.Text = "Lançamento";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maskedTextBox1.Location = new System.Drawing.Point(184, 219);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(84, 27);
            this.maskedTextBox1.TabIndex = 195;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // frmCadastrarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 347);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.btnLimparCamposCliente);
            this.Controls.Add(this.btnEscolher);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravarDados);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.PicImagenLivro);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.lbleditora);
            this.Controls.Add(this.MskPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblFotoLivro);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCadastrarLivro";
            this.Text = "frmCadastrarLivro";
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.PictureBox PicImagenLivro;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label lbleditora;
        public System.Windows.Forms.MaskedTextBox MskPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblFotoLivro;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnLimparCamposCliente;
        private System.Windows.Forms.Button btnEscolher;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGravarDados;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}