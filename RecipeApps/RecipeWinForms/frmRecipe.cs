using CPUFramework;
using CPUWindowsFormsFramework;
using RecipeSystem;
using System.Data;
using System.Windows.Forms;

namespace RecipeWinForms
{

    public partial class frmRecipe : Form
    {
        DataTable dtrecipe = new();
        DataTable dtrecipeingredient = new();
        DataTable dtrecipedirection = new();
        BindingSource bindsource = new();
        int recipeid = 0;
        string deletecolumnname = "deletecol";
        bool isdeleting = false;

        public frmRecipe()
        {
            InitializeComponent();
            btnDelete.Click += BtnDelete_Click;
            btnSave.Click += BtnSave_Click;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            btnSaveDirections.Click += BtnSaveDirections_Click;
            gIngredient.MouseClick += GIngredient_MouseClick;
            gDirections.CellContentClick += GDirections_CellContentClick;
            this.FormClosing += FrmRecipe_FormClosing;
            this.Activated += FrmRecipe_Activated;
        }

        private void FrmRecipe_Activated(object? sender, EventArgs e)
        {
            if (recipeid > 0)
            {
                SetBindingSourceDataSource();
                SetComboBoxBinding();
            }
        }
        public void ShowForm(int recipeidvalue)
        {
            recipeid = recipeidvalue;
            this.Tag = recipeid;
            SetBindingSourceDataSource();

            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
                DisableUnavailableButtons();
            }

            BindData();
            this.Text = DataHandling.GetNameOfOpenRecord("Recipe", dtrecipe);
            this.Show();
        }
        private void BindData()
        {
            SetComboBoxBinding();
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, bindsource);
        }
        public void OnFormShown()
        {
            if (recipeid > 0)
            {
                LoadRecipeIngredients();
                LoadRecipeDirections();
            }
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            isdeleting = true;
            Delete();
        }
        private bool Save()
        {
            bool b = false;

            Application.UseWaitCursor = true;
            try
            {
                DataHandling.SaveDataRows(dtrecipe, "Recipe");
                b = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }
        private void Delete()
        {
            Application.UseWaitCursor = true;
            try
            {
                var response = MessageBox.Show($"Are you sure you want to delete {this.Text}?", "Delete Recipe", MessageBoxButtons.YesNo);
                if (response == DialogResult.No)
                {
                    return;
                }
                DataHandling.Delete("Recipe", recipeid);
                this.Close();
                isdeleting = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        private void LoadRecipeIngredients()
        {
            RefreshRecipeIngredient();
            WindowsFormsUtility.AddComboBoxToGrid(gIngredient, DataHandling.GetDataList("Measurement", true), "Measurement", "MeasurementType");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredient, DataHandling.GetDataList("Ingredient", true), "Ingredient", "IngredientName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredient, deletecolumnname);
        }
        private void LoadRecipeDirections()
        {
            RefreshRecipeDirection();
            WindowsFormsUtility.AddDeleteButtonToGrid(gDirections, deletecolumnname);
        }
        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            try
            {
                DataHandling.SaveChildRecords(dtrecipeingredient, recipeid, "RecipeIngredient", "Recipe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void BtnSaveDirections_Click(object? sender, EventArgs e)
        {
            try
            {
                DataHandling.SaveChildRecords(dtrecipedirection, recipeid, "RecipeDirection", "Recipe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void GIngredient_MouseClick(object? sender, MouseEventArgs e)
        {
            var hittestinfo = gIngredient.HitTest(e.X, e.Y);

            if (gIngredient.Columns[hittestinfo.ColumnIndex] is DataGridViewButtonColumn)
            {
                int id = WindowsFormsUtility.GetIdFromGrid(gIngredient, hittestinfo.RowIndex, "RecipeIngredientId");
                try
                {
                    DataHandling.Delete("RecipeIngredient", id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DeleteRecipeIngredient");
                }

                RefreshRecipeIngredient();
            }
        }
        private void GDirections_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gDirections, e.RowIndex, "RecipeDirectionId");
            try
            {
                DataHandling.Delete("RecipeDirection", id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DeleteRecipeDirection");
            }

            RefreshRecipeDirection();
        }
        
        private void RefreshRecipeIngredient()
        {
            dtrecipeingredient = DataHandling.LoadChildRecords("RecipeIngredient", recipeid, "Recipe");
            gIngredient.DataSource = dtrecipeingredient;
            WindowsFormsUtility.FormatGridForEdit(gIngredient, "RecipeIngredient");
        }
        private void RefreshRecipeDirection()
        {
            dtrecipedirection = DataHandling.LoadChildRecords("RecipeDirection", recipeid, "Recipe");
            gDirections.DataSource = dtrecipedirection;
            WindowsFormsUtility.FormatGridForEdit(gDirections, "RecipeDirection");
        }
        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), recipeid);
            }
        }
        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtrecipe) == true && isdeleting == false)
            {
                var response = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", "Save Recipe", MessageBoxButtons.YesNoCancel);

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
        private void DisableUnavailableButtons()
        {
            WindowsFormsUtility.ManageAvailableButtons(false, btnDelete);
            WindowsFormsUtility.ManageAvailableButtons(false, btnSaveIngredients);
            WindowsFormsUtility.ManageAvailableButtons(false, btnSaveDirections);
            WindowsFormsUtility.ManageAvailableButtons(false, btnChangeStatus);
        }
        public void SetBindingSourceDataSource()
        {
            dtrecipe = DataHandling.Load("Recipe", recipeid);
            bindsource.DataSource = dtrecipe;
        }
        private void SetComboBoxBinding()
        {
            lstCuisineType.DataBindings.Clear();
            lstUsername.DataBindings.Clear();
            DataTable dtcuisine = DataHandling.GetDataList("Cuisine");
            DataTable dtuser = DataHandling.GetDataList("User");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUsername, dtuser, dtrecipe, "User");
        }
    }
}