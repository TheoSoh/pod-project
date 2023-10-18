namespace PodProject
{
    partial class AddCategory
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
            label2 = new Label();
            txtNewCategory = new TextBox();
            label3 = new Label();
            cmbSelectCategory = new ComboBox();
            txtNewNameCategory = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnChangeNameCat = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(349, 70);
            label1.Name = "label1";
            label1.Size = new Size(433, 55);
            label1.TabIndex = 0;
            label1.Text = "Hantera kategorier:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(111, 200);
            label2.Name = "label2";
            label2.Size = new Size(230, 26);
            label2.TabIndex = 1;
            label2.Text = "Lägg till ny kategori:";
            // 
            // txtNewCategory
            // 
            txtNewCategory.Location = new Point(361, 192);
            txtNewCategory.Name = "txtNewCategory";
            txtNewCategory.Size = new Size(234, 39);
            txtNewCategory.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(113, 352);
            label3.Name = "label3";
            label3.Size = new Size(156, 26);
            label3.TabIndex = 3;
            label3.Text = "Välj kategori:";
            // 
            // cmbSelectCategory
            // 
            cmbSelectCategory.FormattingEnabled = true;
            cmbSelectCategory.Location = new Point(282, 349);
            cmbSelectCategory.Name = "cmbSelectCategory";
            cmbSelectCategory.Size = new Size(234, 40);
            cmbSelectCategory.TabIndex = 4;
            // 
            // txtNewNameCategory
            // 
            txtNewNameCategory.Location = new Point(701, 349);
            txtNewNameCategory.Name = "txtNewNameCategory";
            txtNewNameCategory.Size = new Size(200, 39);
            txtNewNameCategory.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(549, 352);
            label4.Name = "label4";
            label4.Size = new Size(128, 26);
            label4.TabIndex = 6;
            label4.Text = "Nytt namn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 449);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 7;
            // 
            // btnChangeNameCat
            // 
            btnChangeNameCat.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeNameCat.Location = new Point(701, 449);
            btnChangeNameCat.Name = "btnChangeNameCat";
            btnChangeNameCat.Size = new Size(185, 46);
            btnChangeNameCat.TabIndex = 8;
            btnChangeNameCat.Text = "Ändra namn";
            btnChangeNameCat.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteCategory.Location = new Point(282, 449);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(150, 46);
            btnDeleteCategory.TabIndex = 9;
            btnDeleteCategory.Text = "Ta bort";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCategory.Location = new Point(689, 188);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(150, 46);
            btnAddCategory.TabIndex = 10;
            btnAddCategory.Text = "Lägg till";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1163, 642);
            Controls.Add(btnAddCategory);
            Controls.Add(btnDeleteCategory);
            Controls.Add(btnChangeNameCat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNewNameCategory);
            Controls.Add(cmbSelectCategory);
            Controls.Add(label3);
            Controls.Add(txtNewCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCategory";
            Text = "AddCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNewCategory;
        private Label label3;
        private ComboBox cmbSelectCategory;
        private TextBox txtNewNameCategory;
        private Label label4;
        private Label label5;
        private Button btnChangeNameCat;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
    }
}