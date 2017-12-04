using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WhereUsedNAV
{
    class DataClass
    {
        private DataSet myDataSet;
        private DataTable objectTypesTable;
        private DataTable objectTable;
        private DataTable TablesTable;
        private DataTable FieldsTable; 
        private DataTable FunctionsTable;

        private StructFunctions.objectTypesStruct objectTypeStruct;
        private StructFunctions.objectsStruct objectStruct;
        private StructFunctions.tablesStruct TableStruct;
        private StructFunctions.fieldsStruct fieldStruct;
        private StructFunctions.functionsStruct functionStruct;

        public DataClass()
        {
            myDataSet = new DataSet();
            objectTypesTable = new DataTable();
            createObjectTypesTable(ref myDataSet, ref objectTypeStruct, ref objectTypesTable);
            objectTable = new DataTable();
            createObjectsTable(ref myDataSet, ref objectStruct, ref objectTable);
            objectStruct = new StructFunctions.objectsStruct();
        }        
        
        public void CreateTestData()
        {
            objectStruct.Description = "My Descr";
            objectStruct.ID = 1;
            objectStruct.Type = 1;
            objectStruct.Type_Description = "TDESCR";

            objectTable = myDataSet.Tables[objectStruct.tableName];
            populateObjectRow(ref objectTable, objectStruct);
       
            //int objFieldsIndex = createFieldsTable(ref myDataSet);
            //addDataRowToFieldsTable(ref myDataSet, objFieldsIndex);
        }

        public void createObjectTypesTable(ref DataSet myDataSet, ref StructFunctions.objectTypesStruct myDataTableStruct, ref DataTable myTable)
        {
            //StructFunctions.objectTypesStruct myDataTableStruct = new StructFunctions.objectTypesStruct();
            string TableName = myDataTableStruct.tableName;
            //DataTable myTable = myDataSet.Tables.Add(TableName);
            myTable = myDataSet.Tables.Add(TableName);

            DataColumnCollection TableCols;
            TableCols = myTable.Columns;

            //Primary key GUID
            DataColumn colGuid = TableCols.Add(myDataTableStruct.GUID_fieldName, typeof(Guid));
            colGuid.AllowDBNull = false;
            colGuid.Unique = true;
            colGuid.DefaultValue = Guid.NewGuid();
            myTable.PrimaryKey = new DataColumn[] { colGuid };
            //Fields
            DataColumn colType = TableCols.Add(myDataTableStruct.Type_fieldName, typeof(int));
            DataColumn colTypeDescription = TableCols.Add(myDataTableStruct.Type_Description_fieldName, typeof(string));

            DataTableCollection myDataTableColl = myDataSet.Tables;
        }
        public void createObjectsTable(ref DataSet myDataSet, ref StructFunctions.objectsStruct myDataTableStruct, ref DataTable myTable)
        {
            //StructFunctions.objectsStruct myDataTableStruct = new StructFunctions.objectsStruct();
            string TableName = myDataTableStruct.tableName;
            //DataTable myTable = myDataSet.Tables.Add(TableName);
            myTable = myDataSet.Tables.Add(TableName);

            DataColumnCollection TableCols;
            TableCols = myTable.Columns;

            //Primary key GUID
            DataColumn colGuid = TableCols.Add(myDataTableStruct.GUID_fieldName, typeof(Guid));
            colGuid.AllowDBNull = false;
            colGuid.Unique = true;
            colGuid.DefaultValue = Guid.NewGuid();
            myTable.PrimaryKey = new DataColumn[] { colGuid };
            //Fields
            DataColumn colType = TableCols.Add(myDataTableStruct.Type_fieldName, typeof(int));
            DataColumn colTypeDescription = TableCols.Add(myDataTableStruct.Type_Description_fieldName, typeof(string));
            DataColumn colID = TableCols.Add(myDataTableStruct.ID_fieldName, typeof(int));
            DataColumn colDescription = TableCols.Add(myDataTableStruct.Description_fieldName, typeof(string));

            DataTableCollection myDataTableColl = myDataSet.Tables;
        }
        public void createTablesTable(ref DataSet myDataSet, ref StructFunctions.tablesStruct myDataTableStruct)
        {
            //StructFunctions.tablesStruct myDataTableStruct = new StructFunctions.tablesStruct();
            string TableName = myDataTableStruct.tableName;
            DataTable myTable = myDataSet.Tables.Add(TableName);

            DataColumnCollection TableCols;
            TableCols = myTable.Columns;

            //Primary key GUID
            DataColumn colGuid = TableCols.Add(myDataTableStruct.GUID_fieldName, typeof(Guid));
            colGuid.AllowDBNull = false;
            colGuid.Unique = true;
            colGuid.DefaultValue = Guid.NewGuid();
            myTable.PrimaryKey = new DataColumn[] { colGuid };
            //Fields
            DataColumn colID = TableCols.Add(myDataTableStruct.ID_fieldName, typeof(int));
            DataColumn colDescription = TableCols.Add(myDataTableStruct.Description_fieldName, typeof(string));
            DataColumn colType = TableCols.Add(myDataTableStruct.Type_fieldName, typeof(int));
            DataColumn colTypeDescription = TableCols.Add(myDataTableStruct.Type_Description_fieldName, typeof(string));

            DataTableCollection myDataTableColl = myDataSet.Tables;
        }
        public void createFieldsTable(ref DataSet myDataSet, ref StructFunctions.fieldsStruct myDataTableStruct)
        {
            //StructFunctions.fieldsStruct myDataTableStruct = new StructFunctions.fieldsStruct();
            string TableName = myDataTableStruct.tableName;
            DataTable myTable = myDataSet.Tables.Add(TableName);

            DataColumnCollection TableCols;
            TableCols = myTable.Columns;

            //Primary key GUID
            DataColumn colGuid = TableCols.Add(myDataTableStruct.GUID_fieldName, typeof(Guid));
            colGuid.AllowDBNull = false;
            colGuid.Unique = true;
            colGuid.DefaultValue = Guid.NewGuid();
            myTable.PrimaryKey = new DataColumn[] { colGuid };
            //Fields
            DataColumn colTable_No = TableCols.Add(myDataTableStruct.Table_No_fieldName, typeof(int));
            DataColumn colField_No = TableCols.Add(myDataTableStruct.Field_No_fieldName, typeof(int));
            DataColumn colField_Name = TableCols.Add(myDataTableStruct.Field_Name_fieldName, typeof(string));
            DataColumn colData_Type = TableCols.Add(myDataTableStruct.Data_Type_fieldName, typeof(string));
            DataColumn colLength = TableCols.Add(myDataTableStruct.Length_fieldName, typeof(int));
            DataColumn colEnabled = TableCols.Add(myDataTableStruct.Enabled_fieldName, typeof(bool));
            DataColumn colDescription = TableCols.Add(myDataTableStruct.Description_fieldName, typeof(string));

            DataTableCollection myDataTableColl = myDataSet.Tables;
        }
        public void createFunctionsTable(ref DataSet myDataSet, ref StructFunctions.functionsStruct myDataTableStruct)
        {
            //StructFunctions.functionsStruct myDataTableStruct = new StructFunctions.functionsStruct();
            string TableName = myDataTableStruct.tableName;
            DataTable myTable = myDataSet.Tables.Add(TableName);

            DataColumnCollection TableCols;
            TableCols = myTable.Columns;

            //Primary key GUID
            DataColumn colGuid = TableCols.Add(myDataTableStruct.GUID_fieldName, typeof(Guid));
            colGuid.AllowDBNull = false;
            colGuid.Unique = true;
            colGuid.DefaultValue = Guid.NewGuid();
            myTable.PrimaryKey = new DataColumn[] { colGuid };
            //Fields
            DataColumn colObjectGUID = TableCols.Add(myDataTableStruct.ObjectGUID_fieldName, typeof(Guid));
            DataColumn colObjectID = TableCols.Add(myDataTableStruct.ObjectID_fieldName, typeof(int));
            DataColumn colObjectType = TableCols.Add(myDataTableStruct.ObjectType_fieldName, typeof(string));
            DataColumn colObjectType_Description = TableCols.Add(myDataTableStruct.ObjectType_Description_fieldName, typeof(string));
            DataColumn colName = TableCols.Add(myDataTableStruct.Name_fieldName, typeof(string));

            DataTableCollection myDataTableColl = myDataSet.Tables;
        }
        public Guid populateObjectTypeRow(ref DataTable myDataTable, StructFunctions.objectTypesStruct myDataTableStruct)
        {
            DataRow row = myDataTable.NewRow();
            row[myDataTableStruct.GUID_fieldName] = Guid.NewGuid();
            row[myDataTableStruct.Type_fieldName] = myDataTableStruct.Type;
            row[myDataTableStruct.Type_Description_fieldName] = myDataTableStruct.Type_Description;
            myDataTable.Rows.Add(row);
            System.Windows.Forms.MessageBox.Show(myDataTable.Rows.Count.ToString());
            return (Guid)row[myDataTableStruct.GUID_fieldName];
        }
        public Guid populateObjectRow(ref DataTable myDataTable, StructFunctions.objectsStruct myDataTableStruct)
        {
            DataRow row = myDataTable.NewRow();
            row[myDataTableStruct.GUID_fieldName] = Guid.NewGuid();
            row[myDataTableStruct.ID_fieldName] = myDataTableStruct.ID;
            row[myDataTableStruct.Type_fieldName] = myDataTableStruct.Type;
            row[myDataTableStruct.Type_Description_fieldName] = myDataTableStruct.Type_Description;
            row[myDataTableStruct.Description_fieldName] = myDataTableStruct.Description;
            myDataTable.Rows.Add(row);
            System.Windows.Forms.MessageBox.Show(myDataTable.Rows.Count.ToString());
            return (Guid)row[myDataTableStruct.GUID_fieldName];
        }
        public Guid populateTableRow(ref DataTable myDataTable, StructFunctions.tablesStruct myDataTableStruct)
        {
            DataRow row = myDataTable.NewRow();
            row[myDataTableStruct.GUID_fieldName] = Guid.NewGuid();
            row[myDataTableStruct.Description_fieldName] = myDataTableStruct.Description;
            row[myDataTableStruct.ID_fieldName] = myDataTableStruct.ID;
            row[myDataTableStruct.Type_fieldName] = myDataTableStruct.Type;
            row[myDataTableStruct.Type_Description_fieldName] = myDataTableStruct.Type_Description;
            myDataTable.Rows.Add(row);
            return (Guid)row[myDataTableStruct.GUID_fieldName];
        }
        public void addDataRowToTable(ref DataSet myDataSet, int myTableIndex, ref DataRow row)
        {
            DataTable myDataTable = myDataSet.Tables[myTableIndex];
            myDataTable.Rows.Add(row);
        }
        public void addDataRowToFieldsTable(ref DataSet myDataSet, int myTableIndex)
        { }
    }
}