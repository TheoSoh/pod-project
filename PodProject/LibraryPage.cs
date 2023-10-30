using BLL;
using Models;
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
    public partial class LibraryPage : Form
    {
        PodController podController;
        CategoryController categoryController;
        ValidationController validationController;
        string selectedPodTitle;
        ListViewItem selectedItem;
        public LibraryPage()
        {
            InitializeComponent();
            podController = new PodController();
            categoryController = new CategoryController();
            validationController = new ValidationController();
            List<string> categorys = categoryController.ReadAllCategorys();
            foreach (string category in categorys)
            {
                cmbCategories.Items.Add(category);
                cmbChangeCategory.Items.Add(category);
            }
            FillPodTable();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            listViewPods.Items.Clear();
            try
            {
                List<Pod> podList = podController.podHasCategory(cmbCategories.Text);

                foreach (Pod pod in podList)
                {
                    string[] podInfo = { pod.Name, pod.Title, pod.Category, pod.Episodes.Count.ToString() };
                    ListViewItem item = new ListViewItem(podInfo);
                    listViewPods.Items.Add(item);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void FillPodTable()
        {
            try
            {
                listViewPods.Items.Clear();
                foreach (Pod pod in podController.GetPodList())
                {
                    string[] podInfo = { pod.Name, pod.Title, pod.Category, pod.Episodes.Count.ToString() };
                    ListViewItem item = new ListViewItem(podInfo);
                    listViewPods.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void listViewPods_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                listBoxEpisodes.Items.Clear();
                if (listViewPods.SelectedItems.Count > 0)
                {
                    selectedItem = listViewPods.SelectedItems[0];
                    selectedPodTitle = selectedItem.SubItems[1].Text;
                    foreach (Episode anEpisode in podController.GetPodByPodTitle(selectedPodTitle).Episodes)
                    {
                        listBoxEpisodes.Items.Add(anEpisode.Title);
                    }

                    txtBoxDescription.Clear();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void listBoxEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtBoxDescription.Text = "";
                if (listBoxEpisodes.SelectedItems.Count > 0)
                {
                    string selectedEpisodeTitle = listBoxEpisodes.SelectedItem.ToString();
                    List<Episode> selectedPodsEpisodes = podController.GetPodByPodTitle(selectedPodTitle).Episodes;
                    Episode selectedEpisode = selectedPodsEpisodes.FirstOrDefault(e => e.Title.Equals(selectedEpisodeTitle));
                    txtBoxDescription.Text = selectedEpisode.Description;
                }
            } catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPods.SelectedItems.Count > 0)
                {
                    string selectedPodCategoryCmc = cmbChangeCategory.SelectedItem.ToString();
                    Pod podToChange = podController.GetPodByPodTitle(selectedPodTitle);


                    categoryController.Update(podToChange.Category, selectedPodCategoryCmc, podToChange.Title);
                    FillPodTable();
                    cmbChangeCategory.SelectedIndex = -1;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPods.SelectedItems.Count > 0)
                {
                    string newName = txtChangeName.Text;
                    Pod podToChange = podController.GetPodByPodTitle(selectedPodTitle);
                    if (!validationController.CheckIfStringIsEmpty(newName))
                    {
                        categoryController.UpdateNameXml(podToChange.Name, newName, podToChange.Title);
                        FillPodTable();
                        txtChangeName.Clear();
                        var confirmResult = MessageBox.Show("Namnet på den valda podden har ändrats!", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        var confirmResult = MessageBox.Show("Ett namn måste fyllas i!", "", MessageBoxButtons.OK);
                    }
                }
            }catch(Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPods.SelectedItems.Count > 0)
                {

                    Pod podToChange = podController.GetPodByPodTitle(selectedPodTitle);


                    podController.DeletePodXml(podToChange.Title);
                    FillPodTable();
                    listBoxEpisodes.Items.Clear();
                    txtBoxDescription.Clear();

                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnShowAllCategories_Click(object sender, EventArgs e)
        {
            FillPodTable();
        }
    }
}
