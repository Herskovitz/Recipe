using CPUWindowsFormsFramework;
using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            this.Activated += FrmCookbookList_Activated;
            btnNewCookbook.Click += BtnNewCookbook_Click;
            gCookbook.CellDoubleClick += GCookbook_CellDoubleClick;
            gCookbook.KeyDown += GCookbook_KeyDown;
        }
        private void GCookbook_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookDetailsform(e.RowIndex);
        }
        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            gCookbook.DataSource = DataHandling.GetDataList("Cookbook");
            WindowsFormsUtility.FormatGridForDataList(gCookbook, "Cookbook");
        }
        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookDetailsform(-1);
        }
        public void ShowCookbookDetailsform(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gCookbook.Rows[rowindex].Cells["CookbookId"].Value;
            }

            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), id);
            }
        }
        private void GCookbook_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gCookbook.SelectedRows.Count > 0)
            {
                ShowCookbookDetailsform(gCookbook.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }
    }
}
