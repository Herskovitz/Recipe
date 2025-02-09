using CPUWindowsFormsFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuMealList.Click += MnuMealList_Click;
            mnuRecipeList.Click += MnuRecipeList_Click;
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype);

            if (b == false)
            {
                Form? newfrm = null;

                if (frmtype == typeof(frmMeals))
                {
                    frmMeals f = new();
                    newfrm = f;
                }
                else if(frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f;
                }
                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    //newfrm.FormClosed += Frm_FormClosed;
                    //newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                }

                WindowsFormsUtility.SetupNav(tsMain);
            }
        }
        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }
        private void MnuMealList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMeals));
        }
    }
}
