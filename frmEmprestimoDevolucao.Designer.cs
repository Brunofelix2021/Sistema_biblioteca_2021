namespace BibliotecaProjeto
{
    partial class frmEmprestimoDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmprestimoDevolucao));
            this.grdLivros = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConsultarCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsultarEmprestimo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboExibir = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtConsultarCPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLivros
            // 
            this.grdLivros.AllowUserToAddRows = false;
            this.grdLivros.AllowUserToDeleteRows = false;
            this.grdLivros.AllowUserToResizeColumns = false;
            this.grdLivros.AllowUserToResizeRows = false;
            this.grdLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLivros.Location = new System.Drawing.Point(12, 64);
            this.grdLivros.MultiSelect = false;
            this.grdLivros.Name = "grdLivros";
            this.grdLivros.ReadOnly = true;
            this.grdLivros.RowHeadersVisible = false;
            this.grdLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLivros.Size = new System.Drawing.Size(1450, 399);
            this.grdLivros.TabIndex = 290;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(203, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 301;
            this.label8.Text = "Código do Livro";
            // 
            // txtConsultarCodigo
            // 
            this.txtConsultarCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsultarCodigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtConsultarCodigo.Location = new System.Drawing.Point(205, 34);
            this.txtConsultarCodigo.MaxLength = 50;
            this.txtConsultarCodigo.Name = "txtConsultarCodigo";
            this.txtConsultarCodigo.Size = new System.Drawing.Size(165, 26);
            this.txtConsultarCodigo.TabIndex = 298;
            this.txtConsultarCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultarCodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 309;
            this.label2.Text = "CPF";
            // 
            // txtConsultarEmprestimo
            // 
            this.txtConsultarEmprestimo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsultarEmprestimo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarEmprestimo.ForeColor = System.Drawing.Color.Black;
            this.txtConsultarEmprestimo.Location = new System.Drawing.Point(12, 34);
            this.txtConsultarEmprestimo.MaxLength = 50;
            this.txtConsultarEmprestimo.Name = "txtConsultarEmprestimo";
            this.txtConsultarEmprestimo.Size = new System.Drawing.Size(151, 26);
            this.txtConsultarEmprestimo.TabIndex = 310;
            this.txtConsultarEmprestimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 311;
            this.label1.Text = "Empréstimo Nº";
            // 
            // cboExibir
            // 
            this.cboExibir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboExibir.FormattingEnabled = true;
            this.cboExibir.Location = new System.Drawing.Point(1310, 30);
            this.cboExibir.Name = "cboExibir";
            this.cboExibir.Size = new System.Drawing.Size(152, 28);
            this.cboExibir.TabIndex = 312;
            this.cboExibir.SelectedIndexChanged += new System.EventHandler(this.cboExibir_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1306, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 313;
            this.label3.Text = "Exibir...";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(576, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 30);
            this.button1.TabIndex = 333;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 334;
            this.label4.Text = "ou";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 335;
            this.label5.Text = "ou";
            // 
            // btnDevolver
            // 
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevolver.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.Image = global::BibliotecaProjeto.Properties.Resources.check;
            this.btnDevolver.Location = new System.Drawing.Point(1098, 469);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(167, 41);
            this.btnDevolver.TabIndex = 316;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::BibliotecaProjeto.Properties.Resources.delete;
            this.btnSair.Location = new System.Drawing.Point(1295, 469);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(167, 41);
            this.btnSair.TabIndex = 315;
            this.btnSair.Text = "Cancelar";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtConsultarCPF
            // 
            this.txtConsultarCPF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarCPF.ForeColor = System.Drawing.Color.Black;
            this.txtConsultarCPF.Location = new System.Drawing.Point(409, 32);
            this.txtConsultarCPF.Mask = "000.000.000-00";
            this.txtConsultarCPF.Name = "txtConsultarCPF";
            this.txtConsultarCPF.Size = new System.Drawing.Size(129, 26);
            this.txtConsultarCPF.TabIndex = 336;
            // 
            // frmEmprestimoDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 518);
            this.Controls.Add(this.txtConsultarCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboExibir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsultarEmprestimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtConsultarCodigo);
            this.Controls.Add(this.grdLivros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmprestimoDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empréstimos e Devoluções";
            this.Load += new System.EventHandler(this.frmEmprestimoDevolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdLivros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConsultarCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsultarEmprestimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboExibir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtConsultarCPF;
    }
}