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
        public LibraryPage()
        {
            InitializeComponent();
            podController = new PodController();
            categoryController = new CategoryController();
            List<string> categorys = categoryController.ReadAllCategorys();
            foreach (string category in categorys)
            {
                cmbCategories.Items.Add(category);
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
                ListViewItem selectedItem = listViewPods.SelectedItems[0];
                selectedPodTitle = selectedItem.SubItems[1].Text;
                foreach (Episode anEpisode in podController.GetEpisodesByPodTitle(selectedPodTitle))
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
                List<Episode> selectedPodsEpisodes = podController.GetEpisodesByPodTitle(selectedPodTitle);
                Episode selectedEpisode = selectedPodsEpisodes.FirstOrDefault(e => e.Title.Equals(selectedEpisodeTitle));
                txtBoxDescription.Text = selectedEpisode.Description;
            }
        }
    }
}
