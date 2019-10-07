namespace Pract._1
{
    partial class MainForm
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
            this.newCus = new System.Windows.Forms.Button();
            this.regCus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newCus
            // 
            this.newCus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.newCus.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCus.ForeColor = System.Drawing.Color.FloralWhite;
            this.newCus.Location = new System.Drawing.Point(36, 89);
            this.newCus.Name = "newCus";
            this.newCus.Size = new System.Drawing.Size(118, 42);
            this.newCus.TabIndex = 0;
            this.newCus.Text = "New Customer";
            this.newCus.UseVisualStyleBackColor = false;
            this.newCus.Click += new System.EventHandler(this.Button1_Click);
            // 
            // regCus
            // 
            this.regCus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.regCus.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regCus.ForeColor = System.Drawing.Color.FloralWhite;
            this.regCus.Location = new System.Drawing.Point(36, 148);
            this.regCus.Name = "regCus";
            this.regCus.Size = new System.Drawing.Size(118, 40);
            this.regCus.TabIndex = 1;
            this.regCus.Text = "Registered Customer";
            this.regCus.UseVisualStyleBackColor = false;
            this.regCus.Click += new System.EventHandler(this.RegCus_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 296);
            this.Controls.Add(this.regCus);
            this.Controls.Add(this.newCus);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newCus;
        private System.Windows.Forms.Button regCus;
    }
}

