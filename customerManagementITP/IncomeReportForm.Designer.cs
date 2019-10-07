namespace customerManagementITP
{
    partial class IncomeReportForm
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
            this.TotalIncomesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IncomeDataSet = new customerManagementITP.IncomeDataSet();
            this.TotalIncomesTableAdapter = new customerManagementITP.IncomeDataSetTableAdapters.TotalIncomesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TotalIncomesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TotalIncomesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "customerManagementITP.IncomeReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1232, 567);
            this.reportViewer1.TabIndex = 0;
            // 
            // TotalIncomesBindingSource
            // 
            this.TotalIncomesBindingSource.DataMember = "TotalIncomes";
            this.TotalIncomesBindingSource.DataSource = this.IncomeDataSet;
            // 
            // IncomeDataSet
            // 
            this.IncomeDataSet.DataSetName = "IncomeDataSet";
            this.IncomeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TotalIncomesTableAdapter
            // 
            this.TotalIncomesTableAdapter.ClearBeforeFill = true;
            // 
            // IncomeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 567);
            this.Controls.Add(this.reportViewer1);
            this.Name = "IncomeReportForm";
            this.Text = "IncomeReportForm";
            this.Load += new System.EventHandler(this.IncomeReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalIncomesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TotalIncomesBindingSource;
        private IncomeDataSet IncomeDataSet;
        private IncomeDataSetTableAdapters.TotalIncomesTableAdapter TotalIncomesTableAdapter;
    }
}