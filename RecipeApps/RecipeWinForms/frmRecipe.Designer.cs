﻿namespace RecipeWinForms
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
            lblCaptionCalories = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionDateDrafted = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionRecipeStatus = new Label();
            lblCaptionUser = new Label();
            txtRecipeName = new TextBox();
            txtCalories = new TextBox();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            lblCuisine = new Label();
            lblRecipeStatus = new Label();
            lblUser = new Label();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblCaptionName, 0, 0);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 1);
            tblMain.Controls.Add(lblCaptionCalories, 0, 2);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 4);
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 3);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 5);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 6);
            tblMain.Controls.Add(lblCaptionUser, 0, 7);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(txtCalories, 1, 2);
            tblMain.Controls.Add(txtDateDrafted, 1, 3);
            tblMain.Controls.Add(txtDatePublished, 1, 4);
            tblMain.Controls.Add(txtDateArchived, 1, 5);
            tblMain.Controls.Add(lblCuisine, 1, 1);
            tblMain.Controls.Add(lblRecipeStatus, 1, 6);
            tblMain.Controls.Add(lblUser, 1, 7);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.500001F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.500001F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.500001F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.500001F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.500001F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.500001F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(800, 450);
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
            lblCaptionCuisine.Location = new Point(3, 56);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(74, 28);
            lblCaptionCuisine.TabIndex = 1;
            lblCaptionCuisine.Text = "Cuisine";
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Font = new Font("Segoe UI", 12F);
            lblCaptionCalories.Location = new Point(3, 112);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(81, 28);
            lblCaptionCalories.TabIndex = 2;
            lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Font = new Font("Segoe UI", 12F);
            lblCaptionDatePublished.Location = new Point(3, 224);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(138, 28);
            lblCaptionDatePublished.TabIndex = 4;
            lblCaptionDatePublished.Text = "DatePublished";
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Font = new Font("Segoe UI", 12F);
            lblCaptionDateDrafted.Location = new Point(3, 168);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(119, 28);
            lblCaptionDateDrafted.TabIndex = 3;
            lblCaptionDateDrafted.Text = "DateDrafted";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Font = new Font("Segoe UI", 12F);
            lblCaptionDateArchived.Location = new Point(3, 280);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(130, 28);
            lblCaptionDateArchived.TabIndex = 5;
            lblCaptionDateArchived.Text = "DateArchived";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Font = new Font("Segoe UI", 12F);
            lblCaptionRecipeStatus.Location = new Point(3, 336);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(122, 28);
            lblCaptionRecipeStatus.TabIndex = 6;
            lblCaptionRecipeStatus.Text = "RecipeStatus";
            // 
            // lblCaptionUser
            // 
            lblCaptionUser.AutoSize = true;
            lblCaptionUser.Font = new Font("Segoe UI", 12F);
            lblCaptionUser.Location = new Point(3, 392);
            lblCaptionUser.Name = "lblCaptionUser";
            lblCaptionUser.Size = new Size(51, 28);
            lblCaptionUser.TabIndex = 7;
            lblCaptionUser.Text = "User";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(147, 3);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(650, 50);
            txtRecipeName.TabIndex = 8;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(147, 115);
            txtCalories.Multiline = true;
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(650, 50);
            txtCalories.TabIndex = 10;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Location = new Point(147, 171);
            txtDateDrafted.Multiline = true;
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(650, 50);
            txtDateDrafted.TabIndex = 11;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(147, 227);
            txtDatePublished.Multiline = true;
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(650, 50);
            txtDatePublished.TabIndex = 12;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(147, 283);
            txtDateArchived.Multiline = true;
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(650, 50);
            txtDateArchived.TabIndex = 13;
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Location = new Point(147, 56);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(650, 56);
            lblCuisine.TabIndex = 16;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(147, 336);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(650, 56);
            lblRecipeStatus.TabIndex = 17;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Location = new Point(147, 392);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(650, 58);
            lblUser.TabIndex = 18;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionName;
        private Label lblCaptionCuisine;
        private Label lblCaptionCalories;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeStatus;
        private Label lblCaptionUser;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private Label lblCuisine;
        private Label lblRecipeStatus;
        private Label lblUser;
    }
}