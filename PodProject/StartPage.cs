using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodProject
{
    public partial class StartPage : Form
    {
        private Form activeForm = null;
        public StartPage()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pagePanel.Controls.Add(childForm);
            this.pagePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
