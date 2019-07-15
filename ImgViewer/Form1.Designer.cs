namespace ImgViewer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tablePictures = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainerTreeVsFolder = new System.Windows.Forms.SplitContainer();
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainerFolderVsImages = new System.Windows.Forms.SplitContainer();
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.flowLayoutFolderView = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutToolsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.textDirectory = new System.Windows.Forms.TextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablePictures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTreeVsFolder)).BeginInit();
            this.splitContainerTreeVsFolder.Panel1.SuspendLayout();
            this.splitContainerTreeVsFolder.Panel2.SuspendLayout();
            this.splitContainerTreeVsFolder.SuspendLayout();
            this.tableLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFolderVsImages)).BeginInit();
            this.splitContainerFolderVsImages.Panel1.SuspendLayout();
            this.splitContainerFolderVsImages.Panel2.SuspendLayout();
            this.splitContainerFolderVsImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutToolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "file-empty.png");
            this.imageList1.Images.SetKeyName(1, "drive.png");
            this.imageList1.Images.SetKeyName(2, "folder2.png");
            this.imageList1.Images.SetKeyName(3, "image.png");
            this.imageList1.Images.SetKeyName(4, "text2.png");
            this.imageList1.Images.SetKeyName(5, "zip.png");
            // 
            // tablePictures
            // 
            this.tablePictures.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tablePictures.ColumnCount = 1;
            this.tablePictures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePictures.Controls.Add(this.splitContainerTreeVsFolder, 0, 2);
            this.tablePictures.Controls.Add(this.menuStrip1, 0, 0);
            this.tablePictures.Controls.Add(this.flowLayoutToolsPanel, 0, 1);
            this.tablePictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePictures.Location = new System.Drawing.Point(0, 0);
            this.tablePictures.Margin = new System.Windows.Forms.Padding(0);
            this.tablePictures.Name = "tablePictures";
            this.tablePictures.RowCount = 4;
            this.tablePictures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tablePictures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tablePictures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePictures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePictures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePictures.Size = new System.Drawing.Size(704, 561);
            this.tablePictures.TabIndex = 1;
            // 
            // splitContainerTreeVsFolder
            // 
            this.splitContainerTreeVsFolder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerTreeVsFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTreeVsFolder.Location = new System.Drawing.Point(3, 53);
            this.splitContainerTreeVsFolder.Name = "splitContainerTreeVsFolder";
            // 
            // splitContainerTreeVsFolder.Panel1
            // 
            this.splitContainerTreeVsFolder.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainerTreeVsFolder.Panel1.Controls.Add(this.treeViewMain);
            // 
            // splitContainerTreeVsFolder.Panel2
            // 
            this.splitContainerTreeVsFolder.Panel2.Controls.Add(this.tableLayoutMain);
            this.splitContainerTreeVsFolder.Size = new System.Drawing.Size(698, 485);
            this.splitContainerTreeVsFolder.SplitterDistance = 304;
            this.splitContainerTreeVsFolder.SplitterWidth = 6;
            this.splitContainerTreeVsFolder.TabIndex = 2;
            this.splitContainerTreeVsFolder.TabStop = false;
            // 
            // treeViewMain
            // 
            this.treeViewMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.treeViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.treeViewMain.ImageIndex = 0;
            this.treeViewMain.ImageList = this.imageList1;
            this.treeViewMain.Location = new System.Drawing.Point(0, 0);
            this.treeViewMain.Margin = new System.Windows.Forms.Padding(0);
            this.treeViewMain.Name = "treeViewMain";
            this.treeViewMain.SelectedImageIndex = 0;
            this.treeViewMain.Size = new System.Drawing.Size(304, 485);
            this.treeViewMain.TabIndex = 1;
            this.treeViewMain.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewMain_BeforeExpand);
            this.treeViewMain.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewMain_NodeMouseClick);
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.AutoSize = true;
            this.tableLayoutMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.splitContainerFolderVsImages, 0, 0);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 1;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 485F));
            this.tableLayoutMain.Size = new System.Drawing.Size(388, 485);
            this.tableLayoutMain.TabIndex = 2;
            // 
            // splitContainerFolderVsImages
            // 
            this.splitContainerFolderVsImages.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerFolderVsImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFolderVsImages.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFolderVsImages.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerFolderVsImages.Name = "splitContainerFolderVsImages";
            this.splitContainerFolderVsImages.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFolderVsImages.Panel1
            // 
            this.splitContainerFolderVsImages.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainerFolderVsImages.Panel1.Controls.Add(this.mainPicture);
            // 
            // splitContainerFolderVsImages.Panel2
            // 
            this.splitContainerFolderVsImages.Panel2.Controls.Add(this.flowLayoutFolderView);
            this.splitContainerFolderVsImages.Size = new System.Drawing.Size(388, 485);
            this.splitContainerFolderVsImages.SplitterDistance = 213;
            this.splitContainerFolderVsImages.SplitterWidth = 2;
            this.splitContainerFolderVsImages.TabIndex = 0;
            this.splitContainerFolderVsImages.TabStop = false;
            // 
            // mainPicture
            // 
            this.mainPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPicture.Location = new System.Drawing.Point(0, 0);
            this.mainPicture.Margin = new System.Windows.Forms.Padding(0);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(388, 213);
            this.mainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPicture.TabIndex = 0;
            this.mainPicture.TabStop = false;
            this.mainPicture.Click += new System.EventHandler(this.MainPicture_Click);
            // 
            // flowLayoutFolderView
            // 
            this.flowLayoutFolderView.AutoScroll = true;
            this.flowLayoutFolderView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutFolderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutFolderView.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutFolderView.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutFolderView.Name = "flowLayoutFolderView";
            this.flowLayoutFolderView.Size = new System.Drawing.Size(388, 270);
            this.flowLayoutFolderView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.directoryToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.directoryToolStripMenuItem.Text = "Directory";
            this.directoryToolStripMenuItem.Click += new System.EventHandler(this.DirrectoryToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click_1);
            // 
            // flowLayoutToolsPanel
            // 
            this.flowLayoutToolsPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutToolsPanel.Controls.Add(this.buttonRefresh);
            this.flowLayoutToolsPanel.Controls.Add(this.buttonBack);
            this.flowLayoutToolsPanel.Controls.Add(this.buttonForward);
            this.flowLayoutToolsPanel.Controls.Add(this.textDirectory);
            this.flowLayoutToolsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutToolsPanel.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutToolsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutToolsPanel.Name = "flowLayoutToolsPanel";
            this.flowLayoutToolsPanel.Size = new System.Drawing.Size(704, 25);
            this.flowLayoutToolsPanel.TabIndex = 4;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.BackgroundImage = global::ImgViewer.Properties.Resources.refresh_arrow;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefresh.Location = new System.Drawing.Point(2, 2);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(20, 20);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BackgroundImage = global::ImgViewer.Properties.Resources.left_arrow;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.Location = new System.Drawing.Point(26, 2);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(20, 20);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForward.BackgroundImage = global::ImgViewer.Properties.Resources.right_arrow;
            this.buttonForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonForward.Location = new System.Drawing.Point(50, 2);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(2);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(20, 20);
            this.buttonForward.TabIndex = 3;
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.ButtonForward_Click);
            // 
            // textDirectory
            // 
            this.textDirectory.Location = new System.Drawing.Point(75, 3);
            this.textDirectory.Name = "textDirectory";
            this.textDirectory.Size = new System.Drawing.Size(400, 20);
            this.textDirectory.TabIndex = 6;
            this.textDirectory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextDirectory_KeyDown);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.tablePictures);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.Text = "ImageViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tablePictures.ResumeLayout(false);
            this.tablePictures.PerformLayout();
            this.splitContainerTreeVsFolder.Panel1.ResumeLayout(false);
            this.splitContainerTreeVsFolder.Panel2.ResumeLayout(false);
            this.splitContainerTreeVsFolder.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTreeVsFolder)).EndInit();
            this.splitContainerTreeVsFolder.ResumeLayout(false);
            this.tableLayoutMain.ResumeLayout(false);
            this.splitContainerFolderVsImages.Panel1.ResumeLayout(false);
            this.splitContainerFolderVsImages.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFolderVsImages)).EndInit();
            this.splitContainerFolderVsImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutToolsPanel.ResumeLayout(false);
            this.flowLayoutToolsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tablePictures;
        private System.Windows.Forms.SplitContainer splitContainerTreeVsFolder;
        private System.Windows.Forms.SplitContainer splitContainerFolderVsImages;
        private System.Windows.Forms.TreeView treeViewMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.PictureBox mainPicture;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutFolderView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutToolsPanel;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.TextBox textDirectory;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

