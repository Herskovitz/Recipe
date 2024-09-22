using CPUFramework;
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

        public void ShowForm(int RecipeId)
        {
            string sql = "select r.*, c.CuisineType, u.Username from Recipe r join Cuisine c on c.CuisineId = r.CuisineId join Users u on u.UserId = r.UserId where r.RecipeId = " + RecipeId.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            if (RecipeId == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtcuisine = SQLUtility.GetDataTable("select CuisineId, CuisineType from Cuisine");
            DataTable dtuser = SQLUtility.GetDataTable("select UserId, Username from Users");

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
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            string sql = "";
            int id = (int)r["RecipeId"];

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                $"RecipeName = '{r["RecipeName"]}',",
                $"Calories = '{r["Calories"]}',",
                $"DateDrafted = '{r["DateDrafted"]}' where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert Recipe(CuisineId,UserId,RecipeName,Calories,DateDrafted,DatePublished)";
                sql += $"select '{r["CuisineId"]}','{r["UserId"]}','{r["RecipeName"]}','{r["Calories"]}','{r["DateDrafted"]}','{r["DatePublished"]}'";
            }

            Debug.Print(sql);
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }
        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }
    }
}
