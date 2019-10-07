namespace customerManagementITP
{
    partial class ExpenseReportForm
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
            this.ExpenseDataSet = new customerManagementITP.ExpenseDataSet();
            this.TotalExpensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TotalExpensesTableAdapter = new customerManagementITP.ExpenseDataSetTableAdapters.TotalExpensesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalExpensesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "expensedataset";
            reportDataSource1.Value = this.TotalExpensesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "customerManagementITP.ExpenseReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1308, 587);
            this.reportViewer1.TabIndex = 0;
            // 
            // ExpenseDataSet
            // 
            this.ExpenseDataSet.DataSetName = "ExpenseDataSet";
            this.ExpenseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TotalExpensesBindingSource
            // 
            this.TotalExpensesBindingSource.DataMember = "TotalExpenses";
            this.TotalExpensesBindingSource.DataSource = this.ExpenseDataSet;
            // 
            // TotalExpensesTableAdapter
            // 
            this.TotalExpensesTableAdapter.ClearBeforeFill = true;
            // 
            // ExpenseReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 587);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ExpenseReportForm";
            this.Text = "ExpenseReportForm";
            this.Load += new System.EventHandler(this.ExpenseReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalExpensesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TotalExpensesBindingSource;
        private ExpenseDataSet ExpenseDataSet;
        private ExpenseDataSetTableAdapters.TotalExpensesTableAdapter TotalExpensesTableAdapter;
    }
}