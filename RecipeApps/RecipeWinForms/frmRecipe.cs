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
        List<Button> lstbtnenable = new();


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
            txtCalories.TextChanged += TxtCalories_TextChanged;
            gIngredient.EditingControlShowing += GIngredient_EditingControlShowing;
            lstbtnenable = new() { btnDelete, btnSaveIngredients, btnSaveDirections, btnChangeStatus };
        }

        private void GIngredient_EditingControlShowing(object? sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox ingtxtbox = e.Control as TextBox;
            if (ingtxtbox != null)
            {
                ingtxtbox.TextChanged -= Ingtxtbox_TextChanged;
                ingtxtbox.TextChanged += Ingtxtbox_TextChanged;
            }
        }

        private void Ingtxtbox_TextChanged(object? sender, EventArgs e)
        {
            TextBox ingtxtbox = sender as TextBox;
            WindowsFormsUtility.PromtUserForNonNumericEntryInNumericOnlyTextBox(ingtxtbox,btnSaveIngredients);
            if (!decimal.TryParse(ingtxtbox.Text, out _))
            {
                ingtxtbox.Clear();
            }
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
                WindowsFormsUtility.ManageAvailableButtons(false, lstbtnenable);
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
            WindowsFormsUtility.SetControlBinding(txtDateDraftedAsDateOnly, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublishedAsDateOnly, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchivedAsDateOnly, bindsource);
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
                if (recipeid == 0)
                {
                    WindowsFormsUtility.ManageAvailableButtons(true, lstbtnenable);


                    if (gIngredient.Columns.Count < 1)
                    {
                        LoadRecipeIngredients();
                    }
                    if (gDirections.Columns.Count < 1)
                    {
                        LoadRecipeDirections();
                    }
                }
                else
                {
                    this.Close();
                    MessageBox.Show("Recipe saved successfully!", "Save Recipe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            recipeid = (int)dtrecipe.Rows[0]["RecipeId"];
            this.Tag = recipeid;
            this.Text = DataHandling.GetNameOfOpenRecord("Recipe", dtrecipe);
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
            WindowsFormsUtility.AddComboBoxToGrid(gIngredient, DataHandling.GetDataList("Ingredient"), "Ingredient", "IngredientName");
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
            int id = WindowsFormsUtility.GetIdFromGrid(gIngredient, hittestinfo.RowIndex, "RecipeIngredientId");

            if (hittestinfo.RowIndex < 0 || hittestinfo.ColumnIndex < 0)
            {
                return;
            }

            if (gIngredient.Columns[hittestinfo.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (id > 0)
                {
                    try
                    {
                        DataHandling.Delete("RecipeIngredient", id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Delete Recipe Ingredient");
                    }
                }
                else
                {
                    MessageBox.Show("Unsaved records cannot be deleted.", "Delete Recipe Ingredient");
                    return;
                }

                RefreshRecipeIngredient();

            }
        }
        private void GDirections_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gDirections, e.RowIndex, "RecipeDirectionId");
            if (id > 0)
            {
                try
                {
                    DataHandling.Delete("RecipeDirection", id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete Recipe Direction");
                }
            }
            else
            {
                MessageBox.Show("Unsaved records cannot be deleted.", "Delete Recipe Direction");
                return;
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
            WindowsFormsUtility.PromtUserForNonNumericEntryInNumericOnlyTextBox(txtCalories, btnSave);
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
        private void TxtCalories_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.PromtUserForNonNumericEntryInNumericOnlyTextBox(txtCalories, btnSave);
        }
    }
}