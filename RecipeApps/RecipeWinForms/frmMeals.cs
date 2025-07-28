using CPUWindowsFormsFramework;
using RecipeSystem;



namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            this.Activated += FrmMeals_Activated;
        }

        private void FrmMeals_Activated(object? sender, EventArgs e)
        {
            gData.DataSource = DataHandling.GetDataList("Meal");
            WindowsFormsUtility.FormatGridForDataList(gData, "Meal");
        }
    }
}
