namespace SistemaLojaCosmeticos
{
    partial class frmConsCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsCategoria));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.rbtContem = new System.Windows.Forms.RadioButton();
            this.rbtInicio = new System.Windows.Forms.RadioButton();
            this.textPesquisar = new System.Windows.Forms.TextBox();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.gbTipoPesquisa.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(this.btSair);
            this.groupBox1.Controls.Add(this.dgvCategoria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gbTipoPesquisa);
            this.groupBox1.Controls.Add(this.textPesquisar);
            this.groupBox1.Controls.Add(this.cbOpcoes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um tipo de pesquisa:";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.Location = new System.Drawing.Point(25, 100);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(94, 37);
            this.btPesquisar.TabIndex = 6;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.Location = new System.Drawing.Point(16, 324);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(94, 37);
            this.btEditar.TabIndex = 7;
            this.btEditar.Text = "Editar";
            this.btEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(442, 324);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(94, 37);
            this.btSair.TabIndex = 8;
            this.btSair.Text = "Sair";
            this.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AllowUserToResizeColumns = false;
            this.dgvCategoria.AllowUserToResizeRows = false;
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(16, 189);
            this.dgvCategoria.MultiSelect = false;
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersVisible = false;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(520, 129);
            this.dgvCategoria.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(22, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(509, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Para Atualizar ou Excluir uma Categoria selecione a Categoria e clique no botão e" +
    "ditar !!";
            // 
            // gbTipoPesquisa
            // 
            this.gbTipoPesquisa.Controls.Add(this.rbtContem);
            this.gbTipoPesquisa.Controls.Add(this.rbtInicio);
            this.gbTipoPesquisa.Location = new System.Drawing.Point(354, 21);
            this.gbTipoPesquisa.Name = "gbTipoPesquisa";
            this.gbTipoPesquisa.Size = new System.Drawing.Size(182, 52);
            this.gbTipoPesquisa.TabIndex = 2;
            this.gbTipoPesquisa.TabStop = false;
            this.gbTipoPesquisa.Text = "Tipo de pesquisa:";
            // 
            // rbtContem
            // 
            this.rbtContem.AutoSize = true;
            this.rbtContem.Location = new System.Drawing.Point(80, 21);
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
            this.rbtInicio.Location = new System.Drawing.Point(6, 21);
            this.rbtInicio.Name = "rbtInicio";
            this.rbtInicio.Size = new System.Drawing.Size(57, 20);
            this.rbtInicio.TabIndex = 0;
            this.rbtInicio.TabStop = true;
            this.rbtInicio.Text = "Início";
            this.rbtInicio.UseVisualStyleBackColor = true;
            // 
            // textPesquisar
            // 
            this.textPesquisar.Location = new System.Drawing.Point(164, 42);
            this.textPesquisar.MaxLength = 50;
            this.textPesquisar.Name = "textPesquisar";
            this.textPesquisar.Size = new System.Drawing.Size(171, 22);
            this.textPesquisar.TabIndex = 1;
            this.textPesquisar.TextChanged += new System.EventHandler(this.textPesquisar_TextChanged);
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Location = new System.Drawing.Point(16, 42);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(142, 24);
            this.cbOpcoes.TabIndex = 0;
            this.cbOpcoes.SelectedIndexChanged += new System.EventHandler(this.cbOpcoes_SelectedIndexChanged);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(336, 100);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(200, 53);
            this.gbStatus.TabIndex = 9;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(24, 22);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(56, 20);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(131, 27);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(65, 20);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // frmConsCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(577, 391);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmConsCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Categoria";
            this.Load += new System.EventHandler(this.frmConsCategoria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsCategoria_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.gbTipoPesquisa.ResumeLayout(false);
            this.gbTipoPesquisa.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.TextBox textPesquisar;
        private System.Windows.Forms.GroupBox gbTipoPesquisa;
        private System.Windows.Forms.RadioButton rbtInicio;
        private System.Windows.Forms.RadioButton rbtContem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
    }
}