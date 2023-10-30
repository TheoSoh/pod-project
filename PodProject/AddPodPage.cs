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
using System.Diagnostics.Eventing.Reader;

namespace PodProject
{
    public partial class AddPodPage : Form
    {
        PodController controller;
        CategoryController categoryController;
        ValidationController validationController;

        public AddPodPage()
        {
            InitializeComponent();
            controller = new PodController();
            categoryController = new CategoryController();
            validationController = new ValidationController();
            List<string> categorys = categoryController.ReadAllCategorys();
            foreach (string category in categorys)
            {
                cmbCategory.Items.Add(category);
            }

        }

        private void AddPodPage_Load(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string urlText = txtUrl.Text;
            string nameText = txtName.Text;
            if (validationController.CheckIfStringIsEmpty(urlText))
            {
                MessageBox.Show("Vänligen fyll i en url!", "", MessageBoxButtons.OK);
                return;
            }
            if (validationController.CheckIfStringIsEmpty(nameText))
            {
                MessageBox.Show("Vänligen fyll i namn!", "", MessageBoxButtons.OK);
                return;
            }
            if (validationController.CheckIfUrlExist(urlText))
            {
                MessageBox.Show("Denna podd finns redan!", "", MessageBoxButtons.OK);
                return;
            }
            if (validationController.CheckIfNameExist(nameText))
            {
                MessageBox.Show("Namnet du angett finns redan!", "", MessageBoxButtons.OK);
                return;
            }
            if (!validationController.TryParseFeed(urlText))
            {
                MessageBox.Show("Ogiltigt URL format!", "", MessageBoxButtons.OK);
                return;
            }
            await Task.Delay(1000);
            controller.CreatePod(txtUrl.Text, txtName.Text, cmbCategory.Text);
            MessageBox.Show("Ny podd har lagts till!", "", MessageBoxButtons.OK);
        }
    }
}
