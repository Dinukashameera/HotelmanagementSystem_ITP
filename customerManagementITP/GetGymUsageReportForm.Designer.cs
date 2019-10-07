namespace customerManagementITP
{
    partial class GetGymUsageReportForm
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
            this.GetGymUsageReportDataset = new customerManagementITP.GetGymUsageReportDataset();
            this.GetGymUsageReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetGymUsageReportTableAdapter = new customerManagementITP.GetGymUsageReportDatasetTableAdapters.GetGymUsageReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GetGymUsageReportDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetGymUsageReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "getgymusagereportdataset";
            reportDataSource1.Value = this.GetGymUsageReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "customerManagementITP.GetGymUsageReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1373, 555);
            this.reportViewer1.TabIndex = 0;
            // 
            // GetGymUsageReportDataset
            // 
            this.GetGymUsageReportDataset.DataSetName = "GetGymUsageReportDataset";
            this.GetGymUsageReportDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GetGymUsageReportBindingSource
            // 
            this.GetGymUsageReportBindingSource.DataMember = "GetGymUsageReport";
            this.GetGymUsageReportBindingSource.DataSource = this.GetGymUsageReportDataset;
            // 
            // GetGymUsageReportTableAdapter
            // 
            this.GetGymUsageReportTableAdapter.ClearBeforeFill = true;
            // 
            // GetGymUsageReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 555);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GetGymUsageReportForm";
            this.Text = "GetGymUsageReportForm";
            this.Load += new System.EventHandler(this.GetGymUsageReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetGymUsageReportDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetGymUsageReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetGymUsageReportBindingSource;
        private GetGymUsageReportDataset GetGymUsageReportDataset;
        private GetGymUsageReportDatasetTableAdapters.GetGymUsageReportTableAdapter GetGymUsageReportTableAdapter;
    }
}