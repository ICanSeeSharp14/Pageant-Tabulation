namespace Tabulation_System.Views.Admin.SubCategories
{
    partial class CriteriaView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Judges.JudgeView));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCriteriaName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPercentage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lvCriteria = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSaveChanges = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalCriteria = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblRemaining = new MaterialSkin.Controls.MaterialLabel();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.epCategory = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(37, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Category";
            // 
            // txtCriteriaName
            // 
            this.txtCriteriaName.Depth = 0;
            this.txtCriteriaName.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriteriaName.Hint = "";
            this.txtCriteriaName.Location = new System.Drawing.Point(184, 80);
            this.txtCriteriaName.MaxLength = 100;
            this.txtCriteriaName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCriteriaName.Name = "txtCriteriaName";
            this.txtCriteriaName.PasswordChar = '\0';
            this.txtCriteriaName.SelectedText = "";
            this.txtCriteriaName.SelectionLength = 0;
            this.txtCriteriaName.SelectionStart = 0;
            this.txtCriteriaName.Size = new System.Drawing.Size(308, 23);
            this.txtCriteriaName.TabIndex = 1;
            this.txtCriteriaName.TabStop = false;
            this.txtCriteriaName.UseSystemPasswordChar = false;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Depth = 0;
            this.txtPercentage.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentage.Hint = "";
            this.txtPercentage.Location = new System.Drawing.Point(184, 131);
            this.txtPercentage.MaxLength = 100;
            this.txtPercentage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.PasswordChar = '\0';
            this.txtPercentage.SelectedText = "";
            this.txtPercentage.SelectionLength = 0;
            this.txtPercentage.SelectionStart = 0;
            this.txtPercentage.Size = new System.Drawing.Size(308, 23);
            this.txtPercentage.TabIndex = 3;
            this.txtPercentage.TabStop = false;
            this.txtPercentage.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(37, 135);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(84, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Percentage";
            // 
            // lvCriteria
            // 
            this.lvCriteria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCriteria.CheckBoxes = true;
            this.lvCriteria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2});
            this.lvCriteria.Depth = 0;
            this.lvCriteria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lvCriteria.FullRowSelect = true;
            this.lvCriteria.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCriteria.LabelEdit = true;
            this.lvCriteria.LabelWrap = false;
            this.lvCriteria.Location = new System.Drawing.Point(6, 286);
            this.lvCriteria.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvCriteria.MouseState = MaterialSkin.MouseState.OUT;
            this.lvCriteria.Name = "lvCriteria";
            this.lvCriteria.OwnerDraw = true;
            this.lvCriteria.Size = new System.Drawing.Size(880, 268);
            this.lvCriteria.TabIndex = 5;
            this.lvCriteria.UseCompatibleStateImageBehavior = false;
            this.lvCriteria.View = System.Windows.Forms.View.Details;
            this.lvCriteria.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            this.lvCriteria.DoubleClick += new System.EventHandler(this.lvCategory_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No";
            this.columnHeader4.Width = 168;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category Name";
            this.columnHeader1.Width = 289;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Percentage";
            this.columnHeader2.Width = 364;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Depth = 0;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(430, 184);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = false;
            this.btnClear.Size = new System.Drawing.Size(62, 36);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.AutoSize = true;
            this.btnSaveChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveChanges.Depth = 0;
            this.btnSaveChanges.Icon = null;
            this.btnSaveChanges.Location = new System.Drawing.Point(352, 184);
            this.btnSaveChanges.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Primary = true;
            this.btnSaveChanges.Size = new System.Drawing.Size(71, 36);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "Submit";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(37, 44);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(131, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Selected Category";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(591, 40);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(133, 19);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Total Categories : ";
            // 
            // lblTotalCriteria
            // 
            this.lblTotalCriteria.AutoSize = true;
            this.lblTotalCriteria.Depth = 0;
            this.lblTotalCriteria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalCriteria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalCriteria.Location = new System.Drawing.Point(730, 40);
            this.lblTotalCriteria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalCriteria.Name = "lblTotalCriteria";
            this.lblTotalCriteria.Size = new System.Drawing.Size(17, 19);
            this.lblTotalCriteria.TabIndex = 11;
            this.lblTotalCriteria.Text = "5";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(591, 76);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(91, 19);
            this.materialLabel6.TabIndex = 14;
            this.materialLabel6.Text = "Remaining : ";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Depth = 0;
            this.lblRemaining.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRemaining.Location = new System.Drawing.Point(730, 76);
            this.lblRemaining.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(33, 19);
            this.lblRemaining.TabIndex = 13;
            this.lblRemaining.Text = "100";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(708, 184);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(142, 36);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "DELETE CATEGORY";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(184, 35);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(308, 28);
            this.cmbCategory.TabIndex = 17;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            this.cmbCategory.TextChanged += new System.EventHandler(this.cmbCategory_TextChanged);
            // 
            // epCategory
            // 
            this.epCategory.ContainerControl = this;
            // 
            // CriteriaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblTotalCriteria);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lvCriteria);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtCriteriaName);
            this.Controls.Add(this.materialLabel1);
            this.Name = "CriteriaView";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(892, 560);
            ((System.ComponentModel.ISupportInitialize)(this.epCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FlatTable dgvEvent;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCriteriaName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPercentage;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialListView lvCriteria;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialFlatButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveChanges;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblTotalCriteria;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lblRemaining;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ErrorProvider epCategory;
    }
}
