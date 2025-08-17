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
            gCookbook.KeyDown += GCookbook_KeyDown;
            gCookbook.MouseDoubleClick += GCookbook_MouseDoubleClick;
        }
        private void GCookbook_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            var hittestinfo = gCookbook.HitTest(e.X, e.Y);

            if (hittestinfo.Type == DataGridViewHitTestType.ColumnHeader)
            {
                return;
            }
            ShowCookbookDetailsform(hittestinfo.RowIndex);
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
