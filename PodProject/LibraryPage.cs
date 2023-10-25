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
        string selectedPodTitle;
        ListViewItem selectedItem;
        public LibraryPage()
        {
            InitializeComponent();
            podController = new PodController();
            categoryController = new CategoryController();
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
            List<Pod> podList = podController.podHasCategory(cmbCategories.Text);
            foreach (Pod pod in podList)
            {
                string[] podInfo = { pod.Name, pod.Title, pod.Category, pod.Episodes.Count.ToString() };
                ListViewItem item = new ListViewItem(podInfo);
                listViewPods.Items.Add(item);
            }
        }

       
        
        private void FillPodTable()
        {
            listViewPods.Items.Clear();
            foreach (Pod pod in podController.GetPodList())
            {
                string[] podInfo = { pod.Name, pod.Title, pod.Category, pod.Episodes.Count.ToString() };
                ListViewItem item = new ListViewItem(podInfo);
                listViewPods.Items.Add(item);
            }
        }
        
        private void listViewPods_SelectedIndexChanged(object sender, EventArgs e)
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
            }
        }

        private void listBoxEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxDescription.Text = "";
            if (listBoxEpisodes.SelectedItems.Count > 0)
            {
                string selectedEpisodeTitle = listBoxEpisodes.SelectedItem.ToString();
                List<Episode> selectedPodsEpisodes = podController.GetPodByPodTitle(selectedPodTitle).Episodes;
                Episode selectedEpisode = selectedPodsEpisodes.FirstOrDefault(e => e.Title.Equals(selectedEpisodeTitle));
                txtBoxDescription.Text = selectedEpisode.Description;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (listViewPods.SelectedItems.Count > 0)
            {
                string selectedPodCategoryCmc = cmbChangeCategory.SelectedItem.ToString();
                Pod podToChange = podController.GetPodByPodTitle(selectedPodTitle);


                categoryController.UpdateCategoryXml(podToChange.Category, selectedPodCategoryCmc, podToChange.Title);
                FillPodTable();
                cmbChangeCategory.SelectedIndex = -1;
            }
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            if (listViewPods.SelectedItems.Count > 0)
            {
                string newName = txtChangeName.Text;
                Pod podToChange = podController.GetPodByPodTitle(selectedPodTitle);
                if (!ValidationController.CheckIfStringIsEmpty(newName))
                {
                    categoryController.UpdateNameXml(podToChange.Name, newName, podToChange.Title);
                    FillPodTable();
                    txtChangeName.Clear();
                    var confirmResult = MessageBox.Show("Namnet på den valda poden har ändrats!", "", MessageBoxButtons.OK);
                }
                else
                {
                    var confirmResult = MessageBox.Show("Ett namn måste fyllas i!", "", MessageBoxButtons.OK);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewPods.SelectedItems.Count > 0)
            {

                Pod podToChange = podController.GetPodByPodTitle(selectedPodTitle);


                podController.DeletePodXml(podToChange.Title);
                FillPodTable();

            }
        }

        private void btnShowAllCategories_Click(object sender, EventArgs e)
        {
            FillPodTable();
        }
    }
}
