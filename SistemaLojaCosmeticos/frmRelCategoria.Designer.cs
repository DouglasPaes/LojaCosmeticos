namespace SistemaLojaCosmeticos
{
    partial class frmRelCategoria
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
            this.classCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptCategoria = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.classCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classCategoriaBindingSource
            // 
            this.classCategoriaBindingSource.DataSource = typeof(SistemaLojaCosmeticos.classCategoria);
            // 
            // rptCategoria
            // 
            this.rptCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCategoria";
            reportDataSource1.Value = this.classCategoriaBindingSource;
            this.rptCategoria.LocalReport.DataSources.Add(reportDataSource1);
            this.rptCategoria.LocalReport.ReportEmbeddedResource = "SistemaLojaCosmeticos.rptCategoria.rdlc";
            this.rptCategoria.Location = new System.Drawing.Point(0, 0);
            this.rptCategoria.Name = "rptCategoria";
            this.rptCategoria.Size = new System.Drawing.Size(658, 362);
            this.rptCategoria.TabIndex = 1;
            // 
            // frmRelCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(658, 362);
            this.Controls.Add(this.rptCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRelCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Categoria";
            this.Load += new System.EventHandler(this.frmRelCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptCategoria;
        private System.Windows.Forms.BindingSource classCategoriaBindingSource;
    }
}