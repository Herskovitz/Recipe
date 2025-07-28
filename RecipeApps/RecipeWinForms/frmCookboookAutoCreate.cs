using CPUWindowsFormsFramework;
using System.Data;
using RecipeSystem;
using CPUFramework;
using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmCookbookAutoCreate : Form
    {
        public frmCookbookAutoCreate()
        {
            InitializeComponent();
            BindUserData();
            btnCreate.Click += BtnCreate_Click;
        }

        private void BindUserData()
        {
            DataTable dtuser = DataHandling.GetDataList("User");
            DataTable dtcookbook = DataHandling.GetDataList("Cookbook");
            WindowsFormsUtility.SetListBinding(lstUsername, dtuser, dtcookbook, "User");

        }
        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            try
            {
                AutoCreateCookbook();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AutoCreateCookbook()
        {
            int userid = WindowsFormsUtility.GetIdFromComboBox(lstUsername);

            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookAutoCreate");
            SQLUtility.SetParamaterValue(cmd, "@UserId", userid);
            SQLUtility.ExecuteSQL(cmd);

            int autocreatedcookbookid = (int)cmd.Parameters["@CookbookId"].Value;

            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), autocreatedcookbookid);
            }
            this.Close();
        }
    }
}
