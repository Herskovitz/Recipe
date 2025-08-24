using CPUFramework;
using CPUWindowsFormsFramework;
using RecipeSystem;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace RecipeWinForms
{
    public partial class frmChangeStatus : Form
    {
        BindingSource bindsource = new();
        int recipeid = 0;
        SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeChangeStatus");

        public frmChangeStatus()
        {
            InitializeComponent();
            btnArchive.Click += Btn_Click;
            btnPublish.Click += Btn_Click;
            btnDraft.Click += Btn_Click;
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var response = MessageBox.Show($"Are you sure you want to change the status to {btn.Text}?", "Change Recipe Status", MessageBoxButtons.YesNoCancel);
            switch (response)
            {
                case DialogResult.Yes:
                    SetStatusParamValuesAndButtonAvailability(btn.Text);                   
                    bindsource.DataSource = DataHandling.Load("Recipe", recipeid);
                    break;
                case DialogResult.No:
                case DialogResult.Cancel:
                    break;
            }
        }
        public void ShowForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            DataTable dtrecipe = DataHandling.Load("Recipe", recipeid);
            bindsource.DataSource = dtrecipe;
            BindData();
            SetButtonState();
            this.Text = "Change Status - " + DataHandling.GetNameOfOpenRecord("Recipe", dtrecipe);
        }
        private void BindData()
        {
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
        }
        private void DisableUnavailableButtons(bool draftenabled, bool publishedenabled, bool archivedenabled)
        {
            btnDraft.Enabled = draftenabled;
            btnPublish.Enabled = publishedenabled;
            btnArchive.Enabled = archivedenabled;
        }

        private void SetStatusParamValuesAndButtonAvailability(string status)
        {
            
            DateTime currentdate = DateTime.Now;
            object datedrafted = DBNull.Value;
            object datepublished = DBNull.Value;
            object datearchived = DBNull.Value;

            switch (status)
            {
                case "Draft":
                    datedrafted = currentdate;
                    DisableUnavailableButtons(false, true, true);
                    break;
                case "Publish":
                    datepublished = currentdate;
                    DisableUnavailableButtons(true, false, true);
                    break;
                case "Archive":
                    datearchived = currentdate;
                    DisableUnavailableButtons(true, true, false);
                    break;
            }
            SQLUtility.SetParamaterValue(cmd, "@DateDrafted", datedrafted);
            SQLUtility.SetParamaterValue(cmd, "@DatePublished", datepublished);
            SQLUtility.SetParamaterValue(cmd, "@DateArchived", datearchived);
            SQLUtility.SetParamaterValue(cmd, "@RecipeId", recipeid);
            SQLUtility.ExecuteSQL(cmd);
        }
        private void SetButtonState()
        {
            DataTable dtrecipe = DataHandling.Load("Recipe", recipeid);
            bindsource.DataSource = dtrecipe;
            string status = "";
            if (dtrecipe.Rows[0]["RecipeStatus"].ToString().Count() == 5)
            {
                status = "Draft";
            }
            else if (dtrecipe.Rows[0]["RecipeStatus"].ToString().Count() > 5)
            {
                status = dtrecipe.Rows[0]["RecipeStatus"].ToString().Substring(0, 7);
            }
            foreach (Control c in tblButtons.Controls)
            {
                if (c is Button && c.Text == status)
                {
                    c.Enabled = false;
                }
            }
        }
    }
}