using CPUWindowsFormsFramework;
using RecipeSystem;


namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            FormatGrid();
            btnNew.Click += BtnNew_Click;
        }

        private void SearchForRecipe(string recipename)
        {   
            gRecipe.DataSource = Recipe.SearchRecipes(recipename);
            gRecipe.Columns["RecipeId"].Visible = false;
            WindowsFormsUtility.FormatGridForDataList(gRecipe,"Recipe");
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtSearch.Text);
        }
        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeDetailsForm(e.RowIndex);
        }
        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeDetailsForm(-1);
        }
        private void ShowRecipeDetailsForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }    
            frmRecipe frm = new frmRecipe();
            frm.ShowForm(id);
            
        }
        private void FormatGrid()
        {
            gRecipe.AllowUserToAddRows = false;
            gRecipe.ReadOnly = true;
            gRecipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gRecipe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
