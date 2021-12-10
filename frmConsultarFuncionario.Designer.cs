namespace BibliotecaProjeto
{
    partial class frmConsultarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarFuncionario));
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mskConsultarCPF = new System.Windows.Forms.MaskedTextBox();
            this.grdFuncionarios = new System.Windows.Forms.DataGridView();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.gpoLogin = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmacao = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.picImagemFuncionario = new System.Windows.Forms.PictureBox();
            this.btnLimparCamposCliente = new System.Windows.Forms.Button();
            this.btnEscolher = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravarDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdFuncionarios)).BeginInit();
            this.gpoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCliente.Location = new System.Drawing.Point(240, 17);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(173, 27);
            this.btnConsultarCliente.TabIndex = 228;
            this.btnConsultarCliente.Text = "Buscar por CPF";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 259;
            this.label6.Text = "CPF:";
            // 
            // mskConsultarCPF
            // 
            this.mskConsultarCPF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskConsultarCPF.ForeColor = System.Drawing.Color.Black;
            this.mskConsultarCPF.Location = new System.Drawing.Point(60, 18);
            this.mskConsultarCPF.Mask = "000.000.000-00";
            this.mskConsultarCPF.Name = "mskConsultarCPF";
            this.mskConsultarCPF.Size = new System.Drawing.Size(174, 26);
            this.mskConsultarCPF.TabIndex = 227;
            // 
            // grdFuncionarios
            // 
            this.grdFuncionarios.AllowUserToAddRows = false;
            this.grdFuncionarios.AllowUserToDeleteRows = false;
            this.grdFuncionarios.AllowUserToResizeColumns = false;
            this.grdFuncionarios.AllowUserToResizeRows = false;
            this.grdFuncionarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFuncionarios.Location = new System.Drawing.Point(10, 53);
            this.grdFuncionarios.MultiSelect = false;
            this.grdFuncionarios.Name = "grdFuncionarios";
            this.grdFuncionarios.ReadOnly = true;
            this.grdFuncionarios.RowHeadersVisible = false;
            this.grdFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFuncionarios.Size = new System.Drawing.Size(404, 528);
            this.grdFuncionarios.TabIndex = 229;
            this.grdFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellClick);
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(649, 220);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(187, 26);
            this.txtBairro.TabIndex = 268;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(646, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 291;
            this.label9.Text = "Bairro";
            // 
            // cboCargo
            // 
            this.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCargo.ForeColor = System.Drawing.Color.Black;
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(555, 321);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(281, 28);
            this.cboCargo.TabIndex = 272;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(555, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 290;
            this.label8.Text = "Cargo";
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.ForeColor = System.Drawing.Color.Black;
            this.txtComplemento.Location = new System.Drawing.Point(437, 220);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(206, 26);
            this.txtComplemento.TabIndex = 267;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(434, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 289;
            this.label2.Text = "Complemento";
            // 
            // mskCPF
            // 
            this.mskCPF.Enabled = false;
            this.mskCPF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.ForeColor = System.Drawing.Color.Black;
            this.mskCPF.Location = new System.Drawing.Point(707, 76);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(129, 26);
            this.mskCPF.TabIndex = 263;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(703, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 288;
            this.label3.Text = "CPF";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Black;
            this.txtNumero.Location = new System.Drawing.Point(754, 172);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(82, 26);
            this.txtNumero.TabIndex = 266;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(752, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 287;
            this.label4.Text = "Nº";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(437, 124);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(399, 26);
            this.txtEmail.TabIndex = 264;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(433, 105);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 286;
            this.lblEmail.Text = "E-mail";
            // 
            // mskCEP
            // 
            this.mskCEP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCEP.ForeColor = System.Drawing.Color.Black;
            this.mskCEP.Location = new System.Drawing.Point(438, 322);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(111, 26);
            this.mskCEP.TabIndex = 271;
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(434, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 285;
            this.label7.Text = "CEP";
            // 
            // mskCelular
            // 
            this.mskCelular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCelular.ForeColor = System.Drawing.Color.Black;
            this.mskCelular.Location = new System.Drawing.Point(568, 76);
            this.mskCelular.Mask = "(00)00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(122, 26);
            this.mskCelular.TabIndex = 262;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.ForeColor = System.Drawing.Color.Black;
            this.mskTelefone.Location = new System.Drawing.Point(437, 76);
            this.mskTelefone.Mask = "(00)0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(112, 26);
            this.mskTelefone.TabIndex = 261;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.Black;
            this.txtEndereco.Location = new System.Drawing.Point(437, 172);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(310, 26);
            this.txtEndereco.TabIndex = 265;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.Black;
            this.lblEndereco.Location = new System.Drawing.Point(434, 151);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(68, 20);
            this.lblEndereco.TabIndex = 284;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.Black;
            this.lblCelular.Location = new System.Drawing.Point(568, 55);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(50, 20);
            this.lblCelular.TabIndex = 283;
            this.lblCelular.Text = "Celular";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.Black;
            this.lblTelefone.Location = new System.Drawing.Point(433, 53);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(61, 20);
            this.lblTelefone.TabIndex = 282;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(438, 27);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(398, 26);
            this.txtNome.TabIndex = 260;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(435, 7);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 20);
            this.lblNome.TabIndex = 281;
            this.lblNome.Text = "Nome";
            // 
            // cboCidade
            // 
            this.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCidade.ForeColor = System.Drawing.Color.Black;
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(533, 269);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(303, 28);
            this.cboCidade.TabIndex = 270;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.ForeColor = System.Drawing.Color.Black;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(438, 269);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(86, 28);
            this.cboEstado.TabIndex = 269;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.lblCidade.Location = new System.Drawing.Point(530, 250);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 20);
            this.lblCidade.TabIndex = 280;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEstadao
            // 
            this.lblEstadao.AutoSize = true;
            this.lblEstadao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadao.ForeColor = System.Drawing.Color.Black;
            this.lblEstadao.Location = new System.Drawing.Point(436, 248);
            this.lblEstadao.Name = "lblEstadao";
            this.lblEstadao.Size = new System.Drawing.Size(26, 20);
            this.lblEstadao.TabIndex = 279;
            this.lblEstadao.Text = "UF";
            // 
            // gpoLogin
            // 
            this.gpoLogin.Controls.Add(this.pictureBox2);
            this.gpoLogin.Controls.Add(this.pictureBox1);
            this.gpoLogin.Controls.Add(this.groupBox4);
            this.gpoLogin.Controls.Add(this.label5);
            this.gpoLogin.Controls.Add(this.txtConfirmacao);
            this.gpoLogin.Controls.Add(this.txtSenha);
            this.gpoLogin.Controls.Add(this.label10);
            this.gpoLogin.Controls.Add(this.label11);
            this.gpoLogin.Controls.Add(this.txtLogin);
            this.gpoLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoLogin.Location = new System.Drawing.Point(432, 357);
            this.gpoLogin.Name = "gpoLogin";
            this.gpoLogin.Size = new System.Drawing.Size(565, 171);
            this.gpoLogin.TabIndex = 278;
            this.gpoLogin.TabStop = false;
            this.gpoLogin.Text = "Cadastro de usuário";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 171;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 170;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbInativo);
            this.groupBox4.Controls.Add(this.rdbAtivo);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(425, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 107);
            this.groupBox4.TabIndex = 169;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Location = new System.Drawing.Point(8, 62);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(65, 24);
            this.rdbInativo.TabIndex = 4;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Checked = true;
            this.rdbAtivo.Location = new System.Drawing.Point(8, 30);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(57, 24);
            this.rdbAtivo.TabIndex = 3;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 168;
            this.label5.Text = "Confirmação";
            // 
            // txtConfirmacao
            // 
            this.txtConfirmacao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacao.Location = new System.Drawing.Point(147, 114);
            this.txtConfirmacao.MaxLength = 50;
            this.txtConfirmacao.Name = "txtConfirmacao";
            this.txtConfirmacao.Size = new System.Drawing.Size(257, 26);
            this.txtConfirmacao.TabIndex = 2;
            this.txtConfirmacao.UseSystemPasswordChar = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(147, 78);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(257, 26);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(79, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 165;
            this.label10.Text = "Senha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(80, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 163;
            this.label11.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtLogin.Enabled = false;
            this.txtLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(147, 43);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(257, 26);
            this.txtLogin.TabIndex = 0;
            // 
            // picImagemFuncionario
            // 
            this.picImagemFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagemFuncionario.Image = global::BibliotecaProjeto.Properties.Resources.usuario;
            this.picImagemFuncionario.Location = new System.Drawing.Point(852, 27);
            this.picImagemFuncionario.Name = "picImagemFuncionario";
            this.picImagemFuncionario.Size = new System.Drawing.Size(145, 193);
            this.picImagemFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagemFuncionario.TabIndex = 277;
            this.picImagemFuncionario.TabStop = false;
            // 
            // btnLimparCamposCliente
            // 
            this.btnLimparCamposCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparCamposCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCamposCliente.Image = global::BibliotecaProjeto.Properties.Resources.Eraser;
            this.btnLimparCamposCliente.Location = new System.Drawing.Point(631, 540);
            this.btnLimparCamposCliente.Name = "btnLimparCamposCliente";
            this.btnLimparCamposCliente.Size = new System.Drawing.Size(167, 41);
            this.btnLimparCamposCliente.TabIndex = 276;
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
            this.btnEscolher.Location = new System.Drawing.Point(852, 238);
            this.btnEscolher.Name = "btnEscolher";
            this.btnEscolher.Size = new System.Drawing.Size(145, 59);
            this.btnEscolher.TabIndex = 275;
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
            this.btnSair.Location = new System.Drawing.Point(828, 540);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(167, 41);
            this.btnSair.TabIndex = 274;
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
            this.btnGravarDados.Location = new System.Drawing.Point(433, 540);
            this.btnGravarDados.Name = "btnGravarDados";
            this.btnGravarDados.Size = new System.Drawing.Size(167, 41);
            this.btnGravarDados.TabIndex = 273;
            this.btnGravarDados.Text = "Alterar Dados";
            this.btnGravarDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravarDados.UseVisualStyleBackColor = true;
            this.btnGravarDados.Click += new System.EventHandler(this.btnGravarDados_Click);
            // 
            // frmConsultarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 590);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.gpoLogin);
            this.Controls.Add(this.picImagemFuncionario);
            this.Controls.Add(this.btnLimparCamposCliente);
            this.Controls.Add(this.btnEscolher);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravarDados);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskConsultarCPF);
            this.Controls.Add(this.grdFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarFuncionario";
            this.Load += new System.EventHandler(this.frmConsultarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFuncionarios)).EndInit();
            this.gpoLogin.ResumeLayout(false);
            this.gpoLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskConsultarCPF;
        private System.Windows.Forms.DataGridView grdFuncionarios;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.GroupBox gpoLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmacao;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.PictureBox picImagemFuncionario;
        private System.Windows.Forms.Button btnLimparCamposCliente;
        private System.Windows.Forms.Button btnEscolher;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGravarDados;
    }
}