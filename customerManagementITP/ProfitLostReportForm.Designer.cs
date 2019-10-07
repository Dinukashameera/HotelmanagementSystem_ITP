namespace customerManagementITP
{
    partial class ProfitLostReportForm
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
            this.ProfitLostDataSet = new customerManagementITP.ProfitLostDataSet();
            this.ProfitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProfitTableAdapter = new customerManagementITP.ProfitLostDataSetTableAdapters.ProfitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitLostDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "profitlostdataset";
            reportDataSource1.Value = this.ProfitBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "customerManagementITP.ProfitLostReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProfitLostDataSet
            // 
            this.ProfitLostDataSet.DataSetName = "ProfitLostDataSet";
            this.ProfitLostDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProfitBindingSource
            // 
            this.ProfitBindingSource.DataMember = "Profit";
            this.ProfitBindingSource.DataSource = this.ProfitLostDataSet;
            // 
            // ProfitTableAdapter
            // 
            this.ProfitTableAdapter.ClearBeforeFill = true;
            // 
            // ProfitLostReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ProfitLostReportForm";
            this.Text = "ProfitLostReportForm";
            this.Load += new System.EventHandler(this.ProfitLostReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfitLostDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProfitBindingSource;
        private ProfitLostDataSet ProfitLostDataSet;
        private ProfitLostDataSetTableAdapters.ProfitTableAdapter ProfitTableAdapter;
    }
}