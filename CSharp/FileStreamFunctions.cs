using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereUsedNAV
{
    class FileStreamFunctions
    {
        System.IO.TextReader mainTxtFileStream;
        StructFunctions.objectTypesStruct ObjTypeStruct;

        public void ReadFile(string fileName, ref DataClass myDataClass)
        {
            mainTxtFileStream = null;
            mainTxtFileStream = new System.IO.StreamReader(fileName);
            string readLine = null;
            while ((readLine = mainTxtFileStream.ReadLine()) != null)
            {
                {
                    if (readLine.StartsWith("OBJECT"))
                    {
                        int ObjType = 0;
                        int ObjNumber = 0;
                        string ObjName = null;
                        //System.Windows.Forms.MessageBox.Show(readLine);
                        ParseObjectLine(readLine, ref ObjType, ref ObjNumber, ref ObjName);
                        System.Windows.Forms.MessageBox.Show(String.Format("{0} {1} {2}", ObjType.ToString(), ObjNumber.ToString(), ObjName));
                    }
                        
                }
            }
            mainTxtFileStream.Close();
            mainTxtFileStream = null;
        }
        private void ParseObjectLine(string ObjectLineTxt, ref int ObjType, ref int ObjNumber, ref string ObjName)
        {
            if (ObjectLineTxt.StartsWith("OBJECT"))
            {
                char[] delimiterChars = {' '};
                string[] words = ObjectLineTxt.Split(delimiterChars, 4);
                ObjTypeStruct.TypeAsString = words[1];
                ObjType = ObjTypeStruct.Type;
                ObjNumber = int.Parse(words[2]);
                ObjName = words[3];
            }
        }
    }
}
