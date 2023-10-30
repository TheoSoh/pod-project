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
using Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace PodProject
{
    public partial class AddCategory : Form
    {
        CategoryController categoryController;
        ValidationController validationController;

        public AddCategory()
        {
            InitializeComponent();
            categoryController = new CategoryController();
            validationController = new ValidationController();
            FillCombobox();
        }

        private void cmbSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string newCategory = txtNewCategory.Text;
           
                if (validationController.CheckIfStringIsEmpty(newCategory))
                {
                    MessageBox.Show("Den nya kategorin måste ha ett namn!", "", MessageBoxButtons.OK);
                    return;
                }
                    
                        
                        
                 if(validationController.CheckIfCategoryExist(newCategory))
                    {
                    MessageBox.Show("Namnet på kategorin finns redan! Vänligen välj ett annat namn", "", MessageBoxButtons.OK);
                    return;
                    }

                
                    categoryController.addNewCategoryToTxt(newCategory);
                    cmbSelectCategory.Items.Clear();
                    FillCombobox();
                    var confirmResult = MessageBox.Show("Ny kategori har lagts till!", "", MessageBoxButtons.OK);
                
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string? choosenCategory = cmbSelectCategory.SelectedItem?.ToString();

                if (validationController.CheckIfStringIsEmpty(choosenCategory))
                {
                    MessageBox.Show("Vänligen välj en kategori", "", MessageBoxButtons.OK);
                    return;
                }

                var confirmResult = MessageBox.Show("Vill du verkligen radera denna kategori?", "", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    categoryController.removeCategory(choosenCategory);
                    categoryController.RemoveCategoryXml(choosenCategory);
                    cmbSelectCategory.Items.Clear();
                    FillCombobox();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void FillCombobox()
        {
            try
            {

                List<string> categorys = categoryController.ReadAllCategorys();
                foreach (string category in categorys)
                {
                    cmbSelectCategory.Items.Add(category);
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

             }
        }

        private void btnChangeNameCat_Click(object sender, EventArgs e)

        {
            try 
            { 
                string? categoryName = cmbSelectCategory.SelectedItem?.ToString();
                string newCategoryName = txtNewNameCategory.Text;

            
                if (validationController.CheckIfStringIsEmpty(categoryName))
                {
                    MessageBox.Show("Vänligen välj en kategori att ändra namn på!", "", MessageBoxButtons.OK);
                    return;
                }


                if (validationController.CheckIfStringIsEmpty(newCategoryName))
                {
                    MessageBox.Show("Kategorin måste ha ett namn!", "", MessageBoxButtons.OK);
                    return;

                }

                    categoryController.Update(categoryName, newCategoryName);

                    categoryController.ReplaceCategoryNameXml(categoryName, newCategoryName);
                    cmbSelectCategory.Items.Clear();
                    FillCombobox();
                var confirmResult = MessageBox.Show("Den valda kategorin har nu ett nytt namn!", "", MessageBoxButtons.OK);
                

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
