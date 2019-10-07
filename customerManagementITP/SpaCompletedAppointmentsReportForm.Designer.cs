namespace customerManagementITP
{
    partial class SpaCompletedAppointmentsReportForm
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
            this.SpaCompletedAppointmentDetailsReportDataSet = new customerManagementITP.SpaCompletedAppointmentDetailsReportDataSet();
            this.getSpaCompletedAppointmentDetailsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getSpaCompletedAppointmentDetailsReportTableAdapter = new customerManagementITP.SpaCompletedAppointmentDetailsReportDataSetTableAdapters.getSpaCompletedAppointmentDetailsReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SpaCompletedAppointmentDetailsReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSpaCompletedAppointmentDetailsReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "spacompletedAppointmentDetailsReport";
            reportDataSource1.Value = this.getSpaCompletedAppointmentDetailsReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "customerManagementITP.SpaCompletedAppointmentsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1408, 661);
            this.reportViewer1.TabIndex = 0;
            // 
            // SpaCompletedAppointmentDetailsReportDataSet
            // 
            this.SpaCompletedAppointmentDetailsReportDataSet.DataSetName = "SpaCompletedAppointmentDetailsReportDataSet";
            this.SpaCompletedAppointmentDetailsReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getSpaCompletedAppointmentDetailsReportBindingSource
            // 
            this.getSpaCompletedAppointmentDetailsReportBindingSource.DataMember = "getSpaCompletedAppointmentDetailsReport";
            this.getSpaCompletedAppointmentDetailsReportBindingSource.DataSource = this.SpaCompletedAppointmentDetailsReportDataSet;
            // 
            // getSpaCompletedAppointmentDetailsReportTableAdapter
            // 
            this.getSpaCompletedAppointmentDetailsReportTableAdapter.ClearBeforeFill = true;
            // 
            // SpaCompletedAppointmentsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 661);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SpaCompletedAppointmentsReportForm";
            this.Text = "SpaCompletedAppointmentsReportForm";
            this.Load += new System.EventHandler(this.SpaCompletedAppointmentsReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpaCompletedAppointmentDetailsReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSpaCompletedAppointmentDetailsReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getSpaCompletedAppointmentDetailsReportBindingSource;
        private SpaCompletedAppointmentDetailsReportDataSet SpaCompletedAppointmentDetailsReportDataSet;
        private SpaCompletedAppointmentDetailsReportDataSetTableAdapters.getSpaCompletedAppointmentDetailsReportTableAdapter getSpaCompletedAppointmentDetailsReportTableAdapter;
    }
}