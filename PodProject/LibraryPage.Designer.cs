namespace PodProject
{
    partial class LibraryPage
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnDelete = new Button();
            btnChange = new Button();
            vScrollBar1 = new VScrollBar();
            cmbChangeCategory = new ComboBox();
            label5 = new Label();
            txtChangeName = new TextBox();
            label6 = new Label();
            cmbChangeInterval = new ComboBox();
            btnSaveChanges = new Button();
            label7 = new Label();
            comboBox3 = new ComboBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listBox2 = new ListBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(807, 171);
            listBox1.Margin = new Padding(4, 2, 4, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(274, 388);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 36);
            label1.TabIndex = 2;
            label1.Text = "Poddar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(807, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 36);
            label2.TabIndex = 3;
            label2.Text = "Avsnitt:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 599);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(248, 36);
            label3.TabIndex = 4;
            label3.Text = "Hantera poddar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(466, 624);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 26);
            label4.TabIndex = 5;
            label4.Text = "Ändra kategori:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(39, 669);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Ta bort";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(221, 669);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(150, 46);
            btnChange.TabIndex = 7;
            btnChange.Text = "Ändra";
            btnChange.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1073, 171);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(25, 388);
            vScrollBar1.TabIndex = 8;
            // 
            // cmbChangeCategory
            // 
            cmbChangeCategory.FormattingEnabled = true;
            cmbChangeCategory.Location = new Point(650, 616);
            cmbChangeCategory.Name = "cmbChangeCategory";
            cmbChangeCategory.Size = new Size(242, 40);
            cmbChangeCategory.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(483, 689);
            label5.Name = "label5";
            label5.Size = new Size(149, 26);
            label5.TabIndex = 11;
            label5.Text = "Ändra namn:";
            // 
            // txtChangeName
            // 
            txtChangeName.Location = new Point(651, 681);
            txtChangeName.Name = "txtChangeName";
            txtChangeName.Size = new Size(238, 39);
            txtChangeName.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(466, 747);
            label6.Name = "label6";
            label6.Size = new Size(179, 26);
            label6.TabIndex = 13;
            label6.Text = "Ändra intervall:";
            // 
            // cmbChangeInterval
            // 
            cmbChangeInterval.FormattingEnabled = true;
            cmbChangeInterval.Location = new Point(650, 739);
            cmbChangeInterval.Name = "cmbChangeInterval";
            cmbChangeInterval.Size = new Size(238, 40);
            cmbChangeInterval.TabIndex = 14;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(965, 733);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(250, 46);
            btnSaveChanges.TabIndex = 15;
            btnSaveChanges.Text = "Spara ändringar";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 119);
            label7.Name = "label7";
            label7.Size = new Size(246, 32);
            label7.TabIndex = 16;
            label7.Text = "Sortera efter kategori:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(291, 111);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(242, 40);
            comboBox3.TabIndex = 17;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(39, 171);
            listView1.Name = "listView1";
            listView1.Size = new Size(716, 388);
            listView1.TabIndex = 18;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Namn";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Titel";
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kategori";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Antal avsnitt";
            columnHeader4.Width = 150;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 32;
            listBox2.Location = new Point(1128, 331);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(287, 228);
            listBox2.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1128, 277);
            label8.Name = "label8";
            label8.Size = new Size(246, 26);
            label8.TabIndex = 20;
            label8.Text = "Beskrivning av avsnitt:";
            // 
            // LibraryPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1441, 962);
            Controls.Add(label8);
            Controls.Add(listBox2);
            Controls.Add(listView1);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(btnSaveChanges);
            Controls.Add(cmbChangeInterval);
            Controls.Add(label6);
            Controls.Add(txtChangeName);
            Controls.Add(label5);
            Controls.Add(cmbChangeCategory);
            Controls.Add(vScrollBar1);
            Controls.Add(btnChange);
            Controls.Add(btnDelete);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "LibraryPage";
            Text = "LibraryPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Button btnDelete;
        private Button btnChange;
        private VScrollBar vScrollBar1;
        private ComboBox cmbChangeCategory;
        private Label label5;
        private TextBox txtChangeName;
        private Label label6;
        private ComboBox cmbChangeInterval;
        private Button btnSaveChanges;
        private Label label7;
        private ComboBox comboBox3;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListBox listBox2;
        private Label label8;
    }
}