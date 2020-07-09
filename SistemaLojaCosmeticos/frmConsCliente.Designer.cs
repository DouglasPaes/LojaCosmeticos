namespace SistemaLojaCosmeticos
{
    partial class frmConsCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbtInativo = new System.Windows.Forms.RadioButton();
            this.rbtAtivo = new System.Windows.Forms.RadioButton();
            this.gbTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.rbtContem = new System.Windows.Forms.RadioButton();
            this.rbtInicio = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.gbTipoPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btSair);
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(this.dgvCliente);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Controls.Add(this.gbTipoPesquisa);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.cbOpcoes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um tipo de pesquisa:";
            
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mskDataNascimento);
            this.groupBox3.Location = new System.Drawing.Point(207, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 59);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nascimento:";
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(32, 21);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(74, 22);
            this.mskDataNascimento.TabIndex = 0;
            this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
            
            this.mskDataNascimento.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mskDataNascimento_TypeValidationCompleted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskCpf);
            this.groupBox2.Location = new System.Drawing.Point(18, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 58);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPF:";
            
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(29, 23);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(100, 22);
            this.mskCpf.TabIndex = 0;
          
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(65, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Para Atualizar ou Excluir um Cliente selecione o Cliente e clique no botão editar" +
    " !!";
           
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(475, 362);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(94, 36);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "Sair";
            this.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.Location = new System.Drawing.Point(18, 362);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(94, 36);
            this.btEditar.TabIndex = 4;
            this.btEditar.Text = "Editar";
            this.btEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(18, 196);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(551, 160);
            this.dgvCliente.TabIndex = 3;
            
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.Location = new System.Drawing.Point(228, 141);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(94, 36);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbtInativo);
            this.gbStatus.Controls.Add(this.rbtAtivo);
            this.gbStatus.Location = new System.Drawing.Point(396, 76);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(173, 58);
            this.gbStatus.TabIndex = 3;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            
            // 
            // rbtInativo
            // 
            this.rbtInativo.AutoSize = true;
            this.rbtInativo.Location = new System.Drawing.Point(88, 23);
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
            this.rbtAtivo.Location = new System.Drawing.Point(14, 23);
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
            this.gbTipoPesquisa.Size = new System.Drawing.Size(173, 56);
            this.gbTipoPesquisa.TabIndex = 2;
            this.gbTipoPesquisa.TabStop = false;
            this.gbTipoPesquisa.Text = "Tipo de pesquisa:";
            
            // 
            // rbtContem
            // 
            this.rbtContem.AutoSize = true;
            this.rbtContem.Location = new System.Drawing.Point(88, 22);
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
            this.rbtInicio.Location = new System.Drawing.Point(13, 21);
            this.rbtInicio.Name = "rbtInicio";
            this.rbtInicio.Size = new System.Drawing.Size(57, 20);
            this.rbtInicio.TabIndex = 0;
            this.rbtInicio.TabStop = true;
            this.rbtInicio.Text = "Início";
            this.rbtInicio.UseVisualStyleBackColor = true;
            
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(174, 34);
            this.txtPesquisar.MaxLength = 50;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(216, 22);
            this.txtPesquisar.TabIndex = 1;
            
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Location = new System.Drawing.Point(15, 32);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(153, 24);
            this.cbOpcoes.TabIndex = 0;
            this.cbOpcoes.SelectedIndexChanged += new System.EventHandler(this.cbOpcoes_SelectedIndexChanged);
            // 
            // frmConsCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(614, 428);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmConsCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cliente";
            this.Load += new System.EventHandler(this.frmConsCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsCliente_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbTipoPesquisa.ResumeLayout(false);
            this.gbTipoPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbTipoPesquisa;
        private System.Windows.Forms.RadioButton rbtContem;
        private System.Windows.Forms.RadioButton rbtInicio;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbtInativo;
        private System.Windows.Forms.RadioButton rbtAtivo;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}