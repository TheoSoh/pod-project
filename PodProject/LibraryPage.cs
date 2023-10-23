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
            List<Pod> podList = podController.GetPodList();
            foreach (Pod pod in podList)
            {
                string[] podInfo = { pod.Name, pod.Title, pod.Category, pod.Episodes.Count.ToString() };
                ListViewItem item = new ListViewItem(podInfo);
                listViewPods.Items.Add(item);
            }
        }

    }
}
