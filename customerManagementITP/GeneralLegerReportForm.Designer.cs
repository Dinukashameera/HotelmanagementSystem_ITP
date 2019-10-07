namespace customerManagementITP
{
    partial class GeneralLegerReportForm
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
            this.GeneralLegerDataSet = new customerManagementITP.GeneralLegerDataSet();
            this.IncomeExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IncomeExpenseTableAdapter = new customerManagementITP.GeneralLegerDataSetTableAdapters.IncomeExpenseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralLegerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeExpenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "generallegertdataset";
            reportDataSource1.Value = this.IncomeExpenseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "customerManagementITP.GeneralLegerReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // GeneralLegerDataSet
            // 
            this.GeneralLegerDataSet.DataSetName = "GeneralLegerDataSet";
            this.GeneralLegerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IncomeExpenseBindingSource
            // 
            this.IncomeExpenseBindingSource.DataMember = "IncomeExpense";
            this.IncomeExpenseBindingSource.DataSource = this.GeneralLegerDataSet;
            // 
            // IncomeExpenseTableAdapter
            // 
            this.IncomeExpenseTableAdapter.ClearBeforeFill = true;
            // 
            // GeneralLegerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GeneralLegerReportForm";
            this.Text = "GeneralLegerReportForm";
            this.Load += new System.EventHandler(this.GeneralLegerReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeneralLegerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeExpenseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IncomeExpenseBindingSource;
        private GeneralLegerDataSet GeneralLegerDataSet;
        private GeneralLegerDataSetTableAdapters.IncomeExpenseTableAdapter IncomeExpenseTableAdapter;
    }
}