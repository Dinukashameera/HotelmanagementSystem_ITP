namespace customerManagementITP
{
    partial class CheckedCustomerForm
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
            this.Blue_Lotus_HotelDataSet = new customerManagementITP.Blue_Lotus_HotelDataSet();
            this.AccomodationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccomodationTableAdapter = new customerManagementITP.Blue_Lotus_HotelDataSetTableAdapters.AccomodationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Blue_Lotus_HotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccomodationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AccomodationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "customerManagementITP.CheckedCustomerFormReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1350, 745);
            this.reportViewer1.TabIndex = 0;
            // 
            // Blue_Lotus_HotelDataSet
            // 
            this.Blue_Lotus_HotelDataSet.DataSetName = "Blue_Lotus_HotelDataSet";
            this.Blue_Lotus_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AccomodationBindingSource
            // 
            this.AccomodationBindingSource.DataMember = "Accomodation";
            this.AccomodationBindingSource.DataSource = this.Blue_Lotus_HotelDataSet;
            // 
            // AccomodationTableAdapter
            // 
            this.AccomodationTableAdapter.ClearBeforeFill = true;
            // 
            // CheckedCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 745);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CheckedCustomerForm";
            this.Text = "CheckedCustomerForm";
            this.Load += new System.EventHandler(this.CheckedCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Blue_Lotus_HotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccomodationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AccomodationBindingSource;
        private Blue_Lotus_HotelDataSet Blue_Lotus_HotelDataSet;
        private Blue_Lotus_HotelDataSetTableAdapters.AccomodationTableAdapter AccomodationTableAdapter;
    }
}