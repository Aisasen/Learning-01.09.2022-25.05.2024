using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public string fullPath;
        public Form1()
        {
            InitializeComponent();
            DriveTreeInit();
        }
        public void DriveTreeInit()
        {
            string[] drivesArray = Directory.GetLogicalDrives();
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();
            foreach (string s in drivesArray)
            {
                TreeNode drive = new TreeNode(s, 1, 1);
                treeView1.Nodes.Add(drive);
                GetDirs(drive);
            }
            treeView1.EndUpdate();
        }
        public void GetDirs(TreeNode node)
        {
            DirectoryInfo[] diArray;
            node.Nodes.Clear();
            string fullPath = node.FullPath;
            DirectoryInfo di = new DirectoryInfo(fullPath);
            try
            {
                diArray = di.GetDirectories();
            }
            catch
            {
                return;
            }
            foreach(DirectoryInfo dirinfo in diArray)
            {
                TreeNode dir = new TreeNode(dirinfo.Name, 2, 0);
                node.Nodes.Add(dir);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeView1.BeginUpdate();
            foreach (TreeNode node in e.Node.Nodes)
            {
                GetDirs(node);
            }
            treeView1.EndUpdate();
        }

        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            fullPath = selectedNode.FullPath;
            DirectoryInfo di = new DirectoryInfo(fullPath);
            FileInfo[] fiArray;
            DirectoryInfo[] diArray;
            try
            {
                fiArray = di.GetFiles();
                diArray = di.GetDirectories();
            }
            catch
            {
                return;
            }
            listView1.Items.Clear();
            foreach (DirectoryInfo directoryInfo in diArray)
            {
                ListViewItem Ivi = new ListViewItem(directoryInfo.Name);
                Ivi.SubItems.Add("0");
                Ivi.SubItems.Add(directoryInfo.LastWriteTime.ToString());
                Ivi.ImageIndex = 0;
                listView1.Items.Add(Ivi);
            }
            foreach (FileInfo fileinfo in fiArray)
            {
                ListViewItem Ivi = new ListViewItem(fileinfo.Name);
                Ivi.SubItems.Add(fileinfo.Length.ToString());
                Ivi.SubItems.Add(fileinfo.LastWriteTime.ToShortTimeString());
                string filenameExtension = Path.GetExtension(fileinfo.FullName).ToLower();
                switch (filenameExtension)
                {
                    case ".com":
                    {
                        Ivi.ImageIndex = 2;
                        break;
                    }
                    case ".exe":
                    {
                        Ivi.ImageIndex = 2;
                        break;
                    }
                    case ".hlp":
                    {
                        Ivi.ImageIndex = 3;
                        break;
                    }
                    case ".txt":
                        {
                            Ivi.ImageIndex = 4;
                            break;
                        }
                    case ".doc":
                        {
                            Ivi.ImageIndex = 5;
                            break;
                        }
                    default:
                        {
                            Ivi.ImageIndex = 1;
                            break;
                        }

                }
                listView1.Items.Add(Ivi);
            }
        }
    }
}
