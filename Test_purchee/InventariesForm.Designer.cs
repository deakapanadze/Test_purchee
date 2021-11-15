
namespace Test_purchee
{
    partial class InventariesForm
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
            this.txt_inventary = new System.Windows.Forms.TextBox();
            this.save_inventary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "გთხოვთ აირჩიოთ ნივთი";
            // 
            // txt_inventary
            // 
            this.txt_inventary.Location = new System.Drawing.Point(94, 58);
            this.txt_inventary.Name = "txt_inventary";
            this.txt_inventary.Size = new System.Drawing.Size(158, 23);
            this.txt_inventary.TabIndex = 1;
            // 
            // save_inventary
            // 
            this.save_inventary.Location = new System.Drawing.Point(243, 114);
            this.save_inventary.Name = "save_inventary";
            this.save_inventary.Size = new System.Drawing.Size(92, 30);
            this.save_inventary.TabIndex = 2;
            this.save_inventary.Text = "დამატება";
            this.save_inventary.UseVisualStyleBackColor = true;
            this.save_inventary.Click += new System.EventHandler(this.save_inventary_Click);
            // 
            // Inventaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 156);
            this.Controls.Add(this.save_inventary);
            this.Controls.Add(this.txt_inventary);
            this.Controls.Add(this.label1);
            this.Name = "Inventaries";
            this.Text = "Inventaries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_inventary;
        private System.Windows.Forms.Button save_inventary;
    }
}