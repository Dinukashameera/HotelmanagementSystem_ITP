namespace customerManagementITP
{
    partial class HRSreportForm
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
            this.HRSreportDataSet = new customerManagementITP.HRSreportDataSet();
            this.HRS_customer_completedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HRS_customer_completedTableAdapter = new customerManagementITP.HRSreportDataSetTableAdapters.HRS_customer_completedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HRSreportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRS_customer_completedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HRSreportdataset";
            reportDataSource1.Value = this.HRS_customer_completedBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "customerManagementITP.HRSreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1442, 659);
            this.reportViewer1.TabIndex = 0;
            // 
            // HRSreportDataSet
            // 
            this.HRSreportDataSet.DataSetName = "HRSreportDataSet";
            this.HRSreportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HRS_customer_completedBindingSource
            // 
            this.HRS_customer_completedBindingSource.DataMember = "HRS_customer_completed";
            this.HRS_customer_completedBindingSource.DataSource = this.HRSreportDataSet;
            // 
            // HRS_customer_completedTableAdapter
            // 
            this.HRS_customer_completedTableAdapter.ClearBeforeFill = true;
            // 
            // HRSreportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 659);
            this.Controls.Add(this.reportViewer1);
            this.Name = "HRSreportForm";
            this.Text = "HRSreportForm";
            this.Load += new System.EventHandler(this.HRSreportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HRSreportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRS_customer_completedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HRS_customer_completedBindingSource;
        private HRSreportDataSet HRSreportDataSet;
        private HRSreportDataSetTableAdapters.HRS_customer_completedTableAdapter HRS_customer_completedTableAdapter;
    }
}