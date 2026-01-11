using CPUFramework;
using System.Data.SqlClient;

namespace RecipeSystem
{
    public class bizIngredient : bizObject<bizIngredient>
    {
        private int _ingredientid;
        private string _ingredientname = "";

        public int IngredientId
        {
            get { return _ingredientid; }
            set
            {
                if (_ingredientid != value)
                {
                    _ingredientid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string IngredientName
        {
            get { return _ingredientname; }
            set
            {
                if (_ingredientname != value)
                {
                    _ingredientname = value;
                    InvokePropertyChanged();
                }
            }
        }
        public List<bizIngredient> Search(string ingredientnamevaluetosearch)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(GetSprocName);
            SQLUtility.SetParamaterValue(cmd, "IngredientName", ingredientnamevaluetosearch);
            return GetListFromDataTable(SQLUtility.GetDataTable(cmd));
        }

    }
}
