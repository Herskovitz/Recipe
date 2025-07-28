namespace RecipeWinForms
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            tblMain = new TableLayoutPanel();
            lblTitle = new Label();
            lblWelcome = new Label();
            gDashboard = new DataGridView();
            tblButtons = new TableLayoutPanel();
            btnRecipes = new Button();
            btnMeals = new Button();
            btnCookbooks = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDashboard).BeginInit();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblTitle, 0, 0);
            tblMain.Controls.Add(lblWelcome, 0, 1);
            tblMain.Controls.Add(gDashboard, 0, 2);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(3, 71);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(794, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = " Hearty Hearth Desktop App";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.HotTrack;
            lblWelcome.Location = new Point(3, 112);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(794, 112);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = resources.GetString("lblWelcome.Text");
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gDashboard
            // 
            gDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gDashboard.Dock = DockStyle.Fill;
            gDashboard.Location = new Point(3, 227);
            gDashboard.Name = "gDashboard";
            gDashboard.RowHeadersWidth = 51;
            gDashboard.Size = new Size(794, 174);
            gDashboard.TabIndex = 2;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 7;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.5366859F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9510841F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.5366869F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9510841F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.5366869F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9510841F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.5366869F));
            tblButtons.Controls.Add(btnRecipes, 1, 0);
            tblButtons.Controls.Add(btnMeals, 3, 0);
            tblButtons.Controls.Add(btnCookbooks, 5, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 407);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(794, 40);
            tblButtons.TabIndex = 3;
            // 
            // btnRecipes
            // 
            btnRecipes.BackColor = SystemColors.ButtonHighlight;
            btnRecipes.Dock = DockStyle.Fill;
            btnRecipes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnRecipes.ForeColor = Color.Navy;
            btnRecipes.Location = new Point(94, 3);
            btnRecipes.Name = "btnRecipes";
            btnRecipes.Size = new Size(136, 34);
            btnRecipes.TabIndex = 0;
            btnRecipes.Text = "Recipes";
            btnRecipes.UseVisualStyleBackColor = false;
            // 
            // btnMeals
            // 
            btnMeals.BackColor = SystemColors.ButtonHighlight;
            btnMeals.Dock = DockStyle.Fill;
            btnMeals.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnMeals.ForeColor = Color.Navy;
            btnMeals.Location = new Point(327, 3);
            btnMeals.Name = "btnMeals";
            btnMeals.Size = new Size(136, 34);
            btnMeals.TabIndex = 1;
            btnMeals.Text = "Meals";
            btnMeals.UseVisualStyleBackColor = false;
            // 
            // btnCookbooks
            // 
            btnCookbooks.BackColor = SystemColors.ButtonHighlight;
            btnCookbooks.Dock = DockStyle.Fill;
            btnCookbooks.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCookbooks.ForeColor = Color.Navy;
            btnCookbooks.Location = new Point(560, 3);
            btnCookbooks.Name = "btnCookbooks";
            btnCookbooks.Size = new Size(136, 34);
            btnCookbooks.TabIndex = 2;
            btnCookbooks.Text = "Cookbooks";
            btnCookbooks.UseVisualStyleBackColor = false;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gDashboard).EndInit();
            tblButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblTitle;
        private Label lblWelcome;
        private DataGridView gDashboard;
        private TableLayoutPanel tblButtons;
        private Button btnRecipes;
        private Button btnMeals;
        private Button btnCookbooks;
    }
}