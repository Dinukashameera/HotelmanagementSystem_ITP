namespace Pract._1
{
    partial class transportation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.delDate = new System.Windows.Forms.DateTimePicker();
            this.btnTrans = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.retDate = new System.Windows.Forms.DateTimePicker();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.madeDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total :";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtLoc
            // 
            this.txtLoc.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoc.Location = new System.Drawing.Point(258, 220);
            this.txtLoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(249, 36);
            this.txtLoc.TabIndex = 4;
            // 
            // txtDis
            // 
            this.txtDis.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDis.Location = new System.Drawing.Point(258, 267);
            this.txtDis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(249, 36);
            this.txtDis.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "To be delivered:";
            // 
            // delDate
            // 
            this.delDate.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDate.Location = new System.Drawing.Point(258, 79);
            this.delDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delDate.MinDate = new System.DateTime(2019, 8, 25, 0, 0, 0, 0);
            this.delDate.Name = "delDate";
            this.delDate.Size = new System.Drawing.Size(382, 36);
            this.delDate.TabIndex = 7;
            this.delDate.Value = new System.DateTime(2019, 8, 26, 0, 0, 0, 0);
            this.delDate.ValueChanged += new System.EventHandler(this.DelDate_ValueChanged);
            // 
            // btnTrans
            // 
            this.btnTrans.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTrans.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrans.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnTrans.Location = new System.Drawing.Point(258, 371);
            this.btnTrans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(163, 70);
            this.btnTrans.TabIndex = 8;
            this.btnTrans.Text = "Submit";
            this.btnTrans.UseVisualStyleBackColor = false;
            this.btnTrans.Click += new System.EventHandler(this.BtnTrans_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Return on:";
            // 
            // retDate
            // 
            this.retDate.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retDate.Location = new System.Drawing.Point(258, 126);
            this.retDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.retDate.Name = "retDate";
            this.retDate.Size = new System.Drawing.Size(382, 36);
            this.retDate.TabIndex = 7;
            // 
            // txtSub
            // 
            this.txtSub.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSub.Location = new System.Drawing.Point(258, 314);
            this.txtSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(249, 36);
            this.txtSub.TabIndex = 9;
            this.txtSub.TextChanged += new System.EventHandler(this.TxtSub_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Made on:";
            // 
            // madeDate
            // 
            this.madeDate.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madeDate.Location = new System.Drawing.Point(258, 173);
            this.madeDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.madeDate.Name = "madeDate";
            this.madeDate.Size = new System.Drawing.Size(382, 36);
            this.madeDate.TabIndex = 7;
            this.madeDate.Value = new System.DateTime(2019, 8, 25, 11, 57, 43, 0);
            // 
            // transportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 470);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.madeDate);
            this.Controls.Add(this.retDate);
            this.Controls.Add(this.delDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDis);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "transportation";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "transportation";
            this.Load += new System.EventHandler(this.Transportation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker delDate;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker retDate;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker madeDate;
    }
}