using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Controllers;

namespace PodProject
{
    public partial class AddPodPage : Form
    {
        PodController controller;
        public AddPodPage()
        {
            InitializeComponent();
            controller = new PodController();
        }

        private void AddPodPage_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            controller.CreatePod(txtName.Text,txtUrl.Text);
        }
    }
}
