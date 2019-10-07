namespace customerManagementITP
{
    partial class salaryReportForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.salaryReportDataset = new customerManagementITP.salaryReportDataset();
            this.SalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalaryTableAdapter = new customerManagementITP.salaryReportDatasetTableAdapters.SalaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salaryReportDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "salarydataset";
            reportDataSource1.Value = this.SalaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "customerManagementITP.salaryReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1323, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // salaryReportDataset
            // 
            this.salaryReportDataset.DataSetName = "salaryReportDataset";
            this.salaryReportDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalaryBindingSource
            // 
            this.SalaryBindingSource.DataMember = "Salary";
            this.SalaryBindingSource.DataSource = this.salaryReportDataset;
            // 
            // SalaryTableAdapter
            // 
            this.SalaryTableAdapter.ClearBeforeFill = true;
            // 
            // salaryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "salaryReportForm";
            this.Text = "salaryReportForm";
            this.Load += new System.EventHandler(this.SalaryReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaryReportDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalaryBindingSource;
        private salaryReportDataset salaryReportDataset;
        private salaryReportDatasetTableAdapters.SalaryTableAdapter SalaryTableAdapter;
    }
}