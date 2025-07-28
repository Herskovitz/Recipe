using CPUFramework;
using CPUWindowsFormsFramework;
using RecipeSystem;
using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmRecipeClone : Form
    {
        public frmRecipeClone()
        {
            InitializeComponent();
            BindData();
            btnClone.Click += BtnClone_Click;
        }

        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(lstRecipeName, DataHandling.GetDataList("Recipe", true), null, "Recipe");
        }
        private void BtnClone_Click(object? sender, EventArgs e)
        {
            try
            {
                CloneRecipe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CloneRecipe()
        {
            int recipeid = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);

            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeClone");
            SQLUtility.SetParamaterValue(cmd, "@RecipeId", recipeid);
            SQLUtility.SetParamaterValue(cmd, "@BaseRecipeId", recipeid);
            SQLUtility.ExecuteSQL(cmd);

            int clonedrecipeid = (int)cmd.Parameters["@RecipeId"].Value;

            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), clonedrecipeid);
            }
            this.Close();
        }

    }
}
