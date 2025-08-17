using CPUWindowsFormsFramework;
using RecipeSystem;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            this.Activated += FrmRecipeList_Activated;
            btnNewRecipe.Click += BtnNewRecipe_Click;
            gRecipe.KeyDown += GRecipe_KeyDown;
            gRecipe.MouseDoubleClick += GRecipe_MouseDoubleClick;
        }

        public void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            gRecipe.DataSource = DataHandling.GetDataList("Recipe");
            WindowsFormsUtility.FormatGridForDataList(gRecipe, "Recipe", "Date");
            WindowsFormsUtility.FormatGridForEdit(gRecipe, "Recipe");
        }
        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeDetailsForm(-1);
        }
        private void GRecipe_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            var hittestinfo = gRecipe.HitTest(e.X, e.Y);

            if (hittestinfo.Type == DataGridViewHitTestType.ColumnHeader)
            {
                return;
            }
            ShowRecipeDetailsForm(hittestinfo.RowIndex);
        }

        private void ShowRecipeDetailsForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }

        }
        private void GRecipe_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gRecipe.SelectedRows.Count > 0)
            {
                ShowRecipeDetailsForm(gRecipe.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }
    }
}
