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

                if ((!validationController.CheckIfStringIsEmpty(urlText)) && (!validationController.CheckIfStringIsEmpty(nameText)) && (!validationController.CheckIfUrlExist(urlText)) && (!validationController.CheckIfNameExist(nameText)))

                {
                    controller.CreatePod(txtUrl.Text, txtName.Text, cmbCategory.Text);
                    var confirmResult = MessageBox.Show("Ny podd har lagts till!", "", MessageBoxButtons.OK);
                    await Task.Delay(1000);
                }

                else
                {

                    var confirmResult = MessageBox.Show("Url och namn måste vara ifyllda & namn & podd finns redan!", "", MessageBoxButtons.OK);

                }
        }
    }
}
