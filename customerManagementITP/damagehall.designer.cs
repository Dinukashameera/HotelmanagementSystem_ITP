namespace Stock_Management_System
{
    partial class damagehall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(damagehall));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblhallDamageItem = new System.Windows.Forms.Label();
            this.btnhalldamagesearch = new System.Windows.Forms.Button();
            this.txtdamageSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.linkHall = new MetroFramework.Controls.MetroLink();
            this.dvgDamage = new MetroFramework.Controls.MetroGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDamage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblhallDamageItem
            // 
            this.lblhallDamageItem.AutoSize = true;
            this.lblhallDamageItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhallDamageItem.Location = new System.Drawing.Point(298, 38);
            this.lblhallDamageItem.Name = "lblhallDamageItem";
            this.lblhallDamageItem.Size = new System.Drawing.Size(142, 22);
            this.lblhallDamageItem.TabIndex = 0;
            this.lblhallDamageItem.Text = "Damage Items";
            // 
            // btnhalldamagesearch
            // 
            this.btnhalldamagesearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhalldamagesearch.Location = new System.Drawing.Point(15, 7);
            this.btnhalldamagesearch.Name = "btnhalldamagesearch";
            this.btnhalldamagesearch.Size = new System.Drawing.Size(97, 32);
            this.btnhalldamagesearch.TabIndex = 2;
            this.btnhalldamagesearch.Text = "Search";
            this.btnhalldamagesearch.UseVisualStyleBackColor = true;
            this.btnhalldamagesearch.Click += new System.EventHandler(this.Btnhalldamagesearch_Click);
            // 
            // txtdamageSearch
            // 
            // 
            // 
            // 
            this.txtdamageSearch.CustomButton.Image = null;
            this.txtdamageSearch.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtdamageSearch.CustomButton.Name = "";
            this.txtdamageSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtdamageSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdamageSearch.CustomButton.TabIndex = 1;
            this.txtdamageSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdamageSearch.CustomButton.UseSelectable = true;
            this.txtdamageSearch.CustomButton.Visible = false;
            this.txtdamageSearch.Lines = new string[0];
            this.txtdamageSearch.Location = new System.Drawing.Point(127, 12);
            this.txtdamageSearch.MaxLength = 32767;
            this.txtdamageSearch.Name = "txtdamageSearch";
            this.txtdamageSearch.PasswordChar = '\0';
            this.txtdamageSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdamageSearch.SelectedText = "";
            this.txtdamageSearch.SelectionLength = 0;
            this.txtdamageSearch.SelectionStart = 0;
            this.txtdamageSearch.ShortcutsEnabled = true;
            this.txtdamageSearch.Size = new System.Drawing.Size(181, 23);
            this.txtdamageSearch.TabIndex = 3;
            this.txtdamageSearch.UseSelectable = true;
            this.txtdamageSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdamageSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtdamageSearch);
            this.metroPanel1.Controls.Add(this.btnhalldamagesearch);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(442, 82);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(315, 44);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.MetroPanel1_Paint);
            // 
            // linkHall
            // 
            this.linkHall.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkHall.Image = ((System.Drawing.Image)(resources.GetObject("linkHall.Image")));
            this.linkHall.ImageSize = 26;
            this.linkHall.Location = new System.Drawing.Point(36, 38);
            this.linkHall.Name = "linkHall";
            this.linkHall.Size = new System.Drawing.Size(98, 32);
            this.linkHall.TabIndex = 29;
            this.linkHall.UseSelectable = true;
            this.linkHall.Click += new System.EventHandler(this.damagehallprevious);
            // 
            // dvgDamage
            // 
            this.dvgDamage.AllowUserToResizeRows = false;
            this.dvgDamage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgDamage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgDamage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgDamage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDamage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgDamage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgDamage.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgDamage.EnableHeadersVisualStyles = false;
            this.dvgDamage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dvgDamage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgDamage.Location = new System.Drawing.Point(24, 24);
            this.dvgDamage.Name = "dvgDamage";
            this.dvgDamage.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDamage.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgDamage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgDamage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDamage.Size = new System.Drawing.Size(647, 242);
            this.dvgDamage.TabIndex = 30;
            this.dvgDamage.DoubleClick += new System.EventHandler(this.DvgDamage_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.dvgDamage);
            this.panel1.Location = new System.Drawing.Point(45, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 303);
            this.panel1.TabIndex = 31;
            // 
            // damagehall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkHall);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lblhallDamageItem);
            this.Name = "damagehall";
            this.Load += new System.EventHandler(this.Damagehall_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDamage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhallDamageItem;
        private System.Windows.Forms.Button btnhalldamagesearch;
        private MetroFramework.Controls.MetroTextBox txtdamageSearch;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink linkHall;
        private MetroFramework.Controls.MetroGrid dvgDamage;
        private System.Windows.Forms.Panel panel1;
    }
}