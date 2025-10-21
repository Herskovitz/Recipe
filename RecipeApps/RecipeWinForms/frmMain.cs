using CPUWindowsFormsFramework;

namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuMealList.Click += MnuMealList_Click;
            mnuRecipeList.Click += MnuRecipeList_Click;
            mnuCloneRecipe.Click += MnuCloneRecipe_Click;
            mnuNewRecipe.Click += MnuNewRecipe_Click;
            mnuCookbookList.Click += MnuCookbookList_Click;
            mnuNewCookbook.Click += MnuNewCookbook_Click;
            mnuTile.Click += MnuTile_Click;
            mnuCascade.Click += MnuCascade_Click;
            mnuDashboard.Click += MnuDashboard_Click;
            mnuAutoCreateCookbook.Click += MnuAutoCreateCookbook_Click;
            mnuEditData.Click += MnuEditData_Click;
            this.Shown += FrmMain_Shown;
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype, pkvalue);

            if (b == false)
            {
                Form? newfrm = null;

                if (frmtype == typeof(frmMealList))
                {
                    frmMealList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeClone))
                {
                    frmRecipeClone f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipe))
                {
                    frmRecipe f = new();
                    newfrm = f;
                    f.ShowForm(pkvalue);
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    frmCookbookList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbook))
                {
                    frmCookbook f = new();
                    newfrm = f;
                    f.ShowForm(pkvalue);
                }
                else if (frmtype == typeof(frmCookbookAutoCreate))
                {
                    frmCookbookAutoCreate f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmChangeStatus))
                {
                    frmChangeStatus f = new();
                    newfrm = f;
                    f.ShowForm(pkvalue);
                }
                else if (frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    newfrm = f;
                }
                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Newfrm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                }
                if (frmtype == typeof(frmRecipe))
                {
                    ((frmRecipe)newfrm).OnFormShown();
                }
                if (frmtype == typeof(frmCookbook))
                {
                    ((frmCookbook)newfrm).OnFormShown();
                }
                WindowsFormsUtility.SetupNav(tsMain);
            }
        }

        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipe));
        }
        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }
        private void MnuCloneRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeClone));
        }
        private void MnuMealList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }
        private void MnuCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }
        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbook));
        }
        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }
        private void Newfrm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }
        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }
        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            frmLogin f = new();
            bool b = f.ShowLogin();
            if (b == false)
            {
                this.Close();
                Application.Exit();
                return;
            }
            OpenForm(typeof(frmDashboard));
        }
        private void MnuAutoCreateCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookAutoCreate));
        }
        private void MnuEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }
        private void MnuCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void MnuTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
