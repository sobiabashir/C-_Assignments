namespace RecipeManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAddnewRecipe = new System.Windows.Forms.GroupBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.txtDescriptionRecipe = new System.Windows.Forms.TextBox();
            this.btnAddIngerdients = new System.Windows.Forms.Button();
            this.cmbCategeory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtNameOfRecipe = new System.Windows.Forms.TextBox();
            this.lblNameofRecipe = new System.Windows.Forms.Label();
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.btnEditbegin = new System.Windows.Forms.Button();
            this.btnEditFinish = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.labCategoryTitle = new System.Windows.Forms.Label();
            this.lblNumOFIngridTitle = new System.Windows.Forms.Label();
            this.grpAddnewRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddnewRecipe
            // 
            this.grpAddnewRecipe.Controls.Add(this.btnAddRecipe);
            this.grpAddnewRecipe.Controls.Add(this.txtDescriptionRecipe);
            this.grpAddnewRecipe.Controls.Add(this.btnAddIngerdients);
            this.grpAddnewRecipe.Controls.Add(this.cmbCategeory);
            this.grpAddnewRecipe.Controls.Add(this.lblCategory);
            this.grpAddnewRecipe.Controls.Add(this.txtNameOfRecipe);
            this.grpAddnewRecipe.Controls.Add(this.lblNameofRecipe);
            this.grpAddnewRecipe.Location = new System.Drawing.Point(12, 3);
            this.grpAddnewRecipe.Name = "grpAddnewRecipe";
            this.grpAddnewRecipe.Size = new System.Drawing.Size(434, 466);
            this.grpAddnewRecipe.TabIndex = 0;
            this.grpAddnewRecipe.TabStop = false;
            this.grpAddnewRecipe.Text = "Add new Recipe";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(18, 423);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(410, 31);
            this.btnAddRecipe.TabIndex = 6;
            this.btnAddRecipe.Text = "Add recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtDescriptionRecipe
            // 
            this.txtDescriptionRecipe.Location = new System.Drawing.Point(18, 106);
            this.txtDescriptionRecipe.Multiline = true;
            this.txtDescriptionRecipe.Name = "txtDescriptionRecipe";
            this.txtDescriptionRecipe.Size = new System.Drawing.Size(410, 311);
            this.txtDescriptionRecipe.TabIndex = 5;
            // 
            // btnAddIngerdients
            // 
            this.btnAddIngerdients.Location = new System.Drawing.Point(298, 63);
            this.btnAddIngerdients.Name = "btnAddIngerdients";
            this.btnAddIngerdients.Size = new System.Drawing.Size(130, 30);
            this.btnAddIngerdients.TabIndex = 4;
            this.btnAddIngerdients.Text = "Add Ingerdients";
            this.btnAddIngerdients.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddIngerdients.UseVisualStyleBackColor = true;
            this.btnAddIngerdients.Click += new System.EventHandler(this.btnAddIngerdients_Click);
            // 
            // cmbCategeory
            // 
            this.cmbCategeory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCategeory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategeory.FormattingEnabled = true;
            this.cmbCategeory.Location = new System.Drawing.Point(127, 64);
            this.cmbCategeory.Name = "cmbCategeory";
            this.cmbCategeory.Size = new System.Drawing.Size(165, 28);
            this.cmbCategeory.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(13, 64);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(0, 20);
            this.lblCategory.TabIndex = 2;
            // 
            // txtNameOfRecipe
            // 
            this.txtNameOfRecipe.Location = new System.Drawing.Point(127, 30);
            this.txtNameOfRecipe.Name = "txtNameOfRecipe";
            this.txtNameOfRecipe.Size = new System.Drawing.Size(301, 27);
            this.txtNameOfRecipe.TabIndex = 1;
            // 
            // lblNameofRecipe
            // 
            this.lblNameofRecipe.AutoSize = true;
            this.lblNameofRecipe.Location = new System.Drawing.Point(8, 30);
            this.lblNameofRecipe.Name = "lblNameofRecipe";
            this.lblNameofRecipe.Size = new System.Drawing.Size(112, 20);
            this.lblNameofRecipe.TabIndex = 0;
            this.lblNameofRecipe.Text = "Name of recipe";
            // 
            // lstRecipes
            // 
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.ItemHeight = 20;
            this.lstRecipes.Location = new System.Drawing.Point(460, 47);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(514, 344);
            this.lstRecipes.TabIndex = 1;
            this.lstRecipes.DoubleClick += new System.EventHandler(this.lstRecipes_DoubleClick);
            // 
            // btnEditbegin
            // 
            this.btnEditbegin.Location = new System.Drawing.Point(461, 406);
            this.btnEditbegin.Name = "btnEditbegin";
            this.btnEditbegin.Size = new System.Drawing.Size(103, 32);
            this.btnEditbegin.TabIndex = 2;
            this.btnEditbegin.Text = "Edit_Begin";
            this.btnEditbegin.UseVisualStyleBackColor = true;
            this.btnEditbegin.Click += new System.EventHandler(this.btnEditbegin_Click);
            // 
            // btnEditFinish
            // 
            this.btnEditFinish.Location = new System.Drawing.Point(577, 406);
            this.btnEditFinish.Name = "btnEditFinish";
            this.btnEditFinish.Size = new System.Drawing.Size(110, 32);
            this.btnEditFinish.TabIndex = 3;
            this.btnEditFinish.Text = "Edit_Finish";
            this.btnEditFinish.UseVisualStyleBackColor = true;
            this.btnEditFinish.Click += new System.EventHandler(this.btnEditFinish_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(706, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Location = new System.Drawing.Point(821, 406);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(154, 32);
            this.btnClearSelection.TabIndex = 5;
            this.btnClearSelection.Text = "Clear Selection";
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(465, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // labCategoryTitle
            // 
            this.labCategoryTitle.AutoSize = true;
            this.labCategoryTitle.Location = new System.Drawing.Point(656, 20);
            this.labCategoryTitle.Name = "labCategoryTitle";
            this.labCategoryTitle.Size = new System.Drawing.Size(69, 20);
            this.labCategoryTitle.TabIndex = 7;
            this.labCategoryTitle.Text = "Category";
            // 
            // lblNumOFIngridTitle
            // 
            this.lblNumOFIngridTitle.AutoSize = true;
            this.lblNumOFIngridTitle.Location = new System.Drawing.Point(867, 16);
            this.lblNumOFIngridTitle.Name = "lblNumOFIngridTitle";
            this.lblNumOFIngridTitle.Size = new System.Drawing.Size(78, 20);
            this.lblNumOFIngridTitle.TabIndex = 8;
            this.lblNumOFIngridTitle.Text = "No.Of Ingr";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 481);
            this.Controls.Add(this.lblNumOFIngridTitle);
            this.Controls.Add(this.labCategoryTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditFinish);
            this.Controls.Add(this.btnEditbegin);
            this.Controls.Add(this.lstRecipes);
            this.Controls.Add(this.grpAddnewRecipe);
            this.Name = "MainForm";
            this.Text = "Apu ";
            this.grpAddnewRecipe.ResumeLayout(false);
            this.grpAddnewRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpAddnewRecipe;
        private ComboBox cmbCategeory;
        private Label lblCategory;
        private TextBox txtNameOfRecipe;
        private Label lblNameofRecipe;
        private Button btnAddIngerdients;
        private Button btnAddRecipe;
        private TextBox txtDescriptionRecipe;
        private ListBox lstRecipes;
        private Button btnEditbegin;
        private Button btnEditFinish;
        private Button btnDelete;
        private Button btnClearSelection;
        private Label lblName;
        private Label labCategoryTitle;
        private Label lblNumOFIngridTitle;
        
       
    }
}