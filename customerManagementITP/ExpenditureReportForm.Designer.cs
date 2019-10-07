namespace customerManagementITP
{
    partial class ExpenditureReportForm
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
            this.ExpenditureDataSet = new customerManagementITP.ExpenditureDataSet();
            this.Expenditure_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Expenditure_tableTableAdapter = new customerManagementITP.ExpenditureDataSetTableAdapters.Expenditure_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenditureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expenditure_tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "expendituredataset";
            reportDataSource1.Value = this.Expenditure_tableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "customerManagementITP.ExpenditureReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1190, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // ExpenditureDataSet
            // 
            this.ExpenditureDataSet.DataSetName = "ExpenditureDataSet";
            this.ExpenditureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Expenditure_tableBindingSource
            // 
            this.Expenditure_tableBindingSource.DataMember = "Expenditure_table";
            this.Expenditure_tableBindingSource.DataSource = this.ExpenditureDataSet;
            // 
            // Expenditure_tableTableAdapter
            // 
            this.Expenditure_tableTableAdapter.ClearBeforeFill = true;
            // 
            // ExpenditureReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 554);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ExpenditureReportForm";
            this.Text = "ExpenditureReportForm";
            this.Load += new System.EventHandler(this.ExpenditureReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenditureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expenditure_tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Expenditure_tableBindingSource;
        private ExpenditureDataSet ExpenditureDataSet;
        private ExpenditureDataSetTableAdapters.Expenditure_tableTableAdapter Expenditure_tableTableAdapter;
    }
}