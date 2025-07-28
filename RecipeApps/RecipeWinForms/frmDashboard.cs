using CPUWindowsFormsFramework;
using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnRecipes.Click += BtnRecipes_Click;
            btnMeals.Click += BtnMeals_Click;
            btnCookbooks.Click += BtnCookbooks_Click;
        }
        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            gDashboard.Focus();
            LoadDashboard();
        }
        private void LoadDashboard()
        {
            gDashboard.DataSource = DataHandling.GetDataList("Dashboard");
            WindowsFormsUtility.FormatGridForDataList(gDashboard, "Dashboard");
        }
        private void BtnRecipes_Click(object? sender, EventArgs e)
        {
            OpenButtonTypeForm(typeof(frmRecipeList));
        }
        private void BtnMeals_Click(object? sender, EventArgs e)
        {
            OpenButtonTypeForm(typeof(frmMealList));
        }
        private void BtnCookbooks_Click(object? sender, EventArgs e)
        {
            OpenButtonTypeForm(typeof(frmCookbookList));
        }
        private void OpenButtonTypeForm(Type formtype)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(formtype);
            }
        }
    }
}