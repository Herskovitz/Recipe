using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUWindowsFormsFramework;
using System.Diagnostics;
using RecipeSystem;
using RecordKeeperSystem;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        public frmRecipe()
        {
            InitializeComponent();
            btnDelete.Click += BtnDelete_Click;
            btnSave.Click += BtnSave_Click;
        }

        public void ShowForm(int recipeid)
        {
            dtrecipe = Recipe.Load(recipeid);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }

            DataTable dtcuisine = Recipe.GetCuisineList();
            DataTable dtuser = Recipe.GetUserList();

            WindowsFormsUtility.SetListBinding(lstCuisineType, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUsername, dtuser, dtrecipe, "User");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, dtrecipe);

            this.Show();
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                //ActiveForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        private void Delete()
        {
            Application.UseWaitCursor = true;
            try
            {
                var response = MessageBox.Show("Are you sure you want to delete this Recipe", "Delete Recipe", MessageBoxButtons.YesNo);
                if (response == DialogResult.No)
                {
                    return;
                }
                Recipe.Delete(dtrecipe);
                //ActiveForm.Close();
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
    }
}
