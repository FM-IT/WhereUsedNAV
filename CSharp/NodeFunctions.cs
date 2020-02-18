using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereUsedNAV
{
    class NodeFunctions
    {
        public void addDataToStruct(ref NavObjectStruct myStruct, string objectType, int objectID, string objectDescription, string objectFileName, int startline, int endLine)
        {
            myStruct.endLine = endLine;
            myStruct.objectDescription = objectDescription;
            myStruct.objectFileName = objectFileName;
            myStruct.objectID = objectID;
            myStruct.objectType = objectType;
            myStruct.startline = startline;
        }
        public Boolean createNewNode(ref TreeNode NewNode, String NodeText, NavObjectStruct myStruct)
        {
            NewNode = null;
            NewNode = new TreeNode(NodeText);
            NewNode.Tag = myStruct;
            return (true);
        }
        public Boolean addNewTreeNode(ref TreeNode ParentNode, ref TreeNode ChildNode, String ChildNodeText, NavObjectStruct myStruct)
        {
            ChildNode = null;
            ChildNode = new TreeNode(string.Format("{0} - {1}",myStruct.objectID.ToString(),myStruct.objectDescription));
            ChildNode.Tag = myStruct;
            ParentNode.Nodes.Add(ChildNode);
            return (true);
        }
        public struct NavObjectStruct
        {
            public string objectType;
            public int objectID;
            public string objectDescription;
            public string objectFileName;
            public int startline;
            public int endLine;
        }
        public void createRootNodesArr(TreeNode[] RootNode, ref NavObjectStruct myData)
        {
            foreach(ObjTypes MyObjType in Enum.GetValues(typeof(ObjTypes)))
            {
                addDataToStruct(ref myData, MyObjType.ToString(), 0, "", "", 0, 0);
                createNewNode(ref RootNode[(int)MyObjType], MyObjType.ToString(), myData);
            }

            //ParentNode.Nodes.Add(ChildNode);
            //return (true);
        }
    }
}
