using CPUWindowsFormsFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        enum TableEnum { User, Cuisine, Ingredient, Measurement, Course }
        DataTable dtlist = new();
        TableEnum currenttable = TableEnum.User;
        string deletecolname = "deletecol";
        public frmDataMaintenance()
        {
            InitializeComponent();
            SetUpRadioButtons();
            BindData(currenttable);
            btnSave.Click += BtnSave_Click;
            gData.CellContentClick += GData_CellContentClick;
            gData.EditingControlShowing += GData_EditingControlShowing;
        }

        private void BindData(TableEnum table)
        {
            currenttable = table;
            dtlist = DataHandling.GetDataList(currenttable.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gData, currenttable.ToString());
        }
        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                DataHandling.SaveDataTables(dtlist, currenttable.ToString());
                b = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Save " + currenttable + " list");
            }
            finally 
            {
                Cursor = Cursors.Default;
            }
            return b;
        }
        private void Delete(int rowindex)
        {
            string message = ($"Are you sure you want to delete this {currenttable.ToString()}?");
            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, currenttable.ToString() + "Id");
            if (id != 0)
            {
                if (currenttable == TableEnum.User)
                {
                    message = "Deleting this User will delete all its related Recipes, Meals and Cookbooks. Are you sure you want to delete?";
                }
                var response = MessageBox.Show(message, "Delete " + currenttable.ToString(), MessageBoxButtons.YesNo);
                if (response == DialogResult.No)
                {
                    return;
                }
                try
                {
                    DataHandling.Delete(currenttable.ToString(), id);
                    BindData(currenttable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }

            }
            else if (id == 0 && rowindex < gData.Rows.Count)
            {
                try
                {
                    gData.Rows.Remove(gData.Rows[rowindex]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void SetUpRadioButtons()
        {
            foreach (Control c in pnlOptionButtons.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click; ;
                }
            }
            optUser.Tag = TableEnum.User;
            optCuisine.Tag = TableEnum.Cuisine;
            optIngredient.Tag = TableEnum.Ingredient;
            optMeasurement.Tag = TableEnum.Measurement;
            optCourse.Tag = TableEnum.Course;
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableEnum)
            {
                BindData((TableEnum)((Control)sender).Tag);
            }     
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].Name == deletecolname)
            {
                Delete(e.RowIndex);
            }
        }
        private void GData_EditingControlShowing(object? sender, DataGridViewEditingControlShowingEventArgs e)
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
    }
}
