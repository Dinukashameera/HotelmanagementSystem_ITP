namespace customerManagementITP
{
    partial class InventoryExpensesReportForm
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
            this.InventoryExpencesDatSet = new customerManagementITP.InventoryExpencesDatSet();
            this.IncomeExpencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IncomeExpencesTableAdapter = new customerManagementITP.InventoryExpencesDatSetTableAdapters.IncomeExpencesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryExpencesDatSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeExpencesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "inventoryexpencesdataset";
            reportDataSource1.Value = this.IncomeExpencesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "customerManagementITP.InventoryExpensesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1414, 657);
            this.reportViewer1.TabIndex = 0;
            // 
            // InventoryExpencesDatSet
            // 
            this.InventoryExpencesDatSet.DataSetName = "InventoryExpencesDatSet";
            this.InventoryExpencesDatSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IncomeExpencesBindingSource
            // 
            this.IncomeExpencesBindingSource.DataMember = "IncomeExpences";
            this.IncomeExpencesBindingSource.DataSource = this.InventoryExpencesDatSet;
            // 
            // IncomeExpencesTableAdapter
            // 
            this.IncomeExpencesTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryExpensesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 657);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InventoryExpensesReportForm";
            this.Text = "InventoryExpensesReportForm";
            this.Load += new System.EventHandler(this.InventoryExpensesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryExpencesDatSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeExpencesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IncomeExpencesBindingSource;
        private InventoryExpencesDatSet InventoryExpencesDatSet;
        private InventoryExpencesDatSetTableAdapters.IncomeExpencesTableAdapter IncomeExpencesTableAdapter;
    }
}