namespace customerManagementITP
{
    partial class SpaAppointmentReportForm
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
            this.SpaAppointmentDetailsReportDataSet = new customerManagementITP.SpaAppointmentDetailsReportDataSet();
            this.getSpaAppointmentDetailsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getSpaAppointmentDetailsReportTableAdapter = new customerManagementITP.SpaAppointmentDetailsReportDataSetTableAdapters.getSpaAppointmentDetailsReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SpaAppointmentDetailsReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSpaAppointmentDetailsReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "spaappointmentdetailsreportdataset";
            reportDataSource1.Value = this.getSpaAppointmentDetailsReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "customerManagementITP.SpaAppointmentReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1437, 649);
            this.reportViewer1.TabIndex = 0;
            // 
            // SpaAppointmentDetailsReportDataSet
            // 
            this.SpaAppointmentDetailsReportDataSet.DataSetName = "SpaAppointmentDetailsReportDataSet";
            this.SpaAppointmentDetailsReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getSpaAppointmentDetailsReportBindingSource
            // 
            this.getSpaAppointmentDetailsReportBindingSource.DataMember = "getSpaAppointmentDetailsReport";
            this.getSpaAppointmentDetailsReportBindingSource.DataSource = this.SpaAppointmentDetailsReportDataSet;
            // 
            // getSpaAppointmentDetailsReportTableAdapter
            // 
            this.getSpaAppointmentDetailsReportTableAdapter.ClearBeforeFill = true;
            // 
            // SpaAppointmentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 649);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SpaAppointmentReportForm";
            this.Text = "SpaAppointmentReportForm";
            this.Load += new System.EventHandler(this.SpaAppointmentReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpaAppointmentDetailsReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSpaAppointmentDetailsReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getSpaAppointmentDetailsReportBindingSource;
        private SpaAppointmentDetailsReportDataSet SpaAppointmentDetailsReportDataSet;
        private SpaAppointmentDetailsReportDataSetTableAdapters.getSpaAppointmentDetailsReportTableAdapter getSpaAppointmentDetailsReportTableAdapter;
    }
}