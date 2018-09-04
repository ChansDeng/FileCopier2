using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopier
{
    public partial class FrmFileCopier : Form
    {
        private const int MaxLevel = 2;
        public FrmFileCopier()
        {
            InitializeComponent();

            FillDirectoryTree(tvwSource, true);
            FillDirectoryTree(tvwTarget, false);
        }
        private void FillDirectoryTree(TreeView tvw, bool isSource)
        {
            tvw.Nodes.Clear();
            string[] strDrives = Environment.GetLogicalDrives();
            foreach (string rootDirectoryName in strDrives)
            {
                try
                {
                    DirectoryInfo dir = new DirectoryInfo(rootDirectoryName);
                    dir.GetDirectories(); // forces an exception if
                    // the drive isn't ready
                    TreeNode ndRoot = new TreeNode(rootDirectoryName);
                    tvw.Nodes.Add(ndRoot);

                    if ( isSource)
                    {
                        GetSubDirectoryNodes(ndRoot, ndRoot.Text, true, 1);
                    }
                    else
                    {
                        GetSubDirectoryNodes(ndRoot, ndRoot.Text, false, 1);
                    }
                }
                catch
                {

                }
                Application.DoEvents();
            }
        }
        private void GetSubDirectoryNodes(TreeNode parentNode, 
            string fullName, bool getFileNames, int level)
        {
            DirectoryInfo dir = new DirectoryInfo(fullName);
            DirectoryInfo[] dirSubs = dir.GetDirectories();

            foreach (DirectoryInfo dirSub in  dirSubs)
            {
                if ((dirSub.Attributes & FileAttributes.Hidden) != 0)
                {
                    continue;
                }
                TreeNode subNode = new TreeNode(dirSub.Name);
                parentNode.Nodes.Add(subNode);
                if (level < MaxLevel)
                {
                    GetSubDirectoryNodes(subNode, dirSub.FullName,
                        getFileNames, level + 1);
                }
            }
            if (getFileNames)
            {
                // Get any files for this node.
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    parentNode.Nodes.Add(fileNode);
                }
            }
        }
    }
}
