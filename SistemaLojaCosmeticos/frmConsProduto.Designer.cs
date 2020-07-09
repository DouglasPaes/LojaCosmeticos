namespace SistemaLojaCosmeticos
{
    partial class frmConsProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.rdInativo = new System.Windows.Forms.RadioButton();
            this.rdInicio = new System.Windows.Forms.RadioButton();
            this.rdContem = new System.Windows.Forms.RadioButton();
            this.dgColunas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecoInicial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecoFinal = new System.Windows.Forms.TextBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.gbTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.gbValores = new System.Windows.Forms.GroupBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgColunas)).BeginInit();
            this.gbTipoPesquisa.SuspendLayout();
            this.gbValores.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione um Tipo de Consulta:";
            // 
            // cbConsulta
            // 
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Location = new System.Drawing.Point(30, 48);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(121, 21);
            this.cbConsulta.TabIndex = 1;
            this.cbConsulta.SelectedIndexChanged += new System.EventHandler(this.cbConsulta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valores:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(173, 48);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(187, 22);
            this.txtPesquisar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Pesquisa ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Categoria";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(89, 196);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 21);
            this.cbMarca.TabIndex = 7;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(327, 197);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 8;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Location = new System.Drawing.Point(514, 196);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(96, 30);
            this.btPesquisar.TabIndex = 9;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(466, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status";
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(6, 19);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 11;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdInativo
            // 
            this.rdInativo.AutoSize = true;
            this.rdInativo.Location = new System.Drawing.Point(112, 19);
            this.rdInativo.Name = "rdInativo";
            this.rdInativo.Size = new System.Drawing.Size(57, 17);
            this.rdInativo.TabIndex = 12;
            this.rdInativo.TabStop = true;
            this.rdInativo.Text = "Inativo";
            this.rdInativo.UseVisualStyleBackColor = true;
            // 
            // rdInicio
            // 
            this.rdInicio.AutoSize = true;
            this.rdInicio.Location = new System.Drawing.Point(25, 19);
            this.rdInicio.Name = "rdInicio";
            this.rdInicio.Size = new System.Drawing.Size(52, 17);
            this.rdInicio.TabIndex = 13;
            this.rdInicio.TabStop = true;
            this.rdInicio.Text = "Início";
            this.rdInicio.UseVisualStyleBackColor = true;
            // 
            // rdContem
            // 
            this.rdContem.AutoSize = true;
            this.rdContem.Location = new System.Drawing.Point(108, 22);
            this.rdContem.Name = "rdContem";
            this.rdContem.Size = new System.Drawing.Size(61, 17);
            this.rdContem.TabIndex = 14;
            this.rdContem.TabStop = true;
            this.rdContem.Text = "Contém";
            this.rdContem.UseVisualStyleBackColor = true;
            // 
            // dgColunas
            // 
            this.dgColunas.AllowUserToAddRows = false;
            this.dgColunas.AllowUserToDeleteRows = false;
            this.dgColunas.AllowUserToResizeColumns = false;
            this.dgColunas.AllowUserToResizeRows = false;
            this.dgColunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgColunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgColunas.Location = new System.Drawing.Point(64, 253);
            this.dgColunas.MultiSelect = false;
            this.dgColunas.Name = "dgColunas";
            this.dgColunas.ReadOnly = true;
            this.dgColunas.RowHeadersVisible = false;
            this.dgColunas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgColunas.Size = new System.Drawing.Size(527, 150);
            this.dgColunas.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Preço Inicial:";
            // 
            // txtPrecoInicial
            // 
            this.txtPrecoInicial.Location = new System.Drawing.Point(93, 19);
            this.txtPrecoInicial.Name = "txtPrecoInicial";
            this.txtPrecoInicial.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoInicial.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(199, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Preço Final:";
            // 
            // txtPrecoFinal
            // 
            this.txtPrecoFinal.Location = new System.Drawing.Point(282, 19);
            this.txtPrecoFinal.Name = "txtPrecoFinal";
            this.txtPrecoFinal.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoFinal.TabIndex = 19;
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditar.Location = new System.Drawing.Point(21, 409);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(88, 33);
            this.btEditar.TabIndex = 20;
            this.btEditar.Text = "Editar";
            this.btEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(549, 415);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(73, 27);
            this.btSair.TabIndex = 21;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(76, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(501, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Para Atualizar ou Excluir um Produto selecione o Produto e cllique no botão Edita" +
    "r!!!";
            // 
            // gbTipoPesquisa
            // 
            this.gbTipoPesquisa.Controls.Add(this.rdInicio);
            this.gbTipoPesquisa.Controls.Add(this.rdContem);
            this.gbTipoPesquisa.Location = new System.Drawing.Point(441, 38);
            this.gbTipoPesquisa.Name = "gbTipoPesquisa";
            this.gbTipoPesquisa.Size = new System.Drawing.Size(193, 45);
            this.gbTipoPesquisa.TabIndex = 23;
            this.gbTipoPesquisa.TabStop = false;
            // 
            // gbValores
            // 
            this.gbValores.Controls.Add(this.txtPrecoInicial);
            this.gbValores.Controls.Add(this.label7);
            this.gbValores.Controls.Add(this.label8);
            this.gbValores.Controls.Add(this.txtPrecoFinal);
            this.gbValores.Location = new System.Drawing.Point(15, 140);
            this.gbValores.Name = "gbValores";
            this.gbValores.Size = new System.Drawing.Size(388, 50);
            this.gbValores.TabIndex = 24;
            this.gbValores.TabStop = false;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Controls.Add(this.rdInativo);
            this.gbStatus.Location = new System.Drawing.Point(441, 115);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(200, 45);
            this.gbStatus.TabIndex = 25;
            this.gbStatus.TabStop = false;
            // 
            // frmConsProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 458);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbValores);
            this.Controls.Add(this.gbTipoPesquisa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.dgColunas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbConsulta);
            this.Controls.Add(this.label1);
            this.Name = "frmConsProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Produtos";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgColunas)).EndInit();
            this.gbTipoPesquisa.ResumeLayout(false);
            this.gbTipoPesquisa.PerformLayout();
            this.gbValores.ResumeLayout(false);
            this.gbValores.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.RadioButton rdInativo;
        private System.Windows.Forms.RadioButton rdInicio;
        private System.Windows.Forms.RadioButton rdContem;
        private System.Windows.Forms.DataGridView dgColunas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecoInicial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecoFinal;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbTipoPesquisa;
        private System.Windows.Forms.GroupBox gbValores;
        private System.Windows.Forms.GroupBox gbStatus;
    }
}