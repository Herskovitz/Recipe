using CPUFramework;
using CPUWindowsFormsFramework;
using RecipeSystem;
using System.Data;


namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        DataTable dtcookbook = new();
        DataTable dtcookbookrecipes = new();
        BindingSource bindsource = new();
        int cookbookid = 0;
        string deletecolumnname = "deletecol";
        List<Button> lstbtnenable = new();

        public frmCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveRecipes.Click += BtnSaveRecipes_Click;
            gRecipes.MouseClick += GRecipes_MouseClick;
            this.FormClosing += FrmCookbook_FormClosing;
            txtPrice.KeyPress += TxtPrice_KeyPress; ;
            lstbtnenable = new() { btnDelete, btnSaveRecipes };
            gRecipes.EditingControlShowing += GRecipes_EditingControlShowing;
        }


        public void ShowForm(int cookbookidvalue)
        {
            cookbookid = cookbookidvalue;
            this.Tag = cookbookid;
            SetCookbookBindingSourceData();

            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
                WindowsFormsUtility.ManageAvailableButtons(false, lstbtnenable);
            }

            BindData();
            this.Text = DataHandling.GetNameOfOpenRecord("Cookbook", dtcookbook);
            this.Show();
        }
        public void OnFormShown()
        {
            if (cookbookid > 0)
            {
                LoadCookbookRecipes();
            }
        }
        private void BindData()
        {
            DataTable dtuser = DataHandling.GetDataList("User");

            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetListBinding(lstUsername, dtuser, dtcookbook, "User");
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(chkActive, bindsource);
            WindowsFormsUtility.SetControlBinding(gRecipes, bindsource);
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private bool Save()
        {
            bool b = false;

            try
            {
                DataHandling.SaveDataRows(dtcookbook, "Cookbook");
                b = true;
                if (cookbookid == 0)
                {
                    WindowsFormsUtility.ManageAvailableButtons(true, lstbtnenable);

                    if (gRecipes.Columns.Count < 1)
                    {
                        LoadCookbookRecipes();
                    }
                }
                else
                {
                    this.Close();
                    MessageBox.Show("Cookbook saved successfully!", "Save Cookbook");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cookbookid = (int)dtcookbook.Rows[0]["CookbookId"];
            this.Tag = cookbookid;
            this.Text = DataHandling.GetNameOfOpenRecord("Cookbook", dtcookbook);
            return b;
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            try
            {
                var response = MessageBox.Show($"Are you sure you want to delete {this.Text}?", "Delete Cookbook", MessageBoxButtons.YesNo);
                if (response == DialogResult.No)
                {
                    return;
                }
                DataHandling.Delete("Cookbook", cookbookid);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadCookbookRecipes()
        {
            LoadAndSetBindingCookbookRecipes();
            WindowsFormsUtility.AddComboBoxToGrid(gRecipes, DataHandling.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipes, deletecolumnname);
        }

        private void BtnSaveRecipes_Click(object? sender, EventArgs e)
        {
            try
            {
                DataHandling.SaveChildRecords(dtcookbookrecipes, cookbookid, "CookbookRecipe", "Cookbook");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Cookbook");
            }
        }


        private void GRecipes_MouseClick(object? sender, MouseEventArgs e)
        {
            var hittestinfo = gRecipes.HitTest(e.X, e.Y);
            int id = WindowsFormsUtility.GetIdFromGrid(gRecipes, hittestinfo.RowIndex, "CookbookRecipeId");
            if (hittestinfo.RowIndex < 0 || hittestinfo.ColumnIndex < 0)
            {
                return;
            }
            if (gRecipes.Columns[hittestinfo.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (id > 0)
                {
                    try
                    {
                        DataHandling.Delete("CookbookRecipe", id);
                        LoadAndSetBindingCookbookRecipes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Unsaved records cannot be deleted.", "Delete Cookbook Recipe");
                }
            }
        }
        private void LoadAndSetBindingCookbookRecipes()
        {
            dtcookbookrecipes = DataHandling.LoadChildRecords("CookbookRecipe", cookbookid, "Cookbook");
            gRecipes.DataSource = dtcookbookrecipes;
            WindowsFormsUtility.FormatGridForEdit(gRecipes, "CookbookRecipe");
        }
        private void SetCookbookBindingSourceData()
        {
            dtcookbook = dtcookbook = DataHandling.Load("Cookbook", cookbookid);
            bindsource.DataSource = dtcookbook;
        }
        private void FrmCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtcookbook) == true)
            {
                var response = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", "Save Cookbook", MessageBoxButtons.YesNoCancel);

                switch (response)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }

        private void GRecipes_EditingControlShowing(object? sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txtbox = e.Control as TextBox;
            if (txtbox != null)
            {
                txtbox.KeyPress -= Txtbox_KeyPress;
                txtbox.KeyPress += Txtbox_KeyPress;
            }
        }

        private void Txtbox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            WindowsFormsUtility.HandleNumberOnlyTextBoxInput(sender, e);
        }

        private void TxtPrice_KeyPress(object? sender, KeyPressEventArgs e)
        {
            WindowsFormsUtility.HandleNumberOnlyTextBoxInput(sender, e, true);
        }
    }
}