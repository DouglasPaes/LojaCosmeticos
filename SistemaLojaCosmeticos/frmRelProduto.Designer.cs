namespace SistemaLojaCosmeticos
{
    partial class frmRelProduto
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.rptProduto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbtInativo = new System.Windows.Forms.RadioButton();
            this.rbtAtivo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textQtdeEstoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPreco = new System.Windows.Forms.TextBox();
            this.classProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o Tipo de Relatório:";
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(249, 12);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(188, 24);
            this.cbTipoRel.TabIndex = 2;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.Location = new System.Drawing.Point(534, 5);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(132, 36);
            this.btGerarRelatorio.TabIndex = 3;
            this.btGerarRelatorio.Text = "Gerar Relatório";
            this.btGerarRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(534, 47);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(132, 24);
            this.cbCategoria.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Marca:";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(534, 77);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(132, 24);
            this.cbMarca.TabIndex = 11;
            // 
            // rptProduto
            // 
            reportDataSource1.Name = "DataSetProduto";
            reportDataSource1.Value = this.classProdutoBindingSource;
            this.rptProduto.LocalReport.DataSources.Add(reportDataSource1);
            this.rptProduto.LocalReport.ReportEmbeddedResource = "SistemaLojaCosmeticos.rptProduto.rdlc";
            this.rptProduto.Location = new System.Drawing.Point(8, 107);
            this.rptProduto.Name = "rptProduto";
            this.rptProduto.Size = new System.Drawing.Size(658, 304);
            this.rptProduto.TabIndex = 12;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbtInativo);
            this.gbStatus.Controls.Add(this.rbtAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(300, 42);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(152, 59);
            this.gbStatus.TabIndex = 13;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbtInativo
            // 
            this.rbtInativo.AutoSize = true;
            this.rbtInativo.Location = new System.Drawing.Point(71, 25);
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
            this.rbtAtivo.Location = new System.Drawing.Point(6, 25);
            this.rbtAtivo.Name = "rbtAtivo";
            this.rbtAtivo.Size = new System.Drawing.Size(56, 20);
            this.rbtAtivo.TabIndex = 0;
            this.rbtAtivo.TabStop = true;
            this.rbtAtivo.Text = "Ativo";
            this.rbtAtivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Qtde Estoque:";
            // 
            // textQtdeEstoque
            // 
            this.textQtdeEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQtdeEstoque.Location = new System.Drawing.Point(111, 65);
            this.textQtdeEstoque.Name = "textQtdeEstoque";
            this.textQtdeEstoque.Size = new System.Drawing.Size(57, 22);
            this.textQtdeEstoque.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Preço:";
            // 
            // textPreco
            // 
            this.textPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPreco.Location = new System.Drawing.Point(227, 65);
            this.textPreco.Name = "textPreco";
            this.textPreco.Size = new System.Drawing.Size(57, 22);
            this.textPreco.TabIndex = 17;
            this.textPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPreco_KeyPress);
            // 
            // classProdutoBindingSource
            // 
            this.classProdutoBindingSource.DataSource = typeof(SistemaLojaCosmeticos.classProduto);
            // 
            // frmRelProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(683, 423);
            this.Controls.Add(this.textPreco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textQtdeEstoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.rptProduto);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRelProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Produto";
            this.Load += new System.EventHandler(this.frmRelProduto_Load);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMarca;
        private Microsoft.Reporting.WinForms.ReportViewer rptProduto;
        private System.Windows.Forms.BindingSource classProdutoBindingSource;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbtInativo;
        private System.Windows.Forms.RadioButton rbtAtivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textQtdeEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPreco;
    }
}