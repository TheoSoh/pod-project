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
using BLL;

namespace PodProject
{
    public partial class AddPodPage : Form
    {
        PodController controller;
        CategoryController categoryController;
        public AddPodPage()
        {
            InitializeComponent();
            controller = new PodController();
            categoryController = new CategoryController();
            List<string> categorys = categoryController.ReadAllCategorys();
            foreach (string category in categorys)
            {
                cmbCategory.Items.Add(category);
            }

        }

        private void AddPodPage_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            controller.CreatePod(txtUrl.Text, txtName.Text, cmbCategory.Text);
        }
    }
}
