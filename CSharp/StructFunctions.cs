using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereUsedNAV
{
    class StructFunctions
    {
        public struct objectTypesStruct
        {
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
                    switch (Type)
                    {
                        case 0: return "TableData";
                        case 1: return "Table";
                        case 2: return "Form";
                        case 3: return "Report";
                        case 4: return "Dataport";
                        case 5: return "Codeunit";
                        case 6: return "XMLport";
                        case 7: return "MenuSuite";
                        case 8: return "Page";
                        case 99: return "N/A";
                    }
                    return "N/A";
                }
                set
                {
                    switch (value)
                    {
                        case "TableData":
                            {
                                Type = 0;
                                break;
                            }
                        case "Table":
                            {
                                Type = 1;
                                break;
                            }
                        case "Form":
                            {
                                Type = 2;
                                break;
                            }
                        case "Report":
                            {
                                Type = 3;
                                break;
                            }
                        case "Dataport":
                            {
                                Type = 4;
                                break;
                            }                        
                        case "Codeunit":
                            {
                                Type = 5;
                                break;
                            }
                        case "XMLport":
                            {
                                Type = 6;
                                break;
                            }
                        case "MenuSuite":
                            {
                                Type = 7;
                                break;
                            }
                        case "Page":
                            {
                                Type = 8;
                                break;
                            }
                        default:
                            {
                                Type = 99;
                                break;
                            }
                    }
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
