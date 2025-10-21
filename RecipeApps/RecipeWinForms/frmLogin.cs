using RecipeSystem;
using RecipeWinForms.Properties;
using System.Configuration;

namespace RecipeWinForms
{
    public partial class frmLogin : Form
    {
        bool loginsuccess = false;
        public frmLogin()
        {
            InitializeComponent();
            btnCancel.Click += BtnCancel_Click;
            btnLogin.Click += BtnLogin_Click;
        }

        public bool ShowLogin()
        {
            txtUsername.Text = Settings.Default.userid;
            txtPassword.Text = Settings.Default.password;
            this.ShowDialog();
            return loginsuccess;
        }
        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            try
            {
                string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
                DBManager.SetConnectionString(connstring, true, txtUsername.Text,txtPassword.Text);
                loginsuccess = true;
                Settings.Default.userid = txtUsername.Text;
                Settings.Default.password = txtPassword.Text;
                Settings.Default.Save();
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Login. Please try again.", "Login Failed");
            }
        }
        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
