namespace RecipeWinForms
{
    partial class frmCookbook
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
            tblMain = new TableLayoutPanel();
            lblCookbookName = new Label();
            lblUser = new Label();
            tblActivePriceDate = new TableLayoutPanel();
            lblPrice = new Label();
            lblDateCreated = new Label();
            lblActive = new Label();
            chkActive = new CheckBox();
            txtPrice = new TextBox();
            txtDateCreated = new TextBox();
            lstUsername = new ComboBox();
            tblRecipes = new TableLayoutPanel();
            gRecipes = new DataGridView();
            btnSaveRecipes = new Button();
            tblSaveDelete = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            tblCookbookName = new TableLayoutPanel();
            txtCookbookName = new TextBox();
            tblMain.SuspendLayout();
            tblActivePriceDate.SuspendLayout();
            tblRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipes).BeginInit();
            tblSaveDelete.SuspendLayout();
            tblCookbookName.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tblMain.Controls.Add(lblCookbookName, 0, 0);
            tblMain.Controls.Add(lblUser, 0, 1);
            tblMain.Controls.Add(tblActivePriceDate, 0, 2);
            tblMain.Controls.Add(lstUsername, 1, 1);
            tblMain.Controls.Add(tblRecipes, 0, 3);
            tblMain.Controls.Add(tblSaveDelete, 0, 4);
            tblMain.Controls.Add(tblCookbookName, 1, 0);
            tblMain.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3424006F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3424015F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3424006F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 58.6304054F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3424015F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // lblCookbookName
            // 
            lblCookbookName.AutoSize = true;
            lblCookbookName.Dock = DockStyle.Fill;
            lblCookbookName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCookbookName.Location = new Point(3, 0);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(194, 46);
            lblCookbookName.TabIndex = 0;
            lblCookbookName.Text = "Cookbook Name";
            lblCookbookName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(3, 46);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(194, 46);
            lblUser.TabIndex = 1;
            lblUser.Text = "User";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblActivePriceDate
            // 
            tblActivePriceDate.ColumnCount = 6;
            tblMain.SetColumnSpan(tblActivePriceDate, 6);
            tblActivePriceDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblActivePriceDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblActivePriceDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblActivePriceDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblActivePriceDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblActivePriceDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblActivePriceDate.Controls.Add(lblPrice, 0, 0);
            tblActivePriceDate.Controls.Add(lblDateCreated, 2, 0);
            tblActivePriceDate.Controls.Add(lblActive, 4, 0);
            tblActivePriceDate.Controls.Add(chkActive, 5, 0);
            tblActivePriceDate.Controls.Add(txtPrice, 1, 0);
            tblActivePriceDate.Controls.Add(txtDateCreated, 3, 0);
            tblActivePriceDate.Dock = DockStyle.Fill;
            tblActivePriceDate.Location = new Point(3, 95);
            tblActivePriceDate.Name = "tblActivePriceDate";
            tblActivePriceDate.RowCount = 1;
            tblActivePriceDate.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblActivePriceDate.Size = new Size(794, 40);
            tblActivePriceDate.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(3, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(126, 40);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Dock = DockStyle.Fill;
            lblDateCreated.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateCreated.Location = new Point(267, 0);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(126, 40);
            lblDateCreated.TabIndex = 1;
            lblDateCreated.Text = "Date Created";
            lblDateCreated.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Dock = DockStyle.Fill;
            lblActive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActive.Location = new Point(531, 0);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(126, 40);
            lblActive.TabIndex = 2;
            lblActive.Text = "Active";
            lblActive.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.CheckAlign = ContentAlignment.MiddleCenter;
            chkActive.Dock = DockStyle.Fill;
            chkActive.Location = new Point(663, 3);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(128, 34);
            chkActive.TabIndex = 2;
            chkActive.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(135, 3);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(126, 34);
            txtPrice.TabIndex = 0;
            // 
            // txtDateCreated
            // 
            txtDateCreated.Dock = DockStyle.Fill;
            txtDateCreated.Location = new Point(399, 3);
            txtDateCreated.Multiline = true;
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.ReadOnly = true;
            txtDateCreated.Size = new Size(126, 34);
            txtDateCreated.TabIndex = 1;
            // 
            // lstUsername
            // 
            lstUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstUsername.FormattingEnabled = true;
            lstUsername.Location = new Point(203, 49);
            lstUsername.Name = "lstUsername";
            lstUsername.Size = new Size(594, 28);
            lstUsername.TabIndex = 1;
            // 
            // tblRecipes
            // 
            tblRecipes.ColumnCount = 1;
            tblMain.SetColumnSpan(tblRecipes, 2);
            tblRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRecipes.Controls.Add(gRecipes, 0, 1);
            tblRecipes.Controls.Add(btnSaveRecipes, 0, 0);
            tblRecipes.Dock = DockStyle.Fill;
            tblRecipes.Location = new Point(3, 141);
            tblRecipes.Name = "tblRecipes";
            tblRecipes.RowCount = 2;
            tblRecipes.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tblRecipes.RowStyles.Add(new RowStyle(SizeType.Percent, 86F));
            tblRecipes.Size = new Size(794, 257);
            tblRecipes.TabIndex = 5;
            // 
            // gRecipes
            // 
            gRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipes.Dock = DockStyle.Fill;
            gRecipes.Location = new Point(3, 38);
            gRecipes.Name = "gRecipes";
            gRecipes.RowHeadersWidth = 51;
            gRecipes.Size = new Size(788, 216);
            gRecipes.TabIndex = 1;
            // 
            // btnSaveRecipes
            // 
            btnSaveRecipes.BackColor = Color.DodgerBlue;
            btnSaveRecipes.Dock = DockStyle.Left;
            btnSaveRecipes.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveRecipes.ForeColor = SystemColors.ButtonHighlight;
            btnSaveRecipes.Location = new Point(3, 3);
            btnSaveRecipes.Name = "btnSaveRecipes";
            btnSaveRecipes.Size = new Size(95, 29);
            btnSaveRecipes.TabIndex = 0;
            btnSaveRecipes.Text = "Save";
            btnSaveRecipes.UseVisualStyleBackColor = false;
            // 
            // tblSaveDelete
            // 
            tblSaveDelete.ColumnCount = 5;
            tblMain.SetColumnSpan(tblSaveDelete, 2);
            tblSaveDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25002F));
            tblSaveDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5833187F));
            tblSaveDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333324F));
            tblSaveDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5833187F));
            tblSaveDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.2500229F));
            tblSaveDelete.Controls.Add(btnSave, 1, 0);
            tblSaveDelete.Controls.Add(btnDelete, 3, 0);
            tblSaveDelete.Dock = DockStyle.Fill;
            tblSaveDelete.Location = new Point(3, 404);
            tblSaveDelete.Name = "tblSaveDelete";
            tblSaveDelete.RowCount = 1;
            tblSaveDelete.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSaveDelete.Size = new Size(794, 43);
            tblSaveDelete.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(251, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 37);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(432, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 37);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // tblCookbookName
            // 
            tblCookbookName.ColumnCount = 1;
            tblCookbookName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCookbookName.Controls.Add(txtCookbookName, 0, 0);
            tblCookbookName.Dock = DockStyle.Fill;
            tblCookbookName.Location = new Point(203, 3);
            tblCookbookName.Name = "tblCookbookName";
            tblCookbookName.RowCount = 1;
            tblCookbookName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCookbookName.Size = new Size(594, 40);
            tblCookbookName.TabIndex = 7;
            // 
            // txtCookbookName
            // 
            txtCookbookName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCookbookName.Location = new Point(3, 3);
            txtCookbookName.Multiline = true;
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(588, 34);
            txtCookbookName.TabIndex = 0;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmCookbook";
            Text = "Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblActivePriceDate.ResumeLayout(false);
            tblActivePriceDate.PerformLayout();
            tblRecipes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gRecipes).EndInit();
            tblSaveDelete.ResumeLayout(false);
            tblCookbookName.ResumeLayout(false);
            tblCookbookName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCookbookName;
        private Label lblUser;
        private TableLayoutPanel tblActivePriceDate;
        private Label lblPrice;
        private Label lblDateCreated;
        private Label lblActive;
        private ComboBox lstUsername;
        private CheckBox chkActive;
        private TextBox txtPrice;
        private TextBox txtDateCreated;
        private TableLayoutPanel tblRecipes;
        private Button btnSaveRecipes;
        private DataGridView gRecipes;
        private TableLayoutPanel tblSaveDelete;
        private Button btnSave;
        private Button btnDelete;
        private TableLayoutPanel tblCookbookName;
        private TextBox txtCookbookName;
    }
}