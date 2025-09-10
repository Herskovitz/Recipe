namespace RecipeWinForms
{
    partial class frmRecipe
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
            lblCaptionName = new Label();
            lblCaptionCuisine = new Label();
            txtRecipeName = new TextBox();
            lstCuisineType = new ComboBox();
            lblCaptionCalories = new Label();
            txtCalories = new TextBox();
            lblCaptionUser = new Label();
            lstUsername = new ComboBox();
            lblCaptionRecipeStatus = new Label();
            txtRecipeStatus = new TextBox();
            lblStatusDates = new Label();
            tblStatusDates = new TableLayoutPanel();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            txtDateDraftedAsDateOnly = new TextBox();
            txtDatePublishedAsDateOnly = new TextBox();
            txtDateArchivedAsDateOnly = new TextBox();
            btnChangeStatus = new Button();
            tbChildRecords = new TabControl();
            tbIngredients = new TabPage();
            tblIngredients = new TableLayoutPanel();
            gIngredient = new DataGridView();
            btnSaveIngredients = new Button();
            tbDirections = new TabPage();
            tblDirections = new TableLayoutPanel();
            gDirections = new DataGridView();
            btnSaveDirections = new Button();
            tblButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            tblMain.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tbChildRecords.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredient).BeginInit();
            tbDirections.SuspendLayout();
            tblDirections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDirections).BeginInit();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblCaptionName, 0, 0);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 1);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(lstCuisineType, 1, 1);
            tblMain.Controls.Add(lblCaptionCalories, 0, 3);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(lblCaptionUser, 0, 2);
            tblMain.Controls.Add(lstUsername, 1, 2);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 4);
            tblMain.Controls.Add(txtRecipeStatus, 1, 4);
            tblMain.Controls.Add(lblStatusDates, 0, 5);
            tblMain.Controls.Add(tblStatusDates, 1, 5);
            tblMain.Controls.Add(tbChildRecords, 0, 7);
            tblMain.Controls.Add(tblButtons, 0, 8);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.967671F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.96767044F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.96767044F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.96767044F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.96767044F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.96767044F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.020067F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 42.14047F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0334454F));
            tblMain.Size = new Size(1053, 567);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionName
            // 
            lblCaptionName.AutoSize = true;
            lblCaptionName.Font = new Font("Segoe UI", 12F);
            lblCaptionName.Location = new Point(3, 0);
            lblCaptionName.Name = "lblCaptionName";
            lblCaptionName.Size = new Size(126, 28);
            lblCaptionName.TabIndex = 0;
            lblCaptionName.Text = "Recipe Name";
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Font = new Font("Segoe UI", 12F);
            lblCaptionCuisine.Location = new Point(3, 39);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(74, 28);
            lblCaptionCuisine.TabIndex = 2;
            lblCaptionCuisine.Text = "Cuisine";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(136, 3);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(914, 33);
            txtRecipeName.TabIndex = 0;
            // 
            // lstCuisineType
            // 
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(136, 42);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(328, 28);
            lstCuisineType.TabIndex = 1;
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Font = new Font("Segoe UI", 12F);
            lblCaptionCalories.Location = new Point(3, 117);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(81, 28);
            lblCaptionCalories.TabIndex = 4;
            lblCaptionCalories.Text = "Calories";
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(136, 120);
            txtCalories.Multiline = true;
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(914, 33);
            txtCalories.TabIndex = 3;
            // 
            // lblCaptionUser
            // 
            lblCaptionUser.AutoSize = true;
            lblCaptionUser.Font = new Font("Segoe UI", 12F);
            lblCaptionUser.Location = new Point(3, 78);
            lblCaptionUser.Name = "lblCaptionUser";
            lblCaptionUser.Size = new Size(51, 28);
            lblCaptionUser.TabIndex = 14;
            lblCaptionUser.Text = "User";
            // 
            // lstUsername
            // 
            lstUsername.FormattingEnabled = true;
            lstUsername.Location = new Point(136, 81);
            lstUsername.Name = "lstUsername";
            lstUsername.Size = new Size(328, 28);
            lstUsername.TabIndex = 2;
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Font = new Font("Segoe UI", 12F);
            lblCaptionRecipeStatus.Location = new Point(3, 156);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(127, 28);
            lblCaptionRecipeStatus.TabIndex = 12;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Enabled = false;
            txtRecipeStatus.Location = new Point(136, 159);
            txtRecipeStatus.Multiline = true;
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.Size = new Size(914, 33);
            txtRecipeStatus.TabIndex = 4;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusDates.Location = new Point(3, 195);
            lblStatusDates.Name = "lblStatusDates";
            tblMain.SetRowSpan(lblStatusDates, 2);
            lblStatusDates.Size = new Size(127, 73);
            lblStatusDates.TabIndex = 20;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 4;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblStatusDates.Controls.Add(lblDateDrafted, 0, 0);
            tblStatusDates.Controls.Add(lblDatePublished, 1, 0);
            tblStatusDates.Controls.Add(lblDateArchived, 2, 0);
            tblStatusDates.Controls.Add(txtDateDraftedAsDateOnly, 0, 1);
            tblStatusDates.Controls.Add(txtDatePublishedAsDateOnly, 1, 1);
            tblStatusDates.Controls.Add(txtDateArchivedAsDateOnly, 2, 1);
            tblStatusDates.Controls.Add(btnChangeStatus, 3, 0);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(136, 198);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 3;
            tblMain.SetRowSpan(tblStatusDates, 2);
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.Size = new Size(914, 67);
            tblStatusDates.TabIndex = 21;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateDrafted.Location = new Point(3, 0);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(268, 22);
            lblDateDrafted.TabIndex = 0;
            lblDateDrafted.Text = "Drafted";
            lblDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatePublished.Location = new Point(277, 0);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(268, 22);
            lblDatePublished.TabIndex = 1;
            lblDatePublished.Text = "Published";
            lblDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateArchived
            // 
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateArchived.Location = new Point(551, 0);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(268, 22);
            lblDateArchived.TabIndex = 2;
            lblDateArchived.Text = "Archived";
            lblDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDateDraftedAsDateOnly
            // 
            txtDateDraftedAsDateOnly.Dock = DockStyle.Fill;
            txtDateDraftedAsDateOnly.Enabled = false;
            txtDateDraftedAsDateOnly.Location = new Point(3, 25);
            txtDateDraftedAsDateOnly.Multiline = true;
            txtDateDraftedAsDateOnly.Name = "txtDateDraftedAsDateOnly";
            tblStatusDates.SetRowSpan(txtDateDraftedAsDateOnly, 2);
            txtDateDraftedAsDateOnly.Size = new Size(268, 39);
            txtDateDraftedAsDateOnly.TabIndex = 0;
            // 
            // txtDatePublishedAsDateOnly
            // 
            txtDatePublishedAsDateOnly.Dock = DockStyle.Fill;
            txtDatePublishedAsDateOnly.Enabled = false;
            txtDatePublishedAsDateOnly.Location = new Point(277, 25);
            txtDatePublishedAsDateOnly.Multiline = true;
            txtDatePublishedAsDateOnly.Name = "txtDatePublishedAsDateOnly";
            tblStatusDates.SetRowSpan(txtDatePublishedAsDateOnly, 2);
            txtDatePublishedAsDateOnly.Size = new Size(268, 39);
            txtDatePublishedAsDateOnly.TabIndex = 1;
            // 
            // txtDateArchivedAsDateOnly
            // 
            txtDateArchivedAsDateOnly.Dock = DockStyle.Fill;
            txtDateArchivedAsDateOnly.Enabled = false;
            txtDateArchivedAsDateOnly.Location = new Point(551, 25);
            txtDateArchivedAsDateOnly.Multiline = true;
            txtDateArchivedAsDateOnly.Name = "txtDateArchivedAsDateOnly";
            tblStatusDates.SetRowSpan(txtDateArchivedAsDateOnly, 2);
            txtDateArchivedAsDateOnly.Size = new Size(268, 39);
            txtDateArchivedAsDateOnly.TabIndex = 2;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.AccessibleRole = AccessibleRole.PropertyPage;
            btnChangeStatus.BackColor = Color.LemonChiffon;
            btnChangeStatus.Dock = DockStyle.Fill;
            btnChangeStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeStatus.Location = new Point(825, 3);
            btnChangeStatus.Name = "btnChangeStatus";
            tblStatusDates.SetRowSpan(btnChangeStatus, 3);
            btnChangeStatus.Size = new Size(86, 61);
            btnChangeStatus.TabIndex = 3;
            btnChangeStatus.Text = "&Change  Status";
            btnChangeStatus.UseVisualStyleBackColor = false;
            // 
            // tbChildRecords
            // 
            tblMain.SetColumnSpan(tbChildRecords, 2);
            tbChildRecords.Controls.Add(tbIngredients);
            tbChildRecords.Controls.Add(tbDirections);
            tbChildRecords.Dock = DockStyle.Fill;
            tbChildRecords.Location = new Point(3, 271);
            tbChildRecords.Name = "tbChildRecords";
            tbChildRecords.SelectedIndex = 0;
            tbChildRecords.Size = new Size(1047, 232);
            tbChildRecords.TabIndex = 22;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngredients);
            tbIngredients.Location = new Point(4, 29);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(1039, 199);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblIngredients.Controls.Add(gIngredient, 0, 1);
            tblIngredients.Controls.Add(btnSaveIngredients, 0, 0);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 23F));
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 77F));
            tblIngredients.Size = new Size(1033, 193);
            tblIngredients.TabIndex = 0;
            // 
            // gIngredient
            // 
            gIngredient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredient.Dock = DockStyle.Fill;
            gIngredient.Location = new Point(3, 47);
            gIngredient.Name = "gIngredient";
            gIngredient.RowHeadersWidth = 51;
            gIngredient.Size = new Size(1027, 143);
            gIngredient.TabIndex = 1;
            // 
            // btnSaveIngredients
            // 
            btnSaveIngredients.BackColor = Color.DodgerBlue;
            btnSaveIngredients.Dock = DockStyle.Left;
            btnSaveIngredients.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveIngredients.ForeColor = Color.Transparent;
            btnSaveIngredients.Location = new Point(3, 3);
            btnSaveIngredients.Name = "btnSaveIngredients";
            btnSaveIngredients.Size = new Size(82, 38);
            btnSaveIngredients.TabIndex = 0;
            btnSaveIngredients.Text = "Save";
            btnSaveIngredients.UseVisualStyleBackColor = false;
            // 
            // tbDirections
            // 
            tbDirections.Controls.Add(tblDirections);
            tbDirections.Location = new Point(4, 29);
            tbDirections.Name = "tbDirections";
            tbDirections.Padding = new Padding(3);
            tbDirections.Size = new Size(1039, 199);
            tbDirections.TabIndex = 1;
            tbDirections.Text = "Directions";
            tbDirections.UseVisualStyleBackColor = true;
            // 
            // tblDirections
            // 
            tblDirections.ColumnCount = 1;
            tblDirections.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDirections.Controls.Add(gDirections, 0, 1);
            tblDirections.Controls.Add(btnSaveDirections, 0, 0);
            tblDirections.Dock = DockStyle.Fill;
            tblDirections.Location = new Point(3, 3);
            tblDirections.Name = "tblDirections";
            tblDirections.RowCount = 2;
            tblDirections.RowStyles.Add(new RowStyle(SizeType.Percent, 23F));
            tblDirections.RowStyles.Add(new RowStyle(SizeType.Percent, 77F));
            tblDirections.Size = new Size(1033, 193);
            tblDirections.TabIndex = 0;
            // 
            // gDirections
            // 
            gDirections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gDirections.Dock = DockStyle.Fill;
            gDirections.Location = new Point(3, 47);
            gDirections.Name = "gDirections";
            gDirections.RowHeadersWidth = 51;
            gDirections.Size = new Size(1027, 143);
            gDirections.TabIndex = 1;
            // 
            // btnSaveDirections
            // 
            btnSaveDirections.BackColor = Color.DodgerBlue;
            btnSaveDirections.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveDirections.ForeColor = Color.Transparent;
            btnSaveDirections.Location = new Point(3, 3);
            btnSaveDirections.Name = "btnSaveDirections";
            btnSaveDirections.Size = new Size(82, 38);
            btnSaveDirections.TabIndex = 0;
            btnSaveDirections.Text = "Save";
            btnSaveDirections.UseVisualStyleBackColor = false;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 5;
            tblMain.SetColumnSpan(tblButtons, 2);
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblButtons.Controls.Add(btnSave, 3, 0);
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 509);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(1047, 55);
            tblButtons.TabIndex = 23;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.HighlightText;
            btnSave.Location = new Point(578, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(151, 49);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.HighlightText;
            btnDelete.Location = new Point(317, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 49);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 567);
            Controls.Add(tblMain);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tbChildRecords.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gIngredient).EndInit();
            tbDirections.ResumeLayout(false);
            tblDirections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gDirections).EndInit();
            tblButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionName;
        private Label lblCaptionCuisine;
        private Label lblCaptionCalories;
        private Label lblCaptionRecipeStatus;
        private Label lblCaptionUser;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private ComboBox lstCuisineType;
       // private ComboBox lstUser;
        private TextBox txtRecipeStatus;
        private ComboBox lstUsername;
        private Label lblStatusDates;
        private TableLayoutPanel tblStatusDates;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private TextBox txtDateDraftedAsDateOnly;
        private TextBox txtDatePublishedAsDateOnly;
        private TextBox txtDateArchivedAsDateOnly;
        private TabControl tbChildRecords;
        private TabPage tbIngredients;
        private TabPage tbDirections;
        private TableLayoutPanel tblIngredients;
        private Button btnSaveIngredients;
        private DataGridView gIngredient;
        private TableLayoutPanel tblDirections;
        private Button btnSaveDirections;
        private DataGridView gDirections;
        private TableLayoutPanel tblButtons;
        private Button btnSave;
        private Button btnDelete;
        private Button btnChangeStatus;
    }
}