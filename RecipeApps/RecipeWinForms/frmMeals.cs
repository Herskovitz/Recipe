using CPUFramework;
using CPUWindowsFormsFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeSystem;



namespace RecipeWinForms
{
    public partial class frmMeals : Form
    {
        public frmMeals()
        {
            InitializeComponent();
            this.Activated += FrmMeals_Activated;
        }

        private void FrmMeals_Activated(object? sender, EventArgs e)
        {
            gData.DataSource = Recipe.GetMealList();
            WindowsFormsUtility.FormatGridForDataList(gData, "Meal");
        }
    }
}
