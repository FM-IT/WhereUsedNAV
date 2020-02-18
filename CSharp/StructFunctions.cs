using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereUsedNAV
{
    enum ObjTypes
    {
        TableData,
        Table,
        Form,
        Report,
        Dataport,
        Codeunit,
        XMLport,
        MenuSuite,
        Page,
        Query,
        System,
        FieldNumber,
        Type12,
        Type13,
        PageExtension,
        TableExtension
    }
    class StructFunctions
    {
        public struct objectTypesStruct
        {
            ObjTypes MyObjType;
            public string tableName
            {
                get
                {
                    return "objectTypes";
                }
            }

            public Guid GUID;
            public string GUID_fieldName
            {
                get
                {
                    return "GUID";
                }
            }
            //Fields
            public int Type;
            public string Type_fieldName
            {
                get
                {
                    return "Type";
                }
            }
            public string TypeAsString
            {
                get
                {
                    Enum.TryParse<ObjTypes>(Type.ToString(), out MyObjType);
                    return MyObjType.ToString();
                }
                set
                {
                    Enum.TryParse<ObjTypes>(value, out MyObjType);
                    Type = (int)MyObjType;
                }
            }
            public string TypeAsString_fieldName
            {
                get
                {
                    return "TypeAsString";
                }
            }            public string Type_Description;
            public string Type_Description_fieldName
            {
                get
                {
                    return "Type_Description";
                }
            }
        }
        public struct objectsStruct
        {
            public string tableName
            {
                get
                {
                    return "objects";
                }
            }

            public Guid GUID;
            public string GUID_fieldName
            {
                get
                {
                    return "GUID";
                }
            }
            //Fields
            public int Type;
            public string Type_fieldName
            {
                get
                {
                    return "Type";
                }
            }
            public string Type_Description;
            public string Type_Description_fieldName
            {
                get
                {
                    return "Type_Description";
                }
            }
            public int ID;
            public string ID_fieldName
            {
                get
                {
                    return "ID";
                }
            }
            public string Description;
            public string Description_fieldName
            {
                get
                {
                    return "Description";
                }
            }
            public byte[] ObjectBlob;
            public string ObjectBlob_fieldName
            {
                get
                {
                    return "ObjectBlob";
                }
            }
        }
        public struct tablesStruct
        {
            public string tableName
            {
                get
                {
                    return "tables";
                }
            }
            
            public Guid GUID;
            public string GUID_fieldName
            {
                get
                {
                    return "GUID";
                }
            }
            //Fields
            public int Type;
            public string Type_fieldName
            {
                get
                {
                    return "Type";
                }
            }
            public string Type_Description;
            public string Type_Description_fieldName
            {
                get
                {
                    return "Type_Description";
                }
            }
            public int ID;
            public string ID_fieldName
            {
                get
                {
                    return "ID";
                }
            }
            public string Description;
            public string Description_fieldName
            {
                get
                {
                    return "Description";
                }
            }
        }
        public struct fieldsStruct
        {
            public string tableName
            {
                get
                {
                    return "tableFields";
                }
            }

            public Guid GUID;
            public string GUID_fieldName
            {
                get
                {
                    return "GUID";
                }
            }
            //Fields
            public int Table_No;
            public string Table_No_fieldName
            {
                get
                {
                    return "Table_No";
                }
            }
            public bool Enabled;
            public string Enabled_fieldName
            {
                get
                {
                    return "Enabled";
                }
            }
            public int Field_No;
            public string Field_No_fieldName
            {
                get
                {
                    return "Field_No";
                }
            }
            public string Field_Name;
            public string Field_Name_fieldName
            {
                get
                {
                    return "Field_Name";
                }
            }
            public string Data_Type;
            public string Data_Type_fieldName
            {
                get
                {
                    return "Data_Type";
                }
            }
            public int Length;
            public string Length_fieldName
            {
                get
                {
                    return "Length";
                }
            }
            public string Description;
            public string Description_fieldName
            {
                get
                {
                    return "Description";
                }
            }
        }
        public struct functionsStruct
        {
            public string tableName
            {
                get
                {
                    return "Functions";
                }
            }

            public Guid GUID;
            public string GUID_fieldName
            {
                get
                {
                    return "GUID";
                }
            }
            //Fields
            public Guid ObjectGUID;
            public string ObjectGUID_fieldName
            {
                get
                {
                    return "ObjectGUID";
                }
            }


            public int ObjectType;
            public string ObjectType_fieldName
            {
                get
                {
                    return "ObjectType";
                }
            }
            public string ObjectType_Description;
            public string ObjectType_Description_fieldName
            {
                get
                {
                    return "ObjectType_Description";
                }
            }
            public int ObjectID;
            public string ObjectID_fieldName
            {
                get
                {
                    return "ObjectID";
                }
            }
            public string Name;
            public string Name_fieldName
            {
                get
                {
                    return "Name";
                }
            }
        }
    }
}
