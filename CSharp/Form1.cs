using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereUsedNAV
{
    public partial class Form1 : Form
    {
        DataClass DC = new DataClass();
        FileStreamFunctions FSF = new FileStreamFunctions();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NodeFunctions NodeFct = new NodeFunctions();
            TreeNode myTableTreeNode = new TreeNode();
            TreeNode myTreeNode = new TreeNode();
            NodeFunctions.NavObjectStruct myData = new NodeFunctions.NavObjectStruct();
            
            //Tables
            NodeFct.addDataToStruct(ref myData, "Table", 0, "", "", 1, 100);
            NodeFct.createNewNode(ref myTableTreeNode, "Table", myData);
            
            NodeFct.addDataToStruct(ref myData, "Table", 10, "Min Tabel 10", "filnavn10", 2, 10);
            NodeFct.addNewTreeNode(ref myTableTreeNode, ref myTreeNode, "Table 1", myData);

            NodeFct.addDataToStruct(ref myData, "Table", 1, "Min Tabel 1", "filnavn1", 2, 10);
            NodeFct.addNewTreeNode(ref myTableTreeNode, ref myTreeNode, "Table 1",myData);
            
            NodeFct.addDataToStruct(ref myData, "Table", 2, "Min Tabel 2", "filnavn2", 11, 20);
            NodeFct.addNewTreeNode(ref myTableTreeNode, ref myTreeNode, "Table 2",myData);
            
            treeView1.Nodes.Add(myTableTreeNode);

            //Forms
            NodeFct.addDataToStruct(ref myData, "Form", 0, "", "", 1, 100);
            NodeFct.createNewNode(ref myTableTreeNode, "Form", myData);
            NodeFct.addDataToStruct(ref myData, "Form", 1, "Min Form 1", "filnavn3", 20, 30); 
            NodeFct.addNewTreeNode(ref myTableTreeNode, ref myTreeNode, "Form 1", myData);
            NodeFct.addDataToStruct(ref myData, "Form", 2, "Min Form 2", "filnavn4", 31, 40); 
            NodeFct.addNewTreeNode(ref myTableTreeNode, ref myTreeNode, "Form 2", myData);
            NodeFct.addDataToStruct(ref myData, "Form", 3, "Min Form 3", "filnavn5", 41, 50); 
            NodeFct.addNewTreeNode(ref myTableTreeNode, ref myTreeNode, "Form 3", myData);

            treeView1.Nodes.Add(myTableTreeNode);

            treeView1.Sort();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode SelectedTreeNode = treeView1.SelectedNode;
            NodeFunctions.NavObjectStruct myData;
            myData = (NodeFunctions.NavObjectStruct)SelectedTreeNode.Tag;
            if (myData.objectID != 0)
                MessageBox.Show(string.Format("{0}, {1}, {2}",SelectedTreeNode.Text, myData.objectType.ToString(), myData.startline.ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DC.CreateTestData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FSF.ReadFile("C:\\Temp\\TestFromDev.txt", ref DC);
        }
    }
}
