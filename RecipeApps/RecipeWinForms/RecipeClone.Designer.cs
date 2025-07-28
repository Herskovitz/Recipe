namespace RecipeWinForms
{
    partial class frmRecipeClone
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
            btnClone = new Button();
            lstRecipeName = new ComboBox();
            lblCloneMessage = new Label();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(btnClone, 0, 2);
            tblMain.Controls.Add(lstRecipeName, 0, 1);
            tblMain.Controls.Add(lblCloneMessage, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.Size = new Size(583, 297);
            tblMain.TabIndex = 0;
            // 
            // btnClone
            // 
            btnClone.Anchor = AnchorStyles.None;
            btnClone.BackColor = Color.DarkSlateGray;
            btnClone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClone.ForeColor = SystemColors.ControlLightLight;
            btnClone.Location = new Point(208, 162);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(166, 45);
            btnClone.TabIndex = 1;
            btnClone.Text = "Clone";
            btnClone.UseVisualStyleBackColor = false;
            // 
            // lstRecipeName
            // 
            lstRecipeName.Anchor = AnchorStyles.None;
            lstRecipeName.FormattingEnabled = true;
            lstRecipeName.Location = new Point(129, 97);
            lstRecipeName.Name = "lstRecipeName";
            lstRecipeName.Size = new Size(324, 28);
            lstRecipeName.TabIndex = 0;
            // 
            // lblCloneMessage
            // 
            lblCloneMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCloneMessage.AutoSize = true;
            lblCloneMessage.Location = new Point(3, 0);
            lblCloneMessage.Name = "lblCloneMessage";
            lblCloneMessage.Size = new Size(577, 74);
            lblCloneMessage.TabIndex = 2;
            lblCloneMessage.Text = "Please select a recipe from the dropdown menu below to create a clone.";
            lblCloneMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmRecipeClone
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 297);
            Controls.Add(tblMain);
            Name = "frmRecipeClone";
            Text = "Hearty Hearth - Clone a Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstRecipeName;
        private Button btnClone;
        private Label lblCloneMessage;
    }
}