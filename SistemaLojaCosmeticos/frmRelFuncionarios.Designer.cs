namespace SistemaLojaCosmeticos
{
    partial class frmRelFuncionarios
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
            this.classFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.gbAniversariantes = new System.Windows.Forms.GroupBox();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbIdade = new System.Windows.Forms.GroupBox();
            this.txtAte = new System.Windows.Forms.TextBox();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbIdadeMaior = new System.Windows.Forms.GroupBox();
            this.txtMaiores = new System.Windows.Forms.TextBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbdInativo = new System.Windows.Forms.RadioButton();
            this.rbdAtivo = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.rptFuncionarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classFuncionarioBindingSource)).BeginInit();
            this.gbAniversariantes.SuspendLayout();
            this.gbIdade.SuspendLayout();
            this.gbIdadeMaior.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // classFuncionarioBindingSource
            // 
            this.classFuncionarioBindingSource.DataSource = typeof(SistemaLojaCosmeticos.classFuncionario);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o tipo de relatório";
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(292, 21);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(228, 21);
            this.cbTipoRel.TabIndex = 2;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.Location = new System.Drawing.Point(580, 21);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(128, 39);
            this.btGerarRelatorio.TabIndex = 12;
            this.btGerarRelatorio.Text = "Gerar Relatório";
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // gbAniversariantes
            // 
            this.gbAniversariantes.Controls.Add(this.dtpFinal);
            this.gbAniversariantes.Controls.Add(this.dtpInicial);
            this.gbAniversariantes.Controls.Add(this.label5);
            this.gbAniversariantes.Controls.Add(this.label4);
            this.gbAniversariantes.Controls.Add(this.cbMes);
            this.gbAniversariantes.Controls.Add(this.label3);
            this.gbAniversariantes.Controls.Add(this.cbDia);
            this.gbAniversariantes.Controls.Add(this.label2);
            this.gbAniversariantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAniversariantes.Location = new System.Drawing.Point(32, 66);
            this.gbAniversariantes.Name = "gbAniversariantes";
            this.gbAniversariantes.Size = new System.Drawing.Size(607, 72);
            this.gbAniversariantes.TabIndex = 13;
            this.gbAniversariantes.TabStop = false;
            this.gbAniversariantes.Text = "Aniversariantes";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(504, 22);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(97, 22);
            this.dtpFinal.TabIndex = 7;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(346, 26);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(107, 22);
            this.dtpInicial.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Até";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "De";
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(184, 25);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(77, 24);
            this.cbMes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mês";
            // 
            // cbDia
            // 
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Location = new System.Drawing.Point(49, 28);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(75, 24);
            this.cbDia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dia";
            // 
            // gbIdade
            // 
            this.gbIdade.Controls.Add(this.txtAte);
            this.gbIdade.Controls.Add(this.txtDe);
            this.gbIdade.Controls.Add(this.label7);
            this.gbIdade.Controls.Add(this.label6);
            this.gbIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdade.Location = new System.Drawing.Point(16, 157);
            this.gbIdade.Name = "gbIdade";
            this.gbIdade.Size = new System.Drawing.Size(238, 74);
            this.gbIdade.TabIndex = 14;
            this.gbIdade.TabStop = false;
            this.gbIdade.Text = "Idade";
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(159, 33);
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(62, 22);
            this.txtAte.TabIndex = 3;
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(42, 33);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(54, 22);
            this.txtDe.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Até";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "De";
            // 
            // gbIdadeMaior
            // 
            this.gbIdadeMaior.Controls.Add(this.txtMaiores);
            this.gbIdadeMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdadeMaior.Location = new System.Drawing.Point(301, 157);
            this.gbIdadeMaior.Name = "gbIdadeMaior";
            this.gbIdadeMaior.Size = new System.Drawing.Size(142, 74);
            this.gbIdadeMaior.TabIndex = 15;
            this.gbIdadeMaior.TabStop = false;
            this.gbIdadeMaior.Text = "Maiores";
            // 
            // txtMaiores
            // 
            this.txtMaiores.Location = new System.Drawing.Point(19, 30);
            this.txtMaiores.Name = "txtMaiores";
            this.txtMaiores.Size = new System.Drawing.Size(100, 22);
            this.txtMaiores.TabIndex = 0;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbdInativo);
            this.gbStatus.Controls.Add(this.rbdAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(498, 161);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(141, 70);
            this.gbStatus.TabIndex = 16;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbdInativo
            // 
            this.rbdInativo.AutoSize = true;
            this.rbdInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdInativo.Location = new System.Drawing.Point(67, 33);
            this.rbdInativo.Name = "rbdInativo";
            this.rbdInativo.Size = new System.Drawing.Size(64, 17);
            this.rbdInativo.TabIndex = 1;
            this.rbdInativo.TabStop = true;
            this.rbdInativo.Text = "Inativo";
            this.rbdInativo.UseVisualStyleBackColor = true;
            // 
            // rbdAtivo
            // 
            this.rbdAtivo.AutoSize = true;
            this.rbdAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdAtivo.Location = new System.Drawing.Point(7, 33);
            this.rbdAtivo.Name = "rbdAtivo";
            this.rbdAtivo.Size = new System.Drawing.Size(54, 17);
            this.rbdAtivo.TabIndex = 0;
            this.rbdAtivo.TabStop = true;
            this.rbdAtivo.Text = "Ativo";
            this.rbdAtivo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sexo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(185, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cidade";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(81, 242);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(80, 21);
            this.cbSexo.TabIndex = 19;
            // 
            // cbCidade
            // 
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(243, 241);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(99, 21);
            this.cbCidade.TabIndex = 20;
            // 
            // rptFuncionarios
            // 
            reportDataSource1.Name = "DataSetFuncionario";
            reportDataSource1.Value = this.classFuncionarioBindingSource;
            this.rptFuncionarios.LocalReport.DataSources.Add(reportDataSource1);
            this.rptFuncionarios.LocalReport.ReportEmbeddedResource = "SistemaLojaCosmeticos.rptFuncionario.rdlc";
            this.rptFuncionarios.Location = new System.Drawing.Point(27, 286);
            this.rptFuncionarios.Name = "rptFuncionarios";
            this.rptFuncionarios.Size = new System.Drawing.Size(686, 246);
            this.rptFuncionarios.TabIndex = 21;
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(472, 243);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(121, 21);
            this.cbCargo.TabIndex = 22;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(408, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Cargo";
            // 
            // frmRelFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(737, 544);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.rptFuncionarios);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbIdadeMaior);
            this.Controls.Add(this.gbIdade);
            this.Controls.Add(this.gbAniversariantes);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.label1);
            this.Name = "frmRelFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelFuncionarios";
            this.Load += new System.EventHandler(this.frmRelFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classFuncionarioBindingSource)).EndInit();
            this.gbAniversariantes.ResumeLayout(false);
            this.gbAniversariantes.PerformLayout();
            this.gbIdade.ResumeLayout(false);
            this.gbIdade.PerformLayout();
            this.gbIdadeMaior.ResumeLayout(false);
            this.gbIdadeMaior.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.GroupBox gbAniversariantes;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbIdade;
        private System.Windows.Forms.TextBox txtAte;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbIdadeMaior;
        private System.Windows.Forms.TextBox txtMaiores;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbdInativo;
        private System.Windows.Forms.RadioButton rbdAtivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbCidade;
        private Microsoft.Reporting.WinForms.ReportViewer rptFuncionarios;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource classFuncionarioBindingSource;
    }
}