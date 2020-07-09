namespace SistemaLojaCosmeticos
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textObservacao = new System.Windows.Forms.TextBox();
            this.lbObservacao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckStatus = new System.Windows.Forms.CheckBox();
            this.textNomeCategoria = new System.Windows.Forms.TextBox();
            this.lbNomeCategoria = new System.Windows.Forms.Label();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCadastar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(161, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(190, 20);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cadastro de Categoria";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbData);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textObservacao);
            this.groupBox1.Controls.Add(this.lbObservacao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ckStatus);
            this.groupBox1.Controls.Add(this.textNomeCategoria);
            this.groupBox1.Controls.Add(this.lbNomeCategoria);
            this.groupBox1.Controls.Add(this.textCategoria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(480, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ativo";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(337, 25);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(33, 15);
            this.lbData.TabIndex = 10;
            this.lbData.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "*Data cadastro:";
            // 
            // textObservacao
            // 
            this.textObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textObservacao.Location = new System.Drawing.Point(18, 98);
            this.textObservacao.MaxLength = 150;
            this.textObservacao.Multiline = true;
            this.textObservacao.Name = "textObservacao";
            this.textObservacao.Size = new System.Drawing.Size(494, 67);
            this.textObservacao.TabIndex = 1;
            // 
            // lbObservacao
            // 
            this.lbObservacao.AutoSize = true;
            this.lbObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObservacao.Location = new System.Drawing.Point(15, 79);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(86, 16);
            this.lbObservacao.TabIndex = 6;
            this.lbObservacao.Text = "Observação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "*Status:";
            // 
            // ckStatus
            // 
            this.ckStatus.AutoSize = true;
            this.ckStatus.Checked = true;
            this.ckStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckStatus.Enabled = false;
            this.ckStatus.Location = new System.Drawing.Point(465, 28);
            this.ckStatus.Name = "ckStatus";
            this.ckStatus.Size = new System.Drawing.Size(15, 14);
            this.ckStatus.TabIndex = 4;
            this.ckStatus.UseVisualStyleBackColor = true;
            // 
            // textNomeCategoria
            // 
            this.textNomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeCategoria.Location = new System.Drawing.Point(169, 52);
            this.textNomeCategoria.MaxLength = 50;
            this.textNomeCategoria.Name = "textNomeCategoria";
            this.textNomeCategoria.Size = new System.Drawing.Size(343, 21);
            this.textNomeCategoria.TabIndex = 0;
            // 
            // lbNomeCategoria
            // 
            this.lbNomeCategoria.AutoSize = true;
            this.lbNomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCategoria.Location = new System.Drawing.Point(15, 55);
            this.lbNomeCategoria.Name = "lbNomeCategoria";
            this.lbNomeCategoria.Size = new System.Drawing.Size(141, 15);
            this.lbNomeCategoria.TabIndex = 2;
            this.lbNomeCategoria.Text = "*Nome da Categoria:";
            // 
            // textCategoria
            // 
            this.textCategoria.Enabled = false;
            this.textCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCategoria.Location = new System.Drawing.Point(169, 23);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(58, 21);
            this.textCategoria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Código da Categoria:";
            // 
            // btCadastar
            // 
            this.btCadastar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastar.Image = ((System.Drawing.Image)(resources.GetObject("btCadastar.Image")));
            this.btCadastar.Location = new System.Drawing.Point(30, 228);
            this.btCadastar.Name = "btCadastar";
            this.btCadastar.Size = new System.Drawing.Size(94, 34);
            this.btCadastar.TabIndex = 2;
            this.btCadastar.Text = "Cadastrar";
            this.btCadastar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCadastar.UseVisualStyleBackColor = true;
            this.btCadastar.Click += new System.EventHandler(this.btCadastar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btAtualizar.Image")));
            this.btAtualizar.Location = new System.Drawing.Point(130, 228);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(94, 34);
            this.btAtualizar.TabIndex = 3;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.Location = new System.Drawing.Point(230, 228);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(94, 34);
            this.btExcluir.TabIndex = 4;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpar.Image")));
            this.btLimpar.Location = new System.Drawing.Point(330, 228);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(94, 34);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(430, 228);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(94, 34);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Sair";
            this.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(549, 281);
            this.ControlBox = false;
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCadastar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Categoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCategoria_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNomeCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbObservacao;
        private System.Windows.Forms.Button btCadastar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textCategoria;
        public System.Windows.Forms.TextBox textNomeCategoria;
        public System.Windows.Forms.CheckBox ckStatus;
        public System.Windows.Forms.TextBox textObservacao;
        public System.Windows.Forms.Label lbData;
    }
}