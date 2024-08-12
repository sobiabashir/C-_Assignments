namespace RecipeManager
{
    partial class FormIngredients
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
            this.lblNumberOfingredients = new System.Windows.Forms.Label();
            this.lblDisplayNumberOfingredients = new System.Windows.Forms.Label();
            this.grpBoxIngridients = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditIngridient = new System.Windows.Forms.Button();
            this.btnAddIngridient = new System.Windows.Forms.Button();
            this.lstOfIngridients = new System.Windows.Forms.ListBox();
            this.txtIngridient = new System.Windows.Forms.TextBox();
            this.btnOKIngridient = new System.Windows.Forms.Button();
            this.btnCancelIngridients = new System.Windows.Forms.Button();
            this.grpBoxIngridients.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumberOfingredients
            // 
            this.lblNumberOfingredients.AutoSize = true;
            this.lblNumberOfingredients.Location = new System.Drawing.Point(22, 23);
            this.lblNumberOfingredients.Name = "lblNumberOfingredients";
            this.lblNumberOfingredients.Size = new System.Drawing.Size(153, 20);
            this.lblNumberOfingredients.TabIndex = 0;
            this.lblNumberOfingredients.Text = "NumberOfIngredients";
            // 
            // lblDisplayNumberOfingredients
            // 
            this.lblDisplayNumberOfingredients.Location = new System.Drawing.Point(616, 26);
            this.lblDisplayNumberOfingredients.Name = "lblDisplayNumberOfingredients";
            this.lblDisplayNumberOfingredients.Size = new System.Drawing.Size(81, 26);
            this.lblDisplayNumberOfingredients.TabIndex = 1;
            // 
            // grpBoxIngridients
            // 
            this.grpBoxIngridients.Controls.Add(this.btnDelete);
            this.grpBoxIngridients.Controls.Add(this.btnEditIngridient);
            this.grpBoxIngridients.Controls.Add(this.btnAddIngridient);
            this.grpBoxIngridients.Controls.Add(this.lstOfIngridients);
            this.grpBoxIngridients.Controls.Add(this.txtIngridient);
            this.grpBoxIngridients.Location = new System.Drawing.Point(33, 58);
            this.grpBoxIngridients.Name = "grpBoxIngridients";
            this.grpBoxIngridients.Size = new System.Drawing.Size(670, 366);
            this.grpBoxIngridients.TabIndex = 2;
            this.grpBoxIngridients.TabStop = false;
            this.grpBoxIngridients.Text = "Ingridients";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(531, 115);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditIngridient
            // 
            this.btnEditIngridient.Location = new System.Drawing.Point(531, 71);
            this.btnEditIngridient.Name = "btnEditIngridient";
            this.btnEditIngridient.Size = new System.Drawing.Size(131, 28);
            this.btnEditIngridient.TabIndex = 3;
            this.btnEditIngridient.Text = "Edit";
            this.btnEditIngridient.UseVisualStyleBackColor = true;
            this.btnEditIngridient.Click += new System.EventHandler(this.btnEditIngridient_Click);
            // 
            // btnAddIngridient
            // 
            this.btnAddIngridient.Location = new System.Drawing.Point(531, 26);
            this.btnAddIngridient.Name = "btnAddIngridient";
            this.btnAddIngridient.Size = new System.Drawing.Size(131, 30);
            this.btnAddIngridient.TabIndex = 2;
            this.btnAddIngridient.Text = "Add";
            this.btnAddIngridient.UseVisualStyleBackColor = true;
            this.btnAddIngridient.Click += new System.EventHandler(this.btnAddIngridient_Click);
            // 
            // lstOfIngridients
            // 
            this.lstOfIngridients.FormattingEnabled = true;
            this.lstOfIngridients.ItemHeight = 20;
            this.lstOfIngridients.Location = new System.Drawing.Point(16, 74);
            this.lstOfIngridients.Name = "lstOfIngridients";
            this.lstOfIngridients.Size = new System.Drawing.Size(499, 264);
            this.lstOfIngridients.TabIndex = 1;
            // 
            // txtIngridient
            // 
            this.txtIngridient.Location = new System.Drawing.Point(14, 28);
            this.txtIngridient.Name = "txtIngridient";
            this.txtIngridient.Size = new System.Drawing.Size(501, 27);
            this.txtIngridient.TabIndex = 0;
            // 
            // btnOKIngridient
            // 
            this.btnOKIngridient.Location = new System.Drawing.Point(66, 434);
            this.btnOKIngridient.Name = "btnOKIngridient";
            this.btnOKIngridient.Size = new System.Drawing.Size(126, 31);
            this.btnOKIngridient.TabIndex = 3;
            this.btnOKIngridient.Text = "Ok";
            this.btnOKIngridient.UseVisualStyleBackColor = true;
            this.btnOKIngridient.Click += new System.EventHandler(this.btnOKIngridient_Click);
            // 
            // btnCancelIngridients
            // 
            this.btnCancelIngridients.Location = new System.Drawing.Point(230, 436);
            this.btnCancelIngridients.Name = "btnCancelIngridients";
            this.btnCancelIngridients.Size = new System.Drawing.Size(147, 29);
            this.btnCancelIngridients.TabIndex = 4;
            this.btnCancelIngridients.Text = "Cancel";
            this.btnCancelIngridients.UseVisualStyleBackColor = true;
            this.btnCancelIngridients.Click += new System.EventHandler(this.btnCancelIngridients_Click);
            // 
            // FormIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 492);
            this.Controls.Add(this.btnCancelIngridients);
            this.Controls.Add(this.btnOKIngridient);
            this.Controls.Add(this.grpBoxIngridients);
            this.Controls.Add(this.lblDisplayNumberOfingredients);
            this.Controls.Add(this.lblNumberOfingredients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormIngredients";
            this.grpBoxIngridients.ResumeLayout(false);
            this.grpBoxIngridients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumberOfingredients;
        private Label lblDisplayNumberOfingredients;
        private GroupBox grpBoxIngridients;
        private Button btnDelete;
        private Button btnEditIngridient;
        private Button btnAddIngridient;
        private ListBox lstOfIngridients;
        private TextBox txtIngridient;
        private Button btnOKIngridient;
        private Button btnCancelIngridients;
    }
}