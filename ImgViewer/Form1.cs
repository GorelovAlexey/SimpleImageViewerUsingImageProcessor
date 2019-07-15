using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ImageProcessor;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace ImgViewer
{    
    public partial class Form1 : Form
    {
        private readonly List<string> validExtensions = new List<string>() { ".jpg", ".jpeg", ".png", ".png8", ".gif", ".bmp", ".tiff" };

        FoldersHistory FoldersHistory = new FoldersHistory();

        CancellationTokenSource cancelFolderLoading = new CancellationTokenSource();


        private string _currentDirectory;
        private string CurrentDirectory
        {
            get
            {
                return _currentDirectory;
            }
            set
            {
                try
                {
                    if (new DirectoryInfo(value).Exists)
                    {
                        cancelFolderLoading.Cancel();
                        cancelFolderLoading = new CancellationTokenSource();
                        mainPicture.Image = null;
                        if (FoldersHistory.GetCurrent() != value) FoldersHistory.Open(value);
                        textDirectory.Text = value;
                        _currentDirectory = value;
                        ViewDirectory(value);
                    }
                    else
                    {
                        textDirectory.Text = _currentDirectory;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    textDirectory.Text = _currentDirectory;
                }
                
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }


        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ProcessImage(openFileDialog1.FileName);
            }
        }

        private MemoryStream CreateThumbnail(string fileName, Size size)
        {
            var file = File.ReadAllBytes(fileName);
            var outStream = new MemoryStream();
            using (var inStream = new MemoryStream(file))
            {
                using (var imgFactory = new ImageFactory(preserveExifData: true))
                {
                    var resizeLayer = new ImageProcessor.Imaging.ResizeLayer(
                        size,
                        ImageProcessor.Imaging.ResizeMode.Stretch
                        );                    

                    imgFactory
                        .Load(inStream)
                        .Resize(resizeLayer)
                        .Save(outStream);
                }
            }
            return outStream;
        }

        private MemoryStream FullImage(string fileName)
        {
            var file = File.ReadAllBytes(fileName);
            var outStream = new MemoryStream();
            using (var inStream = new MemoryStream(file))
            {
                using (var imgFactory = new ImageFactory(preserveExifData: true))
                {
                    imgFactory
                        .Load(inStream)
                        .Save(outStream);
                }
            }
            return outStream;
        }


        private void ProcessImage(string fileName)
        {            
            mainPicture.Image = Image.FromFile(fileName);
        }

        private void DirrectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = folderBrowserDialog1.SelectedPath;
                ViewDirectory(path);
            }
        }


        /// <summary>
        /// Создаем галерею превью изображений 
        /// </summary>
        /// <param name="path"> Путь к папке из которой берутся изображения </param>
        private async void ViewDirectory(string path)
        {
            if (!Directory.Exists(path)) return;
            flowLayoutFolderView.Controls.Clear();

            DirectoryInfo info;
            FileInfo[] files;

            try
            {
                info = new DirectoryInfo(path);
                files = info.GetFiles();
                await LoadImageThumbnails(files, cancelFolderLoading.Token);           
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"Cant open path {path}");
            }
            catch (OperationCanceledException) { }

        }

        private async Task LoadImageThumbnails(FileInfo[] files, CancellationToken token)
        {
            foreach (var file in files)
            {
                token.ThrowIfCancellationRequested();
                if (validExtensions.Contains(file.Extension))
                {
                    Size size = new Size(64, 64);
                    var item = await Task.Factory.StartNew(() => new PictureBox
                    {
                        Image = Image.FromStream(FullImage(file.FullName)),
                        Size = size,
                        Name = file.FullName,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    });
                    token.ThrowIfCancellationRequested();
                    item.Parent = flowLayoutFolderView;
                    item.Click += Thumbnail_Click;
                }
            }
        }



        private void Thumbnail_Click(object sender, EventArgs e)
        {
            var obj = (PictureBox)sender;
            ProcessImage(obj.Name);
        }

    
        // Инициализация тривью
        private void InitTreeView()
        {
            treeViewMain.Nodes.Clear();

            var nodes = DrivesLayer();

            foreach (var node in nodes)
            {
                treeViewMain.Nodes.Add(node);
                var info = new DirectoryInfo(node.Name);
                if (info.Exists)
                {
                    if (new DriveInfo(node.Name).IsReady)
                    {
                        TreeLayer(node);
                    }                       
                }
            }
        }
        
        // Добавляем диски в тривью
        private List<TreeNode> DrivesLayer()
        {
            var drives = DriveInfo.GetDrives();
            var nodes = new List<TreeNode>();
            foreach (var drive in drives)
            {
                var node = new TreeNode(drive.Name, 1, 1)
                {
                    Name = drive.Name
                };
                nodes.Add(node);
            }
            return nodes;
        }

        /// <summary>
        /// Для заданной директории(представленной в виде узла дерева) 
        /// добавляем все каталоги и файлы как узлы дерева-потомки
        /// </summary>
        /// <param name="parent"> Узел дерева представляющий каталог, к которому будут добавлены потомки </param>
        /// <param name="depth"> Если больше 1 то выполняем процедуру рекурсивно для каждого каталога-потомка  </param>
        private async void TreeLayer(TreeNode parent, int depth = 1)
        {
            if (depth < 1) return;
            if (parent.Name == null) throw new Exception("TreeNode name is null");

            parent.Nodes.Clear();
            //MessageBox.Show($" {parent.Nodes.Count} {parent.Name} ");

            //DirectoryInfo
            //ДОСТУП К ДИРЕКТОРИИ
            try
            {
                var directories = Directory.GetDirectories(parent.Name);
                var files = Directory.GetFiles(parent.Name);
                //MessageBox.Show($" {directories.Count()} {files.Count()}");
                foreach (var dir in directories)
                {
                    var node = await AddNode(parent, dir);
                    TreeLayer(node, depth - 1);
                }
                foreach (var file in files)
                {
                    await AddNode(parent, file, true);
                }
                //MessageBox.Show($" {parent.Nodes.Count} {parent.Name} ");

            }
            catch (UnauthorizedAccessException)
            {
                return;
            }
        }

        /// <summary>
        /// Добавляем файл/каталог в тривью в виде узла 
        /// </summary>
        /// <param name="parent"> Узел к которому будет добавлен созданный узел </param>
        /// <param name="path"> Полный путь к файлу/папке </param>
        /// <param name="file"> Указывает ли путь на файл?  </param>
        /// <returns></returns>
        private async Task<TreeNode> AddNode(TreeNode parent, string path, bool file = false)
        {
            return await Task.Factory.StartNew(() =>
            {
                TreeNode node = null;
                Invoke((MethodInvoker)delegate
                {
                    if (file)
                    {
                        var name = Path.GetFileName(path);
                        var type = Path.GetExtension(path);
                        node = parent.Nodes.Add(name);
                        node.Name = path;
                        SetupNodeImages(node, type);
                    }
                    else
                    {
                        node = parent.Nodes.Add(new DirectoryInfo(path).Name);
                        node.SelectedImageIndex = node.ImageIndex = 2;
                        node.Name = path;
                    }
                });
                return node;
            });            
        }

        /* ImageList1 content:
         * empty  0
         * drive  1
         * folder 2
         * image  3
         * text   4
         * zip    5   
         */

        void SetupNodeImages(TreeNode node, string ext)
        {
            switch (ext.ToLower())
            {
                case ".jpeg":
                case ".jpg":
                case ".png":
                case ".bmp":
                case ".png8":
                case ".gif":
                case ".tiff":
                    node.ImageIndex = 3;
                    node.SelectedImageIndex = 3;
                    break;
                case ".txt":
                    node.ImageIndex = 4;
                    node.SelectedImageIndex = 4;
                    break;
                case ".zip":
                case ".rar":
                case ".7z":
                    node.ImageIndex = 5;
                    node.SelectedImageIndex = 5;
                    break;
                default:
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                    break;
            }            
        }




        /// <summary>
        ///  Обновляет триивью - удаляет те элементы которых уже нет и добавляет те которые появились
        /// </summary>
        private async void RefreshTree()
        {
            var drives = treeViewMain.Nodes;
            for (int i = 0; i < drives.Count; i++)
            {
                var d = drives[i];
                if (DriveInfo.GetDrives().FirstOrDefault(x => x.Name == d.Name) == null)
                {
                    drives.Remove(d);
                    i--;
                }
            }

            var node = treeViewMain.Nodes[0];

            while (node != null)
            {
                if (node.Name == null)
                {
                    var prevoious = node;
                    node = node.NextVisibleNode;
                    prevoious.Remove();
                    continue;
                }

                if (!Directory.Exists(node.Name) && !File.Exists(node.Name))
                {
                    var prevoious = node;
                    node = node.NextVisibleNode;
                    prevoious.Remove();
                    continue;
                }
                

                if (Directory.Exists(node.Name))
                {
                    if (!node.IsExpanded)
                    {
                        TreeLayer(node);
                    }
                    else
                    {
                        var nodes = node.Nodes;

                        var directories = Directory.GetDirectories(node.Name).ToList();
                        var files = Directory.GetFiles(node.Name).ToList();

                        foreach (TreeNode n in nodes)
                        {
                            directories.Remove(n.Name);
                            files.Remove(n.Name);
                        }

                        foreach (var dir in directories)
                        {
                            var child = await AddNode(node, dir);
                            TreeLayer(child);
                        }
                        foreach (var file in files) await AddNode(node, file, true);
                    }
                }

                
                node = node.NextVisibleNode;
            }
        }

        

        /// Вызывается когда раскрывается папка - проверяем каждую вложенную
        /// и если у нее нет содержимого - пытаемся его найти и задать потомков узлу
        private async void TreeViewMain_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            foreach (TreeNode n in e.Node.Nodes)
            {
                if (n.Nodes.Count == 0)
                    if (new DirectoryInfo(n.Name).Exists)
                        await Task.Factory.StartNew(() => TreeLayer(n));

            }
        }




        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTree();
        }

    


        private void TextDirectory_Validating(object sender, CancelEventArgs e)
        {
            textDirectory.Text = CurrentDirectory;
        }

        private void TextDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) CurrentDirectory = textDirectory.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTreeView();
        }

        private void TreeViewMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            CurrentDirectory = e.Node.FullPath;
        }

        private void MainPicture_Click(object sender, EventArgs e)
        {

        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FoldersHistory.Back();
            if (FoldersHistory.Current != CurrentDirectory) CurrentDirectory = FoldersHistory.Current;
        }

        private void ButtonForward_Click(object sender, EventArgs e)
        {
            FoldersHistory.Forward();
            if (FoldersHistory.Current != CurrentDirectory) CurrentDirectory = FoldersHistory.Current;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            foreach (var ext in validExtensions)
            {
                s.Append(ext);
                s.Append(" ");
            }            

            MessageBox.Show($"This programm can open images with this exentions: \n{s.ToString()} ", "Info");
        }

        private void AboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("There should be github link", "About");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }

    public class FoldersHistory
    {
        int HISTORY_LENGTH = 20;

        public string Current { get; private set; }

        private readonly LinkedList<string> before = new LinkedList<string>();
        private readonly LinkedList<string> after = new LinkedList<string>();



        public string GetCurrent()
        {
            return Current;
        }

        public void Open(string s)
        {
            if (Current != "" && Current != null) before.AddLast(Current);
            if (before.Count > HISTORY_LENGTH) before.RemoveFirst();
            Current = s;
            after.Clear();
        }


        public void Back()
        {
            if (before.Count > 0)
            {
                after.AddFirst(Current);
                Current = before.Last();
                before.RemoveLast();
            }
        }

        public void Forward()
        {
            if (after.Count > 0)
            {
                before.AddLast(Current);
                Current = after.First();
                after.RemoveFirst();
            }
        }

    }

}
