namespace FolderCreatorApplication
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.button_create = new System.Windows.Forms.Button();
            this.label_targetFolder = new System.Windows.Forms.Label();
            this.textBox_targetFolder = new System.Windows.Forms.TextBox();
            this.button_selectFolder = new System.Windows.Forms.Button();
            this.label_commonFolderName = new System.Windows.Forms.Label();
            this.textBox_commonFolderName = new System.Windows.Forms.TextBox();
            this.label_and = new System.Windows.Forms.Label();
            this.label_between = new System.Windows.Forms.Label();
            this.numUD_rangeEnd = new System.Windows.Forms.NumericUpDown();
            this.numUD_rangeStart = new System.Windows.Forms.NumericUpDown();
            this.listView_preview = new System.Windows.Forms.ListView();
            this.imageList_preview = new System.Windows.Forms.ImageList(this.components);
            this.label_preview = new System.Windows.Forms.Label();
            this.label_foldersCount = new System.Windows.Forms.Label();
            this.label_numericRange = new System.Windows.Forms.Label();
            this.label_folders = new System.Windows.Forms.Label();
            this.folderBrowserDialog_main = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_rangeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_rangeStart)).BeginInit();
            this.SuspendLayout();
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(234, 313);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 14;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // label_targetFolder
            // 
            this.label_targetFolder.AutoSize = true;
            this.label_targetFolder.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label_targetFolder.Location = new System.Drawing.Point(13, 14);
            this.label_targetFolder.Name = "label_targetFolder";
            this.label_targetFolder.Size = new System.Drawing.Size(74, 13);
            this.label_targetFolder.TabIndex = 0;
            this.label_targetFolder.Text = "Target folder:";
            // 
            // textBox_targetFolder
            // 
            this.textBox_targetFolder.Location = new System.Drawing.Point(16, 31);
            this.textBox_targetFolder.Name = "textBox_targetFolder";
            this.textBox_targetFolder.Size = new System.Drawing.Size(247, 20);
            this.textBox_targetFolder.TabIndex = 1;
            // 
            // button_selectFolder
            // 
            this.button_selectFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_selectFolder.Location = new System.Drawing.Point(269, 29);
            this.button_selectFolder.Name = "button_selectFolder";
            this.button_selectFolder.Size = new System.Drawing.Size(40, 23);
            this.button_selectFolder.TabIndex = 2;
            this.button_selectFolder.Text = "...";
            this.button_selectFolder.UseVisualStyleBackColor = true;
            this.button_selectFolder.Click += new System.EventHandler(this.button_selectFolder_Click);
            // 
            // label_commonFolderName
            // 
            this.label_commonFolderName.AutoSize = true;
            this.label_commonFolderName.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label_commonFolderName.Location = new System.Drawing.Point(13, 67);
            this.label_commonFolderName.Name = "label_commonFolderName";
            this.label_commonFolderName.Size = new System.Drawing.Size(112, 13);
            this.label_commonFolderName.TabIndex = 3;
            this.label_commonFolderName.Text = "Common folder name:";
            // 
            // textBox_commonFolderName
            // 
            this.textBox_commonFolderName.Location = new System.Drawing.Point(16, 83);
            this.textBox_commonFolderName.Name = "textBox_commonFolderName";
            this.textBox_commonFolderName.Size = new System.Drawing.Size(293, 20);
            this.textBox_commonFolderName.TabIndex = 4;
            this.textBox_commonFolderName.Text = "New Folder ";
            // 
            // label_and
            // 
            this.label_and.AutoSize = true;
            this.label_and.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.label_and.Location = new System.Drawing.Point(178, 139);
            this.label_and.Name = "label_and";
            this.label_and.Size = new System.Drawing.Size(25, 13);
            this.label_and.TabIndex = 8;
            this.label_and.Text = "and";
            // 
            // label_between
            // 
            this.label_between.AutoSize = true;
            this.label_between.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.label_between.Location = new System.Drawing.Point(17, 139);
            this.label_between.Name = "label_between";
            this.label_between.Size = new System.Drawing.Size(49, 13);
            this.label_between.TabIndex = 6;
            this.label_between.Text = "Between";
            // 
            // numUD_rangeEnd
            // 
            this.numUD_rangeEnd.Location = new System.Drawing.Point(209, 135);
            this.numUD_rangeEnd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUD_rangeEnd.Name = "numUD_rangeEnd";
            this.numUD_rangeEnd.Size = new System.Drawing.Size(100, 20);
            this.numUD_rangeEnd.TabIndex = 9;
            // 
            // numUD_rangeStart
            // 
            this.numUD_rangeStart.Location = new System.Drawing.Point(72, 135);
            this.numUD_rangeStart.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUD_rangeStart.Name = "numUD_rangeStart";
            this.numUD_rangeStart.Size = new System.Drawing.Size(100, 20);
            this.numUD_rangeStart.TabIndex = 7;
            // 
            // listView_preview
            // 
            this.listView_preview.LargeImageList = this.imageList_preview;
            this.listView_preview.Location = new System.Drawing.Point(20, 189);
            this.listView_preview.MultiSelect = false;
            this.listView_preview.Name = "listView_preview";
            this.listView_preview.Size = new System.Drawing.Size(289, 118);
            this.listView_preview.SmallImageList = this.imageList_preview;
            this.listView_preview.StateImageList = this.imageList_preview;
            this.listView_preview.TabIndex = 13;
            this.listView_preview.UseCompatibleStateImageBehavior = false;
            this.listView_preview.View = System.Windows.Forms.View.List;
            // 
            // imageList_preview
            // 
            this.imageList_preview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_preview.ImageStream")));
            this.imageList_preview.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_preview.Images.SetKeyName(0, "folder");
            this.imageList_preview.Images.SetKeyName(1, "success");
            // 
            // label_preview
            // 
            this.label_preview.AutoSize = true;
            this.label_preview.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label_preview.Location = new System.Drawing.Point(20, 173);
            this.label_preview.Name = "label_preview";
            this.label_preview.Size = new System.Drawing.Size(49, 13);
            this.label_preview.TabIndex = 10;
            this.label_preview.Text = "Preview:";
            // 
            // label_foldersCount
            // 
            this.label_foldersCount.AutoEllipsis = true;
            this.label_foldersCount.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label_foldersCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_foldersCount.Location = new System.Drawing.Point(183, 173);
            this.label_foldersCount.Name = "label_foldersCount";
            this.label_foldersCount.Size = new System.Drawing.Size(87, 13);
            this.label_foldersCount.TabIndex = 11;
            this.label_foldersCount.Text = "0";
            this.label_foldersCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_numericRange
            // 
            this.label_numericRange.AutoSize = true;
            this.label_numericRange.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label_numericRange.Location = new System.Drawing.Point(17, 118);
            this.label_numericRange.Name = "label_numericRange";
            this.label_numericRange.Size = new System.Drawing.Size(80, 13);
            this.label_numericRange.TabIndex = 5;
            this.label_numericRange.Text = "Numeric range:";
            // 
            // label_folders
            // 
            this.label_folders.AutoSize = true;
            this.label_folders.Location = new System.Drawing.Point(269, 173);
            this.label_folders.Name = "label_folders";
            this.label_folders.Size = new System.Drawing.Size(40, 13);
            this.label_folders.TabIndex = 12;
            this.label_folders.Text = "folders";
            // 
            // Form_Main
            // 
            this.AcceptButton = this.button_create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 350);
            this.Controls.Add(this.label_folders);
            this.Controls.Add(this.label_numericRange);
            this.Controls.Add(this.numUD_rangeStart);
            this.Controls.Add(this.label_foldersCount);
            this.Controls.Add(this.label_and);
            this.Controls.Add(this.label_between);
            this.Controls.Add(this.numUD_rangeEnd);
            this.Controls.Add(this.label_preview);
            this.Controls.Add(this.listView_preview);
            this.Controls.Add(this.label_commonFolderName);
            this.Controls.Add(this.button_selectFolder);
            this.Controls.Add(this.textBox_commonFolderName);
            this.Controls.Add(this.textBox_targetFolder);
            this.Controls.Add(this.label_targetFolder);
            this.Controls.Add(this.button_create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Creator";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_rangeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_rangeStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Label label_targetFolder;
        private System.Windows.Forms.TextBox textBox_targetFolder;
        private System.Windows.Forms.Button button_selectFolder;
        private System.Windows.Forms.Label label_commonFolderName;
        private System.Windows.Forms.TextBox textBox_commonFolderName;
        private System.Windows.Forms.Label label_and;
        private System.Windows.Forms.Label label_between;
        private System.Windows.Forms.NumericUpDown numUD_rangeEnd;
        private System.Windows.Forms.NumericUpDown numUD_rangeStart;
        private System.Windows.Forms.ListView listView_preview;
        private System.Windows.Forms.Label label_preview;
        private System.Windows.Forms.Label label_foldersCount;
        private System.Windows.Forms.Label label_numericRange;
        private System.Windows.Forms.Label label_folders;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_main;
        private System.Windows.Forms.ImageList imageList_preview;
    }
}