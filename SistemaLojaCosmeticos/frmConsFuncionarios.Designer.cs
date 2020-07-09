namespace SistemaLojaCosmeticos
{
    partial class frmConsFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsFuncionarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbtInativo = new System.Windows.Forms.RadioButton();
            this.rbtAtivo = new System.Windows.Forms.RadioButton();
            this.gbTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.rbtContem = new System.Windows.Forms.RadioButton();
            this.rbtInicio = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbTipoPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCargo);
            this.groupBox1.Controls.Add(this.btSair);
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.dgvFuncionario);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Controls.Add(this.gbTipoPesquisa);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.cbOpcoes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um tipo de pesquisa:";
         
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cargo:";
            // 
            // cbCargo
            // 
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(67, 154);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(141, 24);
            this.cbCargo.TabIndex = 2;
          
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(479, 368);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(96, 36);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Sair";
            this.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.Location = new System.Drawing.Point(16, 368);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(96, 36);
            this.btEditar.TabIndex = 5;
            this.btEditar.Text = "Editar";
            this.btEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Para Atualizar ou Excluir um Funcionário selecione o Funcionário e clique no botã" +
    "o editar !!";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.Location = new System.Drawing.Point(260, 147);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(96, 36);
            this.btPesquisar.TabIndex = 3;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.AllowUserToResizeColumns = false;
            this.dgvFuncionario.AllowUserToResizeRows = false;
            this.dgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(16, 212);
            this.dgvFuncionario.MultiSelect = false;
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.RowHeadersVisible = false;
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(559, 150);
            this.dgvFuncionario.TabIndex = 4;
          
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.mskDataNascimento);
            this.groupBox5.Location = new System.Drawing.Point(201, 82);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(155, 59);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nascimento:";
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(37, 21);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(75, 22);
            this.mskDataNascimento.TabIndex = 0;
            this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
            this.mskDataNascimento.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mskDataNascimento_TypeValidationCompleted);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mskCpf);
            this.groupBox4.Location = new System.Drawing.Point(16, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 59);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CPF:";
         
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(25, 21);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(100, 22);
            this.mskCpf.TabIndex = 0;
           
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbtInativo);
            this.gbStatus.Controls.Add(this.rbtAtivo);
            this.gbStatus.Location = new System.Drawing.Point(396, 82);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(179, 59);
            this.gbStatus.TabIndex = 3;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
           
            // 
            // rbtInativo
            // 
            this.rbtInativo.AutoSize = true;
            this.rbtInativo.Location = new System.Drawing.Point(92, 21);
            this.rbtInativo.Name = "rbtInativo";
            this.rbtInativo.Size = new System.Drawing.Size(65, 20);
            this.rbtInativo.TabIndex = 1;
            this.rbtInativo.TabStop = true;
            this.rbtInativo.Text = "Inativo";
            this.rbtInativo.UseVisualStyleBackColor = true;
            // 
            // rbtAtivo
            // 
            this.rbtAtivo.AutoSize = true;
            this.rbtAtivo.Location = new System.Drawing.Point(16, 21);
            this.rbtAtivo.Name = "rbtAtivo";
            this.rbtAtivo.Size = new System.Drawing.Size(56, 20);
            this.rbtAtivo.TabIndex = 0;
            this.rbtAtivo.TabStop = true;
            this.rbtAtivo.Text = "Ativo";
            this.rbtAtivo.UseVisualStyleBackColor = true;
            
            // 
            // gbTipoPesquisa
            // 
            this.gbTipoPesquisa.Controls.Add(this.rbtContem);
            this.gbTipoPesquisa.Controls.Add(this.rbtInicio);
            this.gbTipoPesquisa.Location = new System.Drawing.Point(396, 14);
            this.gbTipoPesquisa.Name = "gbTipoPesquisa";
            this.gbTipoPesquisa.Size = new System.Drawing.Size(179, 62);
            this.gbTipoPesquisa.TabIndex = 2;
            this.gbTipoPesquisa.TabStop = false;
            this.gbTipoPesquisa.Text = "Tipo de pesquisa:";
            // 
            // rbtContem
            // 
            this.rbtContem.AutoSize = true;
            this.rbtContem.Location = new System.Drawing.Point(92, 21);
            this.rbtContem.Name = "rbtContem";
            this.rbtContem.Size = new System.Drawing.Size(72, 20);
            this.rbtContem.TabIndex = 1;
            this.rbtContem.TabStop = true;
            this.rbtContem.Text = "Contém";
            this.rbtContem.UseVisualStyleBackColor = true;
          
            // 
            // rbtInicio
            // 
            this.rbtInicio.AutoSize = true;
            this.rbtInicio.Location = new System.Drawing.Point(15, 21);
            this.rbtInicio.Name = "rbtInicio";
            this.rbtInicio.Size = new System.Drawing.Size(57, 20);
            this.rbtInicio.TabIndex = 0;
            this.rbtInicio.TabStop = true;
            this.rbtInicio.Text = "Início";
            this.rbtInicio.UseVisualStyleBackColor = true;
            
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(171, 35);
            this.txtPesquisar.MaxLength = 50;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(208, 22);
            this.txtPesquisar.TabIndex = 1;
            
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Location = new System.Drawing.Point(16, 33);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(141, 24);
            this.cbOpcoes.TabIndex = 0;
            this.cbOpcoes.SelectedIndexChanged += new System.EventHandler(this.cbOpcoes_SelectedIndexChanged);
            // 
            // frmConsFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(618, 440);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmConsFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Funcionários";
            this.Load += new System.EventHandler(this.frmConsFuncionarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsFuncionarios_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbTipoPesquisa.ResumeLayout(false);
            this.gbTipoPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.GroupBox gbTipoPesquisa;
        private System.Windows.Forms.RadioButton rbtContem;
        private System.Windows.Forms.RadioButton rbtInicio;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbtAtivo;
        private System.Windows.Forms.RadioButton rbtInativo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label2;
    }
}