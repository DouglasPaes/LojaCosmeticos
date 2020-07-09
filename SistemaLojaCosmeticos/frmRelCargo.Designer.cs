namespace SistemaLojaCosmeticos
{
    partial class frmRelCargo
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
            this.rptCargo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.classCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.classCargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptCargo
            // 
            this.rptCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCargo";
            reportDataSource1.Value = this.classCargoBindingSource;
            this.rptCargo.LocalReport.DataSources.Add(reportDataSource1);
            this.rptCargo.LocalReport.ReportEmbeddedResource = "SistemaLojaCosmeticos.rptCargo.rdlc";
            this.rptCargo.Location = new System.Drawing.Point(0, 0);
            this.rptCargo.Name = "rptCargo";
            this.rptCargo.Size = new System.Drawing.Size(649, 391);
            this.rptCargo.TabIndex = 2;
            // 
            // classCargoBindingSource
            // 
            this.classCargoBindingSource.DataSource = typeof(SistemaLojaCosmeticos.classCargo);
            // 
            // frmRelCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(649, 391);
            this.Controls.Add(this.rptCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRelCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Cargo";
            this.Load += new System.EventHandler(this.frmRelCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classCargoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptCargo;
        private System.Windows.Forms.BindingSource classCargoBindingSource;
    }
}