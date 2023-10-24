using BLL.Controllers;
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
    public partial class AddCategory : Form
    {
        CategoryController categoryController;
        public AddCategory()
        {
            InitializeComponent();
            categoryController = new CategoryController();
            FillCombobox();
        }

        private void cmbSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string newCategory = txtNewCategory.Text;
            categoryController.addNewCategoryToTxt(newCategory);
            cmbSelectCategory.Items.Clear();

            FillCombobox();


        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string choosenCategory = cmbSelectCategory.SelectedItem.ToString();
            categoryController.removeCategory(choosenCategory);

            cmbSelectCategory.Items.Clear();
            FillCombobox();

        }

        public void FillCombobox()
        {

            List<string> categorys = categoryController.ReadAllCategorys();
            foreach (string category in categorys)
            {
                cmbSelectCategory.Items.Add(category);
            }
        }

        private void btnChangeNameCat_Click(object sender, EventArgs e)

        {
            string categoryName = cmbSelectCategory.SelectedItem.ToString();
            string newCategoryName = txtNewNameCategory.Text;

            categoryController.ReplaceCategoryName(categoryName, newCategoryName);

            cmbSelectCategory.Items.Clear();
            FillCombobox();
        }
    }
}
