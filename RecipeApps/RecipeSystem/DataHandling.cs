using CPUFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeSystem
{
    public static class DataHandling
    {
        public static void SaveDataTables(DataTable dt, string tablename)
        {
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }
        public static void SaveDataRows(DataTable dt, string tablename)
        {
            DataRow r = dt.Rows[0];
            SQLUtility.SaveDataRow(r, tablename + "Update");
        }
        public static void Delete(string tablename, int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Delete");
            SQLUtility.SetParamaterValue(cmd, $"@{tablename}Id", id);
            SQLUtility.GetDataTable(cmd);
        }
        public static DataTable Load(string tablename, int pkid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Get");
            SQLUtility.SetParamaterValue(cmd, $"@{tablename}Id", pkid);
            return SQLUtility.GetDataTable(cmd);
        }
        public static void SaveChildRecords(DataTable dt, int parenttablepkid, string tablename, string parenttablename)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r[parenttablename + "Id"] = parenttablepkid;
            }
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }
        public static DataTable LoadChildRecords(string childtablename,int parenttablepkid, string parenttablename)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(childtablename + "Get");
            SQLUtility.SetParamaterValue(cmd, $"@{parenttablename}Id", parenttablepkid);
            return SQLUtility.GetDataTable(cmd);
        }
        public static DataTable GetDataList(string tablename, bool includblank = false)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Get");
            SQLUtility.SetParamaterValue(cmd, "@All", 1);
            if (includblank == true)
            {
                SQLUtility.SetParamaterValue(cmd, "@IncludeBlank", includblank);
            }
            return SQLUtility.GetDataTable(cmd);
        }
        public static string GetNameOfOpenRecord(string recordtype, DataTable dt)
        {
            string value = "New" + recordtype;
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dt, recordtype + "Id");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dt, recordtype + "Name");
            }
            return value;
        }
    }
}
