namespace Hall_Reservation
{
    partial class HRS_filter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.dgvFilterDate = new System.Windows.Forms.DataGridView();
            this.dateTimeend = new System.Windows.Forms.DateTimePicker();
            this.dateTimestart = new System.Windows.Forms.DateTimePicker();
            this.btnMakeReserve = new System.Windows.Forms.Button();
            this.btnFilterSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hrscushallfilterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blueLotusHotelDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRSBLHcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilterDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrscushallfilterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLotusHotelDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRSBLHcustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.metroLink2);
            this.panel1.Controls.Add(this.dgvFilterDate);
            this.panel1.Controls.Add(this.dateTimeend);
            this.panel1.Controls.Add(this.dateTimestart);
            this.panel1.Controls.Add(this.btnMakeReserve);
            this.panel1.Controls.Add(this.btnFilterSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1884, 982);
            this.panel1.TabIndex = 0;
            // 
            // metroLink2
            // 
            this.metroLink2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLink2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLink2.Location = new System.Drawing.Point(1305, 30);
            this.metroLink2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(527, 40);
            this.metroLink2.TabIndex = 91;
            this.metroLink2.Text = "Filter customer by customer ID";
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.MetroLink2_Click);
            // 
            // dgvFilterDate
            // 
            this.dgvFilterDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilterDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilterDate.Location = new System.Drawing.Point(28, 301);
            this.dgvFilterDate.Name = "dgvFilterDate";
            this.dgvFilterDate.RowHeadersWidth = 51;
            this.dgvFilterDate.RowTemplate.Height = 24;
            this.dgvFilterDate.Size = new System.Drawing.Size(1825, 575);
            this.dgvFilterDate.TabIndex = 26;
            // 
            // dateTimeend
            // 
            this.dateTimeend.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeend.Location = new System.Drawing.Point(66, 223);
            this.dateTimeend.Name = "dateTimeend";
            this.dateTimeend.Size = new System.Drawing.Size(444, 30);
            this.dateTimeend.TabIndex = 25;
            // 
            // dateTimestart
            // 
            this.dateTimestart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimestart.Location = new System.Drawing.Point(66, 150);
            this.dateTimestart.Name = "dateTimestart";
            this.dateTimestart.Size = new System.Drawing.Size(444, 30);
            this.dateTimestart.TabIndex = 24;
            // 
            // btnMakeReserve
            // 
            this.btnMakeReserve.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMakeReserve.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReserve.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMakeReserve.Location = new System.Drawing.Point(1450, 906);
            this.btnMakeReserve.Name = "btnMakeReserve";
            this.btnMakeReserve.Size = new System.Drawing.Size(421, 50);
            this.btnMakeReserve.TabIndex = 23;
            this.btnMakeReserve.Text = "+ MAKE RESERVATION";
            this.btnMakeReserve.UseVisualStyleBackColor = false;
            this.btnMakeReserve.Click += new System.EventHandler(this.BtnMakeReserve_Click);
            // 
            // btnFilterSearch
            // 
            this.btnFilterSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFilterSearch.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFilterSearch.Location = new System.Drawing.Point(618, 202);
            this.btnFilterSearch.Name = "btnFilterSearch";
            this.btnFilterSearch.Size = new System.Drawing.Size(233, 53);
            this.btnFilterSearch.TabIndex = 22;
            this.btnFilterSearch.Text = "SEARCH";
            this.btnFilterSearch.UseVisualStyleBackColor = false;
            this.btnFilterSearch.Click += new System.EventHandler(this.BtnFilterSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 87);
            this.label3.TabIndex = 17;
            this.label3.Text = "and\r\n\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 58);
            this.label2.TabIndex = 13;
            this.label2.Text = "Reservation entered between\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reservation List filtered by reservation\'s creation date";
            // 
            // hrscushallfilterBindingSource
            // 
            this.hrscushallfilterBindingSource.DataMember = "hrs_cus_hall_filter";
            // 
            // hRSBLHcustomerBindingSource
            // 
            this.hRSBLHcustomerBindingSource.DataMember = "HRS_BLH_customer";
            // 
            // HRS_filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Name = "HRS_filter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilterDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrscushallfilterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLotusHotelDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRSBLHcustomerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMakeReserve;
        private System.Windows.Forms.Button btnFilterSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeend;
        private System.Windows.Forms.DateTimePicker dateTimestart;
        private System.Windows.Forms.BindingSource blueLotusHotelDataSet1BindingSource;
       // private Blue_Lotus_HotelDataSet1 blue_Lotus_HotelDataSet1;
        private System.Windows.Forms.BindingSource hRSBLHcustomerBindingSource;
        //private Blue_Lotus_HotelDataSet1TableAdapters.HRS_BLH_customerTableAdapter hRS_BLH_customerTableAdapter;
        //private Blue_Lotus_HotelDataSet2 blue_Lotus_HotelDataSet2;
        private System.Windows.Forms.BindingSource hrscushallfilterBindingSource;
        //private Blue_Lotus_HotelDataSet2TableAdapters.hrs_cus_hall_filterTableAdapter hrs_cus_hall_filterTableAdapter;
        private System.Windows.Forms.DataGridView dgvFilterDate;
        private MetroFramework.Controls.MetroLink metroLink2;
    }
}