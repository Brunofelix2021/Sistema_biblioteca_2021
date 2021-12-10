namespace BibliotecaProjeto
{
    partial class frmEmprestar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmprestar));
            this.label11 = new System.Windows.Forms.Label();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtConsultarCodigo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gpoDadosLivro = new System.Windows.Forms.GroupBox();
            this.lblStatusLivro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gpoDadosCliente = new System.Windows.Forms.GroupBox();
            this.lblStatusCliente = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblDias = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroEmprestimo = new System.Windows.Forms.TextBox();
            this.gpoDadosLivro.SuspendLayout();
            this.gpoDadosCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(415, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 20);
            this.label11.TabIndex = 330;
            this.label11.Text = "R$";
            // 
            // btnConcluir
            // 
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConcluir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnConcluir.Image")));
            this.btnConcluir.Location = new System.Drawing.Point(235, 460);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(167, 41);
            this.btnConcluir.TabIndex = 329;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 325;
            this.label8.Text = "Código do Livro:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(408, 460);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 41);
            this.btnCancelar.TabIndex = 321;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtConsultarCodigo
            // 
            this.txtConsultarCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsultarCodigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtConsultarCodigo.Location = new System.Drawing.Point(122, 16);
            this.txtConsultarCodigo.MaxLength = 20;
            this.txtConsultarCodigo.Name = "txtConsultarCodigo";
            this.txtConsultarCodigo.Size = new System.Drawing.Size(258, 26);
            this.txtConsultarCodigo.TabIndex = 320;
            this.txtConsultarCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultarCodigo_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Location = new System.Drawing.Point(446, 41);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(88, 26);
            this.txtValor.TabIndex = 318;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(412, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 317;
            this.label7.Text = "Valor Perda/Dano";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(380, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 313;
            this.label6.Text = "Status";
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeLivro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivro.ForeColor = System.Drawing.Color.Black;
            this.txtNomeLivro.Location = new System.Drawing.Point(11, 41);
            this.txtNomeLivro.MaxLength = 50;
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.ReadOnly = true;
            this.txtNomeLivro.Size = new System.Drawing.Size(395, 26);
            this.txtNomeLivro.TabIndex = 301;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(8, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(98, 20);
            this.lblNome.TabIndex = 302;
            this.lblNome.Text = "Nome do Livro";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(386, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 30);
            this.button1.TabIndex = 332;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpoDadosLivro
            // 
            this.gpoDadosLivro.Controls.Add(this.lblStatusLivro);
            this.gpoDadosLivro.Controls.Add(this.lblNome);
            this.gpoDadosLivro.Controls.Add(this.txtNomeLivro);
            this.gpoDadosLivro.Controls.Add(this.label11);
            this.gpoDadosLivro.Controls.Add(this.label1);
            this.gpoDadosLivro.Controls.Add(this.txtAutor);
            this.gpoDadosLivro.Controls.Add(this.txtValor);
            this.gpoDadosLivro.Controls.Add(this.label7);
            this.gpoDadosLivro.Controls.Add(this.label6);
            this.gpoDadosLivro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoDadosLivro.Location = new System.Drawing.Point(14, 61);
            this.gpoDadosLivro.Name = "gpoDadosLivro";
            this.gpoDadosLivro.Size = new System.Drawing.Size(550, 134);
            this.gpoDadosLivro.TabIndex = 333;
            this.gpoDadosLivro.TabStop = false;
            this.gpoDadosLivro.Text = "Dados do Livro";
            // 
            // lblStatusLivro
            // 
            this.lblStatusLivro.BackColor = System.Drawing.Color.Gray;
            this.lblStatusLivro.Location = new System.Drawing.Point(384, 93);
            this.lblStatusLivro.Name = "lblStatusLivro";
            this.lblStatusLivro.Size = new System.Drawing.Size(150, 26);
            this.lblStatusLivro.TabIndex = 331;
            this.lblStatusLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 306;
            this.label1.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAutor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.ForeColor = System.Drawing.Color.Black;
            this.txtAutor.Location = new System.Drawing.Point(12, 93);
            this.txtAutor.MaxLength = 50;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(359, 26);
            this.txtAutor.TabIndex = 305;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 336;
            this.label9.Text = "CPF do Cliente:";
            // 
            // gpoDadosCliente
            // 
            this.gpoDadosCliente.Controls.Add(this.lblStatusCliente);
            this.gpoDadosCliente.Controls.Add(this.label10);
            this.gpoDadosCliente.Controls.Add(this.txtNomeCliente);
            this.gpoDadosCliente.Controls.Add(this.label16);
            this.gpoDadosCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoDadosCliente.Location = new System.Drawing.Point(14, 236);
            this.gpoDadosCliente.Name = "gpoDadosCliente";
            this.gpoDadosCliente.Size = new System.Drawing.Size(550, 88);
            this.gpoDadosCliente.TabIndex = 334;
            this.gpoDadosCliente.TabStop = false;
            this.gpoDadosCliente.Text = "Dados do Cliente";
            // 
            // lblStatusCliente
            // 
            this.lblStatusCliente.BackColor = System.Drawing.Color.Gray;
            this.lblStatusCliente.Location = new System.Drawing.Point(390, 44);
            this.lblStatusCliente.Name = "lblStatusCliente";
            this.lblStatusCliente.Size = new System.Drawing.Size(150, 26);
            this.lblStatusCliente.TabIndex = 333;
            this.lblStatusCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(386, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 332;
            this.label10.Text = "Status";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCliente.Location = new System.Drawing.Point(17, 44);
            this.txtNomeCliente.MaxLength = 50;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(363, 26);
            this.txtNomeCliente.TabIndex = 224;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(15, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 20);
            this.label16.TabIndex = 238;
            this.label16.Text = "Nome";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(254, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 30);
            this.button2.TabIndex = 337;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.ForeColor = System.Drawing.Color.Black;
            this.mskCPF.Location = new System.Drawing.Point(122, 202);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(126, 26);
            this.mskCPF.TabIndex = 227;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 51);
            this.label2.TabIndex = 340;
            this.label2.Text = "CASO OCORRA ATRASO NA DEVOLUÇÃO SERÁ COBRADO MULTA E JUROS DIARIAMENTE OU CASO HA" +
    "JA PERCA OU DANO AO EXEMPLAR, SERÁ COBRADO O VALOR DO MESMO.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 82);
            this.groupBox1.TabIndex = 341;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 342;
            this.label3.Text = "Data de Empréstimo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 343;
            this.label4.Text = "Data de Devolução";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 351);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 20);
            this.dateTimePicker1.TabIndex = 344;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(257, 351);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(229, 20);
            this.dateTimePicker2.TabIndex = 345;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lblDias
            // 
            this.lblDias.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(502, 338);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(50, 42);
            this.lblDias.TabIndex = 346;
            this.lblDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 348;
            this.label5.Text = "Empréstimo Nº";
            // 
            // txtNumeroEmprestimo
            // 
            this.txtNumeroEmprestimo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroEmprestimo.Enabled = false;
            this.txtNumeroEmprestimo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroEmprestimo.ForeColor = System.Drawing.Color.Black;
            this.txtNumeroEmprestimo.Location = new System.Drawing.Point(12, 475);
            this.txtNumeroEmprestimo.MaxLength = 50;
            this.txtNumeroEmprestimo.Name = "txtNumeroEmprestimo";
            this.txtNumeroEmprestimo.Size = new System.Drawing.Size(151, 26);
            this.txtNumeroEmprestimo.TabIndex = 347;
            // 
            // frmEmprestar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(574, 509);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumeroEmprestimo);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gpoDadosCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gpoDadosLivro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtConsultarCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmprestar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Empréstimo";
            this.Load += new System.EventHandler(this.frmEmprestar_Load);
            this.gpoDadosLivro.ResumeLayout(false);
            this.gpoDadosLivro.PerformLayout();
            this.gpoDadosCliente.ResumeLayout(false);
            this.gpoDadosCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtConsultarCodigo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpoDadosLivro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gpoDadosCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblStatusLivro;
        private System.Windows.Forms.Label lblStatusCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroEmprestimo;
    }
}