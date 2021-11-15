
namespace Test_purchee
{
    partial class Purchase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbn_income = new System.Windows.Forms.Button();
            this.requriments = new System.Windows.Forms.TabControl();
            this.btn_inventary = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.requriments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1078, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "შესყიდვა";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1071, 511);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1078, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "მოთხოვნები";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 514);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbn_income
            // 
            this.tbn_income.Location = new System.Drawing.Point(9, 12);
            this.tbn_income.Name = "tbn_income";
            this.tbn_income.Size = new System.Drawing.Size(105, 43);
            this.tbn_income.TabIndex = 1;
            this.tbn_income.Text = "მოთხოვნის დამატება";
            this.tbn_income.UseVisualStyleBackColor = true;
            // 
            // requriments
            // 
            this.requriments.Controls.Add(this.tabPage1);
            this.requriments.Controls.Add(this.tabPage2);
            this.requriments.Location = new System.Drawing.Point(5, 96);
            this.requriments.Name = "requriments";
            this.requriments.SelectedIndex = 0;
            this.requriments.Size = new System.Drawing.Size(1086, 548);
            this.requriments.TabIndex = 0;
            // 
            // btn_inventary
            // 
            this.btn_inventary.Location = new System.Drawing.Point(156, 12);
            this.btn_inventary.Name = "btn_inventary";
            this.btn_inventary.Size = new System.Drawing.Size(103, 43);
            this.btn_inventary.TabIndex = 2;
            this.btn_inventary.Text = "ინვენტარის დამატება";
            this.btn_inventary.UseVisualStyleBackColor = true;
            this.btn_inventary.Click += new System.EventHandler(this.btn_inventary_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "დაამატე დეპარატამენტი";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 711);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_inventary);
            this.Controls.Add(this.tbn_income);
            this.Controls.Add(this.requriments);
            this.Name = "Purchase";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.requriments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button tbn_income;
        private System.Windows.Forms.TabControl requriments;
        private System.Windows.Forms.Button btn_inventary;
        private System.Windows.Forms.Button button1;
    }
}

