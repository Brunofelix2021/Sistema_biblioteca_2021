namespace BibliotecaProjeto
{
    partial class frmConsultarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarCliente));
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstadao = new System.Windows.Forms.Label();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.mskConsultarCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.picImagemCliente = new System.Windows.Forms.PictureBox();
            this.btnLimparCamposCliente = new System.Windows.Forms.Button();
            this.btnEscolher = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravarDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(665, 226);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(161, 26);
            this.txtBairro.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(661, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 223;
            this.label5.Text = "Bairro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.ForeColor = System.Drawing.Color.Black;
            this.txtComplemento.Location = new System.Drawing.Point(430, 226);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(229, 26);
            this.txtComplemento.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(427, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 222;
            this.label4.Text = "Complemento";
            // 
            // mskCPF
            // 
            this.mskCPF.Enabled = false;
            this.mskCPF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.ForeColor = System.Drawing.Color.Black;
            this.mskCPF.Location = new System.Drawing.Point(700, 82);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(126, 26);
            this.mskCPF.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(696, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 221;
            this.label3.Text = "CPF";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Black;
            this.txtNumero.Location = new System.Drawing.Point(747, 178);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(79, 26);
            this.txtNumero.TabIndex = 9;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(745, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 220;
            this.label2.Text = "Nº";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(427, 130);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(399, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(426, 108);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 215;
            this.lblEmail.Text = "E-mail";
            // 
            // mskCEP
            // 
            this.mskCEP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCEP.ForeColor = System.Drawing.Color.Black;
            this.mskCEP.Location = new System.Drawing.Point(431, 276);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(89, 26);
            this.mskCEP.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(427, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 214;
            this.label1.Text = "CEP";
            // 
            // mskCelular
            // 
            this.mskCelular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCelular.ForeColor = System.Drawing.Color.Black;
            this.mskCelular.Location = new System.Drawing.Point(561, 82);
            this.mskCelular.Mask = "(00)00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(122, 26);
            this.mskCelular.TabIndex = 5;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.ForeColor = System.Drawing.Color.Black;
            this.mskTelefone.Location = new System.Drawing.Point(430, 82);
            this.mskTelefone.Mask = "(00)0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(112, 26);
            this.mskTelefone.TabIndex = 4;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.Black;
            this.txtEndereco.Location = new System.Drawing.Point(428, 178);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(312, 26);
            this.txtEndereco.TabIndex = 8;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.Black;
            this.lblEndereco.Location = new System.Drawing.Point(424, 157);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(68, 20);
            this.lblEndereco.TabIndex = 213;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.Black;
            this.lblCelular.Location = new System.Drawing.Point(561, 61);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(50, 20);
            this.lblCelular.TabIndex = 212;
            this.lblCelular.Text = "Celular";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.Black;
            this.lblTelefone.Location = new System.Drawing.Point(426, 59);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(61, 20);
            this.lblTelefone.TabIndex = 211;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(431, 33);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(395, 26);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(429, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 20);
            this.lblNome.TabIndex = 210;
            this.lblNome.Text = "Nome";
            // 
            // cboCidade
            // 
            this.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCidade.ForeColor = System.Drawing.Color.Black;
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(621, 274);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(205, 28);
            this.cboCidade.TabIndex = 206;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.ForeColor = System.Drawing.Color.Black;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(526, 274);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(82, 28);
            this.cboEstado.TabIndex = 205;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.lblCidade.Location = new System.Drawing.Point(622, 255);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 20);
            this.lblCidade.TabIndex = 209;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEstadao
            // 
            this.lblEstadao.AutoSize = true;
            this.lblEstadao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadao.ForeColor = System.Drawing.Color.Black;
            this.lblEstadao.Location = new System.Drawing.Point(522, 255);
            this.lblEstadao.Name = "lblEstadao";
            this.lblEstadao.Size = new System.Drawing.Size(26, 20);
            this.lblEstadao.TabIndex = 208;
            this.lblEstadao.Text = "UF";
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.AllowUserToResizeColumns = false;
            this.grdClientes.AllowUserToResizeRows = false;
            this.grdClientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Location = new System.Drawing.Point(14, 61);
            this.grdClientes.MultiSelect = false;
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.RowHeadersVisible = false;
            this.grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClientes.Size = new System.Drawing.Size(404, 293);
            this.grdClientes.TabIndex = 2;
            this.grdClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellClick);
            // 
            // mskConsultarCPF
            // 
            this.mskConsultarCPF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskConsultarCPF.ForeColor = System.Drawing.Color.Black;
            this.mskConsultarCPF.Location = new System.Drawing.Point(116, 20);
            this.mskConsultarCPF.Mask = "000.000.000-00";
            this.mskConsultarCPF.Name = "mskConsultarCPF";
            this.mskConsultarCPF.Size = new System.Drawing.Size(122, 26);
            this.mskConsultarCPF.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 226;
            this.label6.Text = "Consultar CPF:";
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCliente.Location = new System.Drawing.Point(245, 19);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(173, 27);
            this.btnConsultarCliente.TabIndex = 1;
            this.btnConsultarCliente.Text = "Buscar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // picImagemCliente
            // 
            this.picImagemCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagemCliente.Image = global::BibliotecaProjeto.Properties.Resources.usuario;
            this.picImagemCliente.Location = new System.Drawing.Point(845, 35);
            this.picImagemCliente.Name = "picImagemCliente";
            this.picImagemCliente.Size = new System.Drawing.Size(145, 190);
            this.picImagemCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagemCliente.TabIndex = 219;
            this.picImagemCliente.TabStop = false;
            // 
            // btnLimparCamposCliente
            // 
            this.btnLimparCamposCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparCamposCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCamposCliente.Image = global::BibliotecaProjeto.Properties.Resources.Eraser;
            this.btnLimparCamposCliente.Location = new System.Drawing.Point(626, 315);
            this.btnLimparCamposCliente.Name = "btnLimparCamposCliente";
            this.btnLimparCamposCliente.Size = new System.Drawing.Size(167, 41);
            this.btnLimparCamposCliente.TabIndex = 218;
            this.btnLimparCamposCliente.Text = "Limpar Campos";
            this.btnLimparCamposCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparCamposCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparCamposCliente.UseVisualStyleBackColor = true;
            this.btnLimparCamposCliente.Click += new System.EventHandler(this.btnLimparCamposCliente_Click);
            // 
            // btnEscolher
            // 
            this.btnEscolher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEscolher.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolher.Image = ((System.Drawing.Image)(resources.GetObject("btnEscolher.Image")));
            this.btnEscolher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEscolher.Location = new System.Drawing.Point(845, 246);
            this.btnEscolher.Name = "btnEscolher";
            this.btnEscolher.Size = new System.Drawing.Size(145, 57);
            this.btnEscolher.TabIndex = 217;
            this.btnEscolher.Text = "Alterar Imagem";
            this.btnEscolher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEscolher.UseVisualStyleBackColor = true;
            this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::BibliotecaProjeto.Properties.Resources.delete;
            this.btnSair.Location = new System.Drawing.Point(823, 315);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(167, 41);
            this.btnSair.TabIndex = 4;
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
            this.btnGravarDados.Location = new System.Drawing.Point(428, 315);
            this.btnGravarDados.Name = "btnGravarDados";
            this.btnGravarDados.Size = new System.Drawing.Size(167, 41);
            this.btnGravarDados.TabIndex = 3;
            this.btnGravarDados.Text = "Alterar Dados";
            this.btnGravarDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravarDados.UseVisualStyleBackColor = true;
            this.btnGravarDados.Click += new System.EventHandler(this.btnGravarDados_Click);
            // 
            // frmConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 369);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskConsultarCPF);
            this.Controls.Add(this.grdClientes);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picImagemCliente);
            this.Controls.Add(this.btnLimparCamposCliente);
            this.Controls.Add(this.btnEscolher);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravarDados);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskCelular);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cboCidade);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEstadao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Cliente";
            this.Load += new System.EventHandler(this.frmConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picImagemCliente;
        private System.Windows.Forms.Button btnLimparCamposCliente;
        private System.Windows.Forms.Button btnEscolher;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGravarDados;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstadao;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.MaskedTextBox mskConsultarCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConsultarCliente;
    }
}