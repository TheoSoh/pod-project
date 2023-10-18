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
            panel1.SuspendLayout();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(header);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(2175, 213);
            panel1.TabIndex = 0;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top;
            header.AutoSize = true;
            header.Font = new Font("Segoe UI", 28.25F, FontStyle.Regular, GraphicsUnit.Point);
            header.Location = new Point(938, 41);
            header.Margin = new Padding(6, 0, 6, 0);
            header.Name = "header";
            header.Size = new Size(272, 101);
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
            menuPanel.Location = new Point(0, 213);
            menuPanel.Margin = new Padding(6, 6, 6, 6);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(260, 1154);
            menuPanel.TabIndex = 1;
            // 
            // btnManageCategories
            // 
            btnManageCategories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnManageCategories.Location = new Point(19, 294);
            btnManageCategories.Margin = new Padding(6, 6, 6, 6);
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.Size = new Size(223, 128);
            btnManageCategories.TabIndex = 2;
            btnManageCategories.Text = "Hantera kategorier";
            btnManageCategories.UseVisualStyleBackColor = true;
            // 
            // btnAddPod
            // 
            btnAddPod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddPod.Location = new Point(19, 154);
            btnAddPod.Margin = new Padding(6, 6, 6, 6);
            btnAddPod.Name = "btnAddPod";
            btnAddPod.Size = new Size(223, 128);
            btnAddPod.TabIndex = 1;
            btnAddPod.Text = "Lägg till pod";
            btnAddPod.UseVisualStyleBackColor = true;
            btnAddPod.Click += btnAddPod_Click;
            // 
            // btnLibrary
            // 
            btnLibrary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLibrary.Location = new Point(19, 13);
            btnLibrary.Margin = new Padding(6, 6, 6, 6);
            btnLibrary.Name = "btnLibrary";
            btnLibrary.Size = new Size(223, 128);
            btnLibrary.TabIndex = 0;
            btnLibrary.Text = "Mina poddar";
            btnLibrary.UseVisualStyleBackColor = true;
            // 
            // pagePanel
            // 
            pagePanel.Location = new Point(258, 213);
            pagePanel.Margin = new Padding(6, 6, 6, 6);
            pagePanel.Name = "pagePanel";
            pagePanel.Size = new Size(1917, 1154);
            pagePanel.TabIndex = 2;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2175, 1367);
            Controls.Add(pagePanel);
            Controls.Add(menuPanel);
            Controls.Add(panel1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "StartPage";
            Text = "StartPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuPanel.ResumeLayout(false);
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
    }
}