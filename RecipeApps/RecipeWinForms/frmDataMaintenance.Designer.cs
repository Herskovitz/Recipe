namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            btnSave = new Button();
            pnlOptionButtons = new Panel();
            optCourse = new RadioButton();
            optMeasurement = new RadioButton();
            optIngredient = new RadioButton();
            optCuisine = new RadioButton();
            optUser = new RadioButton();
            gData = new DataGridView();
            tblMain.SuspendLayout();
            pnlOptionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(pnlOptionButtons, 0, 1);
            tblMain.Controls.Add(gData, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Left;
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 39);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // pnlOptionButtons
            // 
            pnlOptionButtons.Controls.Add(optCourse);
            pnlOptionButtons.Controls.Add(optMeasurement);
            pnlOptionButtons.Controls.Add(optIngredient);
            pnlOptionButtons.Controls.Add(optCuisine);
            pnlOptionButtons.Controls.Add(optUser);
            pnlOptionButtons.Dock = DockStyle.Fill;
            pnlOptionButtons.Location = new Point(3, 48);
            pnlOptionButtons.Name = "pnlOptionButtons";
            pnlOptionButtons.Size = new Size(154, 399);
            pnlOptionButtons.TabIndex = 1;
            // 
            // optCourse
            // 
            optCourse.AutoSize = true;
            optCourse.Location = new Point(9, 189);
            optCourse.Name = "optCourse";
            optCourse.Size = new Size(81, 24);
            optCourse.TabIndex = 4;
            optCourse.Text = "Courses";
            optCourse.UseVisualStyleBackColor = true;
            // 
            // optMeasurement
            // 
            optMeasurement.AutoSize = true;
            optMeasurement.Location = new Point(9, 148);
            optMeasurement.Name = "optMeasurement";
            optMeasurement.Size = new Size(126, 24);
            optMeasurement.TabIndex = 3;
            optMeasurement.Text = "Measurements";
            optMeasurement.UseVisualStyleBackColor = true;
            // 
            // optIngredient
            // 
            optIngredient.AutoSize = true;
            optIngredient.Location = new Point(9, 107);
            optIngredient.Name = "optIngredient";
            optIngredient.Size = new Size(104, 24);
            optIngredient.TabIndex = 2;
            optIngredient.Text = "Ingredients";
            optIngredient.UseVisualStyleBackColor = true;
            // 
            // optCuisine
            // 
            optCuisine.AutoSize = true;
            optCuisine.Location = new Point(9, 67);
            optCuisine.Name = "optCuisine";
            optCuisine.Size = new Size(83, 24);
            optCuisine.TabIndex = 1;
            optCuisine.Text = "Cuisines";
            optCuisine.UseVisualStyleBackColor = true;
            // 
            // optUser
            // 
            optUser.AutoSize = true;
            optUser.Checked = true;
            optUser.Location = new Point(9, 23);
            optUser.Name = "optUser";
            optUser.Size = new Size(65, 24);
            optUser.TabIndex = 0;
            optUser.TabStop = true;
            optUser.Text = "Users";
            optUser.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(163, 48);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.Size = new Size(634, 399);
            gData.TabIndex = 2;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmDataMaintenance";
            Text = "Data Maintenance";
            tblMain.ResumeLayout(false);
            pnlOptionButtons.ResumeLayout(false);
            pnlOptionButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private Panel pnlOptionButtons;
        private RadioButton optCourse;
        private RadioButton optMeasurement;
        private RadioButton optIngredient;
        private RadioButton optCuisine;
        private RadioButton optUser;
        private DataGridView gData;
    }
}