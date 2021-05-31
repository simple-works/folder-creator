using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FolderCreatorApplication
{
    public partial class Form_Main : Form
    {
        public FolderCreator FolderCreator { get; set; }

        public Form_Main(FolderCreator folderCreator)
        {
            InitializeComponent();
            FolderCreator = folderCreator;
            BindData();
            HandleEvents();
        }

        private void BindData()
        {
            textBox_targetFolder.DataBindings.Add("Text", FolderCreator, "TargetFolderPath",
                 false, DataSourceUpdateMode.OnPropertyChanged);

            button_create.DataBindings.Add("Enabled", FolderCreator, "HasValidData",
                false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void HandleEvents()
        {
            Load += (s, e) => UpdatePreview();

            textBox_commonFolderName.TextChanged += (s, e) => UpdatePreview();

            numUD_rangeStart.TextChanged += (s, e) => UpdatePreview();

            numUD_rangeEnd.TextChanged += (s, e) => UpdatePreview();
        }

        private void UpdatePreview()
        {
            FolderCreator.RangeStart = (int)numUD_rangeStart.Value;
            FolderCreator.RangeEnd = (int)numUD_rangeEnd.Value;
            FolderCreator.CommonFolderName = textBox_commonFolderName.Text;
            label_foldersCount.Text = FolderCreator.FoldersCount.ToString();
            listView_preview.Items.Clear();
            for (int i = FolderCreator.RangeStart; i <= FolderCreator.RangeEnd; i++)
            {
                listView_preview.Items.Add(FolderCreator.GetFolderName(i), "folder");
            }
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            try
            {
                FolderCreator.CreateFolders();
                foreach (ListViewItem item in listView_preview.Items)
                {
                    item.StateImageIndex = imageList_preview.Images.IndexOfKey("success");
                }
            }
            catch (Exception exception)
            {
                Alert.Warning(exception.Message);
            }
        }

        private void button_selectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_main.ShowDialog() == DialogResult.OK)
            {
                textBox_targetFolder.Text = folderBrowserDialog_main.SelectedPath;
            }
        }
    }
}
