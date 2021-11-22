
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
            this.tbn_income = new System.Windows.Forms.Button();
            this.requriments = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btn_inventary = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.requriments.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1079, 517);
            this.dataGridView2.TabIndex = 0;
            // 
            // tbn_income
            // 
            this.tbn_income.BackColor = System.Drawing.Color.ForestGreen;
            this.tbn_income.Location = new System.Drawing.Point(9, 12);
            this.tbn_income.Name = "tbn_income";
            this.tbn_income.Size = new System.Drawing.Size(105, 43);
            this.tbn_income.TabIndex = 1;
            this.tbn_income.Text = "მოთხოვნის დამატება";
            this.tbn_income.UseVisualStyleBackColor = false;
            this.tbn_income.Click += new System.EventHandler(this.tbn_income_Click);
            // 
            // requriments
            // 
            this.requriments.Controls.Add(this.tabPage3);
            this.requriments.Controls.Add(this.tabPage2);
            this.requriments.Location = new System.Drawing.Point(9, 96);
            this.requriments.Name = "requriments";
            this.requriments.SelectedIndex = 0;
            this.requriments.Size = new System.Drawing.Size(1086, 548);
            this.requriments.TabIndex = 0;
            this.requriments.Tag = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1078, 520);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "დაჯოინებული";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1082, 520);
            this.dataGridView3.TabIndex = 0;
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
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "დაამატე დეპარატამენტი";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1128, 711);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_inventary);
            this.Controls.Add(this.tbn_income);
            this.Controls.Add(this.requriments);
            this.Name = "Purchase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "შესყიდვის ფორმა";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.requriments.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button tbn_income;
        private System.Windows.Forms.TabControl requriments;
        private System.Windows.Forms.Button btn_inventary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

