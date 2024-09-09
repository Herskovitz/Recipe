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

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int RecipeId)
        {
            string sql = "select r.RecipeName, c.CuisineType, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, u.Username " +
                                                                            "from Recipe r join Cuisine c on r.CuisineId = c.CuisineId join Users u on r.UserId = u.UserId where r.RecipeId = " + RecipeId.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            lblCuisine.DataBindings.Add("Text", dt, "CuisineType");
            txtCalories.DataBindings.Add("Text", dt, "Calories");
            txtDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            lblRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            lblUser.DataBindings.Add("Text", dt, "Username");
            this.Show();
        }
    }
}
