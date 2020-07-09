namespace SistemaLojaCosmeticos
{
    partial class frmConsCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsCargo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSair = new System.Windows.Forms.Button();
            this.dgvCargo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCodigoCargo = new System.Windows.Forms.TextBox();
            this.gbTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.rbtContem = new System.Windows.Forms.RadioButton();
            this.rbtInicio = new System.Windows.Forms.RadioButton();
            this.textPesquisar = new System.Windows.Forms.TextBox();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbTipoPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSair);
            this.groupBox1.Controls.Add(this.dgvCargo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.gbTipoPesquisa);
            this.groupBox1.Controls.Add(this.textPesquisar);
            this.groupBox1.Controls.Add(this.cbOpcoes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um tipo de pesquisa:";
            
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(444, 325);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 36);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Sair";
            this.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // dgvCargo
            // 
            this.dgvCargo.AllowUserToAddRows = false;
            this.dgvCargo.AllowUserToDeleteRows = false;
            this.dgvCargo.AllowUserToResizeColumns = false;
            this.dgvCargo.AllowUserToResizeRows = false;
            this.dgvCargo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCargo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargo.Location = new System.Drawing.Point(16, 198);
            this.dgvCargo.MultiSelect = false;
            this.dgvCargo.Name = "dgvCargo";
            this.dgvCargo.ReadOnly = true;
            this.dgvCargo.RowHeadersVisible = false;
            this.dgvCargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargo.Size = new System.Drawing.Size(526, 121);
            this.dgvCargo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(47, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Para Atualizar ou Excluir um Cargo selecione o Cargo e clique no botão editar !!";
           
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.Location = new System.Drawing.Point(16, 325);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(98, 36);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "Editar";
            this.btEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.Location = new System.Drawing.Point(226, 143);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(98, 36);
            this.btPesquisar.TabIndex = 7;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(375, 82);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(167, 55);
            this.gbStatus.TabIndex = 6;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(88, 23);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(65, 20);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(18, 23);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(56, 20);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textCodigoCargo);
            this.groupBox3.Location = new System.Drawing.Point(16, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 54);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código do Cargo:";
            // 
            // textCodigoCargo
            // 
            this.textCodigoCargo.Location = new System.Drawing.Point(137, 21);
            this.textCodigoCargo.Name = "textCodigoCargo";
            this.textCodigoCargo.Size = new System.Drawing.Size(193, 22);
            this.textCodigoCargo.TabIndex = 0;
            // 
            // gbTipoPesquisa
            // 
            this.gbTipoPesquisa.Controls.Add(this.rbtContem);
            this.gbTipoPesquisa.Controls.Add(this.rbtInicio);
            this.gbTipoPesquisa.Location = new System.Drawing.Point(375, 21);
            this.gbTipoPesquisa.Name = "gbTipoPesquisa";
            this.gbTipoPesquisa.Size = new System.Drawing.Size(167, 55);
            this.gbTipoPesquisa.TabIndex = 2;
            this.gbTipoPesquisa.TabStop = false;
            this.gbTipoPesquisa.Text = "Tipo de pesquisa:";
            // 
            // rbtContem
            // 
            this.rbtContem.AutoSize = true;
            this.rbtContem.Location = new System.Drawing.Point(81, 23);
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
            this.rbtInicio.Location = new System.Drawing.Point(18, 23);
            this.rbtInicio.Name = "rbtInicio";
            this.rbtInicio.Size = new System.Drawing.Size(57, 20);
            this.rbtInicio.TabIndex = 0;
            this.rbtInicio.TabStop = true;
            this.rbtInicio.Text = "Início";
            this.rbtInicio.UseVisualStyleBackColor = true;
            // 
            // textPesquisar
            // 
            this.textPesquisar.Location = new System.Drawing.Point(153, 43);
            this.textPesquisar.MaxLength = 50;
            this.textPesquisar.Name = "textPesquisar";
            this.textPesquisar.Size = new System.Drawing.Size(193, 22);
            this.textPesquisar.TabIndex = 1;
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Location = new System.Drawing.Point(16, 43);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(120, 24);
            this.cbOpcoes.TabIndex = 0;
            this.cbOpcoes.SelectedIndexChanged += new System.EventHandler(this.cbOpcoes_SelectedIndexChanged);
            // 
            // frmConsCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(585, 384);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmConsCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cargo";
            this.Load += new System.EventHandler(this.frmConsCargo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsCargo_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbTipoPesquisa.ResumeLayout(false);
            this.gbTipoPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.TextBox textPesquisar;
        private System.Windows.Forms.GroupBox gbTipoPesquisa;
        private System.Windows.Forms.RadioButton rbtContem;
        private System.Windows.Forms.RadioButton rbtInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCodigoCargo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCargo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btEditar;
    }
}