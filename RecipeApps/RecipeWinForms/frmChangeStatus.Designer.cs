namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            tblCurrentStatus = new TableLayoutPanel();
            lblCurrentStatus = new Label();
            txtRecipeStatus = new TextBox();
            txtRecipeName = new TextBox();
            tblMain = new TableLayoutPanel();
            tblStatusDates = new TableLayoutPanel();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            lblStatusDates = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tblButtons = new TableLayoutPanel();
            btnDraft = new Button();
            btnPublish = new Button();
            btnArchive = new Button();
            tblCurrentStatus.SuspendLayout();
            tblMain.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblCurrentStatus
            // 
            tblCurrentStatus.ColumnCount = 4;
            tblCurrentStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tblCurrentStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tblCurrentStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tblCurrentStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9981289F));
            tblCurrentStatus.Controls.Add(lblCurrentStatus, 1, 0);
            tblCurrentStatus.Controls.Add(txtRecipeStatus, 2, 0);
            tblCurrentStatus.Dock = DockStyle.Fill;
            tblCurrentStatus.Location = new Point(3, 115);
            tblCurrentStatus.Name = "tblCurrentStatus";
            tblCurrentStatus.RowCount = 1;
            tblCurrentStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCurrentStatus.Size = new Size(794, 106);
            tblCurrentStatus.TabIndex = 1;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Dock = DockStyle.Fill;
            lblCurrentStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStatus.Location = new Point(201, 0);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(192, 106);
            lblCurrentStatus.TabIndex = 0;
            lblCurrentStatus.Text = "Current Status:";
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Anchor = AnchorStyles.None;
            txtRecipeStatus.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRecipeStatus.Location = new Point(432, 38);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.Size = new Size(125, 30);
            txtRecipeStatus.TabIndex = 2;
            txtRecipeStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.None;
            txtRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRecipeName.Location = new Point(64, 39);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(672, 34);
            txtRecipeName.TabIndex = 0;
            txtRecipeName.TextAlign = HorizontalAlignment.Center;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(txtRecipeName, 0, 0);
            tblMain.Controls.Add(tblCurrentStatus, 0, 1);
            tblMain.Controls.Add(tblStatusDates, 0, 2);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 6;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            tblStatusDates.Controls.Add(txtDateDrafted, 2, 2);
            tblStatusDates.Controls.Add(txtDatePublished, 3, 2);
            tblStatusDates.Controls.Add(txtDateArchived, 4, 2);
            tblStatusDates.Controls.Add(lblDrafted, 2, 1);
            tblStatusDates.Controls.Add(lblPublished, 3, 1);
            tblStatusDates.Controls.Add(lblArchived, 4, 1);
            tblStatusDates.Controls.Add(lblStatusDates, 1, 1);
            tblStatusDates.Controls.Add(tableLayoutPanel1, 0, 0);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(3, 227);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 5;
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblStatusDates.Size = new Size(794, 106);
            tblStatusDates.TabIndex = 2;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Location = new Point(267, 39);
            txtDateDrafted.Multiline = true;
            txtDateDrafted.Name = "txtDateDrafted";
            tblStatusDates.SetRowSpan(txtDateDrafted, 2);
            txtDateDrafted.Size = new Size(126, 52);
            txtDateDrafted.TabIndex = 1;
            txtDateDrafted.TextAlign = HorizontalAlignment.Center;
            txtDateDrafted.UseWaitCursor = true;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(399, 39);
            txtDatePublished.Multiline = true;
            txtDatePublished.Name = "txtDatePublished";
            tblStatusDates.SetRowSpan(txtDatePublished, 2);
            txtDatePublished.Size = new Size(126, 52);
            txtDatePublished.TabIndex = 2;
            txtDatePublished.TextAlign = HorizontalAlignment.Center;
            txtDatePublished.UseWaitCursor = true;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(531, 39);
            txtDateArchived.Multiline = true;
            txtDateArchived.Name = "txtDateArchived";
            tblStatusDates.SetRowSpan(txtDateArchived, 2);
            txtDateArchived.Size = new Size(126, 52);
            txtDateArchived.TabIndex = 3;
            txtDateArchived.TextAlign = HorizontalAlignment.Center;
            txtDateArchived.UseWaitCursor = true;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Location = new Point(267, 10);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(126, 26);
            lblDrafted.TabIndex = 4;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Location = new Point(399, 10);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(126, 26);
            lblPublished.TabIndex = 5;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Location = new Point(531, 10);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(126, 26);
            lblArchived.TabIndex = 6;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusDates.Location = new Point(135, 10);
            lblStatusDates.Name = "lblStatusDates";
            tblStatusDates.SetRowSpan(lblStatusDates, 3);
            lblStatusDates.Size = new Size(126, 84);
            lblStatusDates.TabIndex = 7;
            lblStatusDates.Text = "Status Dates:";
            lblStatusDates.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(126, 4);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 7;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tblButtons.Controls.Add(btnDraft, 1, 1);
            tblButtons.Controls.Add(btnPublish, 3, 1);
            tblButtons.Controls.Add(btnArchive, 5, 1);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 339);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 3;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblButtons.Size = new Size(794, 108);
            tblButtons.TabIndex = 3;
            // 
            // btnDraft
            // 
            btnDraft.Dock = DockStyle.Fill;
            btnDraft.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDraft.Location = new Point(137, 35);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(136, 48);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            btnPublish.Dock = DockStyle.Fill;
            btnPublish.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPublish.Location = new Point(326, 35);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(136, 48);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.Dock = DockStyle.Fill;
            btnArchive.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnArchive.Location = new Point(515, 35);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(136, 48);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmChangeStatus";
            Text = "Change Status";
            tblCurrentStatus.ResumeLayout(false);
            tblCurrentStatus.PerformLayout();
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tblButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblCurrentStatus;
        private Label lblCurrentStatus;
        private TextBox txtRecipeStatus;
        private TextBox txtRecipeName;
        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblStatusDates;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblStatusDates;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tblButtons;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
    }
}