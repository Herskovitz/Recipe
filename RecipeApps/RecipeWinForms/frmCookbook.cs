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

        public frmCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveRecipes.Click += BtnSaveRecipes_Click;
            gRecipes.CellContentClick += GRecipes_CellContentClick;
            this.FormClosing += FrmCookbook_FormClosing;
        }

        public void ShowForm(int cookbookidvalue)
        {
            cookbookid = cookbookidvalue;
            this.Tag = cookbookid;
            SetCookbookBindingSourceData();

            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
                WindowsFormsUtility.ManageAvailableButtons(false, btnDelete);
                WindowsFormsUtility.ManageAvailableButtons(false, btnSaveRecipes);
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
                this.Close();
                SetCookbookBindingSourceData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            WindowsFormsUtility.AddComboBoxToGrid(gRecipes, DataHandling.GetDataList("Recipe", true), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipes, deletecolumnname);
        }

        private void BtnSaveRecipes_Click(object? sender, EventArgs e)
        {
            try
            {
                DataHandling.SaveChildRecords(dtcookbookrecipes, cookbookid, "CookbookRecipe","Cookbook");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Cookbook");
            }
        }
        private void GRecipes_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DeleteCookbookRecipes(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteCookbookRecipes(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gRecipes, rowindex, "CookbookRecipeId");

            if (id > 0)
            {
                try
                {
                    DataHandling.Delete("CookBookRecipe", id);
                    LoadAndSetBindingCookbookRecipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete Recipe");
                }
            }
            else if (id < gRecipes.Rows.Count)
            {
                try
                {
                    gRecipes.Rows.RemoveAt(rowindex);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete Recipe");
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
    }
}