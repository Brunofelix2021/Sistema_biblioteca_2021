namespace BibliotecaProjeto
{
    partial class frmConsultarLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarLivro));
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExemplares = new System.Windows.Forms.TextBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdentificacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.picImagemLivro = new System.Windows.Forms.PictureBox();
            this.btnEscolher = new System.Windows.Forms.Button();
            this.grdLivros = new System.Windows.Forms.DataGridView();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtConsultarCodigo = new System.Windows.Forms.TextBox();
            this.txtConsultarNome = new System.Windows.Forms.TextBox();
            this.txtConsultarAutor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnGravarDados = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Location = new System.Drawing.Point(784, 178);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(88, 26);
            this.txtValor.TabIndex = 285;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(750, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 284;
            this.label7.Text = "Valor Perda/Dano";
            // 
            // txtExemplares
            // 
            this.txtExemplares.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExemplares.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExemplares.ForeColor = System.Drawing.Color.Black;
            this.txtExemplares.Location = new System.Drawing.Point(670, 178);
            this.txtExemplares.MaxLength = 2;
            this.txtExemplares.Name = "txtExemplares";
            this.txtExemplares.Size = new System.Drawing.Size(77, 26);
            this.txtExemplares.TabIndex = 283;
            this.txtExemplares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExemplares_KeyPress);
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenero.ForeColor = System.Drawing.Color.Black;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(479, 123);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(183, 28);
            this.cboGenero.TabIndex = 282;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(666, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 281;
            this.label5.Text = "Exemplares";
            // 
            // txtIdentificacao
            // 
            this.txtIdentificacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdentificacao.Enabled = false;
            this.txtIdentificacao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacao.ForeColor = System.Drawing.Color.Black;
            this.txtIdentificacao.Location = new System.Drawing.Point(480, 178);
            this.txtIdentificacao.MaxLength = 20;
            this.txtIdentificacao.Name = "txtIdentificacao";
            this.txtIdentificacao.Size = new System.Drawing.Size(182, 26);
            this.txtIdentificacao.TabIndex = 279;
            this.txtIdentificacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacao_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(477, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 280;
            this.label6.Text = "Código";
            // 
            // txtEditora
            // 
            this.txtEditora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEditora.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.ForeColor = System.Drawing.Color.Black;
            this.txtEditora.Location = new System.Drawing.Point(672, 123);
            this.txtEditora.MaxLength = 50;
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(200, 26);
            this.txtEditora.TabIndex = 277;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(668, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 278;
            this.label3.Text = "Editora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(476, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 276;
            this.label4.Text = "Gênero";
            // 
            // txtAno
            // 
            this.txtAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.ForeColor = System.Drawing.Color.Black;
            this.txtAno.Location = new System.Drawing.Point(788, 70);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(84, 26);
            this.txtAno.TabIndex = 274;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(784, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 275;
            this.label2.Text = "Ano";
            // 
            // txtAutor
            // 
            this.txtAutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAutor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.ForeColor = System.Drawing.Color.Black;
            this.txtAutor.Location = new System.Drawing.Point(478, 70);
            this.txtAutor.MaxLength = 50;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(304, 26);
            this.txtAutor.TabIndex = 272;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(475, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 273;
            this.label1.Text = "Autor";
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeLivro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivro.ForeColor = System.Drawing.Color.Black;
            this.txtNomeLivro.Location = new System.Drawing.Point(477, 22);
            this.txtNomeLivro.MaxLength = 50;
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(395, 26);
            this.txtNomeLivro.TabIndex = 265;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(474, 2);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(98, 20);
            this.lblNome.TabIndex = 268;
            this.lblNome.Text = "Nome do Livro";
            // 
            // picImagemLivro
            // 
            this.picImagemLivro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagemLivro.Image = ((System.Drawing.Image)(resources.GetObject("picImagemLivro.Image")));
            this.picImagemLivro.Location = new System.Drawing.Point(878, 22);
            this.picImagemLivro.Name = "picImagemLivro";
            this.picImagemLivro.Size = new System.Drawing.Size(124, 136);
            this.picImagemLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagemLivro.TabIndex = 271;
            this.picImagemLivro.TabStop = false;
            // 
            // btnEscolher
            // 
            this.btnEscolher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEscolher.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolher.Image = ((System.Drawing.Image)(resources.GetObject("btnEscolher.Image")));
            this.btnEscolher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEscolher.Location = new System.Drawing.Point(878, 164);
            this.btnEscolher.Name = "btnEscolher";
            this.btnEscolher.Size = new System.Drawing.Size(124, 42);
            this.btnEscolher.TabIndex = 269;
            this.btnEscolher.Text = "Incluir Imagem";
            this.btnEscolher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEscolher.UseVisualStyleBackColor = true;
            this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
            // 
            // grdLivros
            // 
            this.grdLivros.AllowUserToAddRows = false;
            this.grdLivros.AllowUserToDeleteRows = false;
            this.grdLivros.AllowUserToResizeColumns = false;
            this.grdLivros.AllowUserToResizeRows = false;
            this.grdLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLivros.Location = new System.Drawing.Point(12, 212);
            this.grdLivros.MultiSelect = false;
            this.grdLivros.Name = "grdLivros";
            this.grdLivros.ReadOnly = true;
            this.grdLivros.RowHeadersVisible = false;
            this.grdLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLivros.Size = new System.Drawing.Size(990, 320);
            this.grdLivros.TabIndex = 289;
            this.grdLivros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLivros_CellClick);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparCampos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparCampos.Image")));
            this.btnLimparCampos.Location = new System.Drawing.Point(679, 538);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(156, 41);
            this.btnLimparCampos.TabIndex = 292;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparCampos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(843, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 41);
            this.button3.TabIndex = 291;
            this.button3.Text = "Cancelar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtConsultarCodigo
            // 
            this.txtConsultarCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsultarCodigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtConsultarCodigo.Location = new System.Drawing.Point(12, 73);
            this.txtConsultarCodigo.MaxLength = 20;
            this.txtConsultarCodigo.Name = "txtConsultarCodigo";
            this.txtConsultarCodigo.Size = new System.Drawing.Size(425, 26);
            this.txtConsultarCodigo.TabIndex = 289;
            this.txtConsultarCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultarCodigo_KeyPress);
            // 
            // txtConsultarNome
            // 
            this.txtConsultarNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsultarNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarNome.ForeColor = System.Drawing.Color.Black;
            this.txtConsultarNome.Location = new System.Drawing.Point(12, 22);
            this.txtConsultarNome.MaxLength = 50;
            this.txtConsultarNome.Name = "txtConsultarNome";
            this.txtConsultarNome.Size = new System.Drawing.Size(425, 26);
            this.txtConsultarNome.TabIndex = 293;
            // 
            // txtConsultarAutor
            // 
            this.txtConsultarAutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsultarAutor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarAutor.ForeColor = System.Drawing.Color.Black;
            this.txtConsultarAutor.Location = new System.Drawing.Point(12, 125);
            this.txtConsultarAutor.MaxLength = 50;
            this.txtConsultarAutor.Name = "txtConsultarAutor";
            this.txtConsultarAutor.Size = new System.Drawing.Size(425, 26);
            this.txtConsultarAutor.TabIndex = 294;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 295;
            this.label8.Text = "Código";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 296;
            this.label9.Text = "Nome do livro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 297;
            this.label10.Text = "Autor";
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(12, 164);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(425, 40);
            this.btnConsultar.TabIndex = 298;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnGravarDados
            // 
            this.btnGravarDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGravarDados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarDados.Image = ((System.Drawing.Image)(resources.GetObject("btnGravarDados.Image")));
            this.btnGravarDados.Location = new System.Drawing.Point(506, 538);
            this.btnGravarDados.Name = "btnGravarDados";
            this.btnGravarDados.Size = new System.Drawing.Size(167, 41);
            this.btnGravarDados.TabIndex = 299;
            this.btnGravarDados.Text = "Alterar Dados";
            this.btnGravarDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravarDados.UseVisualStyleBackColor = true;
            this.btnGravarDados.Click += new System.EventHandler(this.btnGravarDados_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(753, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 20);
            this.label11.TabIndex = 300;
            this.label11.Text = "R$";
            // 
            // frmConsultarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 588);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGravarDados);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtConsultarNome);
            this.Controls.Add(this.txtConsultarAutor);
            this.Controls.Add(this.txtConsultarCodigo);
            this.Controls.Add(this.grdLivros);
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
            this.Controls.Add(this.picImagemLivro);
            this.Controls.Add(this.btnEscolher);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Livro";
            this.Load += new System.EventHandler(this.frmConsultarLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagemLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExemplares;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdentificacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picImagemLivro;
        private System.Windows.Forms.Button btnEscolher;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView grdLivros;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtConsultarCodigo;
        private System.Windows.Forms.TextBox txtConsultarNome;
        private System.Windows.Forms.TextBox txtConsultarAutor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnGravarDados;
        private System.Windows.Forms.Label label11;
    }
}