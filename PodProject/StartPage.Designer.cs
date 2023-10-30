namespace PodProject
{
    partial class StartPage
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
            panel1 = new Panel();
            header = new Label();
            menuPanel = new Panel();
            btnManageCategories = new Button();
            btnAddPod = new Button();
            btnLibrary = new Button();
            pagePanel = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            menuPanel.SuspendLayout();
            pagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(header);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1477, 109);
            panel1.TabIndex = 0;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top;
            header.AutoSize = true;
            header.Font = new Font("Segoe UI", 28.25F, FontStyle.Regular, GraphicsUnit.Point);
            header.Location = new Point(625, 15);
            header.Margin = new Padding(5, 0, 5, 0);
            header.Name = "header";
            header.Size = new Size(204, 76);
            header.TabIndex = 0;
            header.Text = "PodLib";
            // 
            // menuPanel
            // 
            menuPanel.BackColor = SystemColors.AppWorkspace;
            menuPanel.Controls.Add(btnManageCategories);
            menuPanel.Controls.Add(btnAddPod);
            menuPanel.Controls.Add(btnLibrary);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 109);
            menuPanel.Margin = new Padding(5, 5, 5, 5);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(162, 818);
            menuPanel.TabIndex = 1;
            // 
            // btnManageCategories
            // 
            btnManageCategories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnManageCategories.Location = new Point(0, 222);
            btnManageCategories.Margin = new Padding(5, 5, 5, 5);
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.Size = new Size(162, 88);
            btnManageCategories.TabIndex = 2;
            btnManageCategories.Text = "Hantera kategorier";
            btnManageCategories.UseVisualStyleBackColor = true;
            btnManageCategories.Click += btnManageCategories_Click;
            // 
            // btnAddPod
            // 
            btnAddPod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddPod.Location = new Point(0, 125);
            btnAddPod.Margin = new Padding(5, 5, 5, 5);
            btnAddPod.Name = "btnAddPod";
            btnAddPod.Size = new Size(162, 72);
            btnAddPod.TabIndex = 1;
            btnAddPod.Text = "Lägg till pod";
            btnAddPod.UseVisualStyleBackColor = true;
            btnAddPod.Click += btnAddPod_Click;
            // 
            // btnLibrary
            // 
            btnLibrary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLibrary.Location = new Point(0, 25);
            btnLibrary.Margin = new Padding(5, 5, 5, 5);
            btnLibrary.Name = "btnLibrary";
            btnLibrary.Size = new Size(162, 75);
            btnLibrary.TabIndex = 0;
            btnLibrary.Text = "Mina poddar";
            btnLibrary.UseVisualStyleBackColor = true;
            btnLibrary.Click += btnLibrary_Click;
            // 
            // pagePanel
            // 
            pagePanel.BackColor = SystemColors.InactiveCaption;
            pagePanel.Controls.Add(label1);
            pagePanel.Dock = DockStyle.Fill;
            pagePanel.Location = new Point(162, 109);
            pagePanel.Margin = new Padding(5, 5, 5, 5);
            pagePanel.Name = "pagePanel";
            pagePanel.Size = new Size(1315, 818);
            pagePanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Nirmala UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(308, 96);
            label1.Name = "label1";
            label1.Size = new Size(681, 360);
            label1.TabIndex = 0;
            label1.Text = "PodLib är ett egendesignat pod\r\nbibliotek som är anpassat just för dig!\r\n\r\nLägg till dina favoritpoddar och \r\nordna efter egenvalda kategorier och namn,\r\n\r\n\r\nHoppas du får en bra upplevelse!";
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 927);
            Controls.Add(pagePanel);
            Controls.Add(menuPanel);
            Controls.Add(panel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "StartPage";
            Text = "StartPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuPanel.ResumeLayout(false);
            pagePanel.ResumeLayout(false);
            pagePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel menuPanel;
        private Label header;
        private Button btnLibrary;
        private Button btnAddPod;
        private Button btnManageCategories;
        private Panel pagePanel;
        private Label label1;
    }
}