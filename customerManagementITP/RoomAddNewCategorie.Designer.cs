namespace Stock_Management_System
{
    partial class RoomAddNewCategorie
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnCategorieAdd = new System.Windows.Forms.Button();
            this.btnCategoriecancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Categorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categorie Name :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(302, 127);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(195, 20);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // btnCategorieAdd
            // 
            this.btnCategorieAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorieAdd.Location = new System.Drawing.Point(173, 214);
            this.btnCategorieAdd.Name = "btnCategorieAdd";
            this.btnCategorieAdd.Size = new System.Drawing.Size(85, 28);
            this.btnCategorieAdd.TabIndex = 3;
            this.btnCategorieAdd.Text = "Add";
            this.btnCategorieAdd.UseVisualStyleBackColor = true;
            // 
            // btnCategoriecancel
            // 
            this.btnCategoriecancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriecancel.Location = new System.Drawing.Point(363, 214);
            this.btnCategoriecancel.Name = "btnCategoriecancel";
            this.btnCategoriecancel.Size = new System.Drawing.Size(90, 28);
            this.btnCategoriecancel.TabIndex = 4;
            this.btnCategoriecancel.Text = "Cancel";
            this.btnCategoriecancel.UseVisualStyleBackColor = true;
            // 
            // RoomAddNewCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 372);
            this.Controls.Add(this.btnCategoriecancel);
            this.Controls.Add(this.btnCategorieAdd);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RoomAddNewCategorie";
            this.Load += new System.EventHandler(this.AddNewCategorie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnCategorieAdd;
        private System.Windows.Forms.Button btnCategoriecancel;
    }
}