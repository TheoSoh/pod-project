﻿namespace PodProject
{
    partial class AddPodPage
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
            label1 = new Label();
            txtUrl = new TextBox();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(427, 37);
            label1.Name = "label1";
            label1.Size = new Size(282, 49);
            label1.TabIndex = 0;
            label1.Text = "Lägg till podd";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(389, 165);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(352, 39);
            txtUrl.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(389, 268);
            txtName.Name = "txtName";
            txtName.Size = new Size(352, 39);
            txtName.TabIndex = 2;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(389, 375);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(352, 40);
            cmbCategory.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(295, 165);
            label2.Name = "label2";
            label2.Size = new Size(93, 36);
            label2.TabIndex = 5;
            label2.Text = "URL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(278, 268);
            label3.Name = "label3";
            label3.Size = new Size(110, 36);
            label3.TabIndex = 6;
            label3.Text = "Namn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(240, 375);
            label4.Name = "label4";
            label4.Size = new Size(148, 36);
            label4.TabIndex = 7;
            label4.Text = "Kategori:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Snow;
            btnAdd.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(442, 510);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(230, 46);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Lägg till";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddPodPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1084, 779);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbCategory);
            Controls.Add(txtName);
            Controls.Add(txtUrl);
            Controls.Add(label1);
            Name = "AddPodPage";
            Text = "AddPodPage";
            Load += AddPodPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUrl;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
    }
}