using CPUFramework;

namespace RecipeSystem
{
    public class DBManager
    {
        public static void SetConnectionString(string connectionstring, bool tryopen, string username = "", string password = "")
        {
            SQLUtility.SetConnectionString(connectionstring, tryopen, username, password);
        }
    }
}
