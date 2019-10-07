namespace customerManagementITP
{
    partial class MealOrderReportForm
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
            this.MealOrderReportDataset = new customerManagementITP.MealOrderReportDataset();
            this.MealOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MealOrderTableAdapter = new customerManagementITP.MealOrderReportDatasetTableAdapters.MealOrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MealOrderReportDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MealOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "mealorderreportdataset";
            reportDataSource1.Value = this.MealOrderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "customerManagementITP.MealOrderReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1410, 639);
            this.reportViewer1.TabIndex = 0;
            // 
            // MealOrderReportDataset
            // 
            this.MealOrderReportDataset.DataSetName = "MealOrderReportDataset";
            this.MealOrderReportDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MealOrderBindingSource
            // 
            this.MealOrderBindingSource.DataMember = "MealOrder";
            this.MealOrderBindingSource.DataSource = this.MealOrderReportDataset;
            // 
            // MealOrderTableAdapter
            // 
            this.MealOrderTableAdapter.ClearBeforeFill = true;
            // 
            // MealOrderReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 639);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MealOrderReportForm";
            this.Text = "MealOrderReportForm";
            this.Load += new System.EventHandler(this.MealOrderReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MealOrderReportDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MealOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MealOrderBindingSource;
        private MealOrderReportDataset MealOrderReportDataset;
        private MealOrderReportDatasetTableAdapters.MealOrderTableAdapter MealOrderTableAdapter;
    }
}