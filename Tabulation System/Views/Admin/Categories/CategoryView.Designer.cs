using Tabulation_System.Views.Admin.SubCategories;

namespace Tabulation_System.Views.Admin.Categories
{
    partial class CategoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryView));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCategoryName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPercentage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lvCategory = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSaveChanges = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalCategories = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.epCategory = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblRemainingPercentage = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.epCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(37, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Category";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Depth = 0;
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Hint = "";
            this.txtCategoryName.Location = new System.Drawing.Point(152, 65);
            this.txtCategoryName.MaxLength = 100;
            this.txtCategoryName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.PasswordChar = '\0';
            this.txtCategoryName.SelectedText = "";
            this.txtCategoryName.SelectionLength = 0;
            this.txtCategoryName.SelectionStart = 0;
            this.txtCategoryName.Size = new System.Drawing.Size(308, 23);
            this.txtCategoryName.TabIndex = 1;
            this.txtCategoryName.TabStop = false;
            this.txtCategoryName.UseSystemPasswordChar = false;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Depth = 0;
            this.txtPercentage.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentage.Hint = "";
            this.txtPercentage.Location = new System.Drawing.Point(152, 104);
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
            this.materialLabel3.Location = new System.Drawing.Point(37, 108);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(84, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Percentage";
            // 
            // lvCategory
            // 
            this.lvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2});
            this.lvCategory.Depth = 0;
            this.lvCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lvCategory.FullRowSelect = true;
            this.lvCategory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCategory.LabelEdit = true;
            this.lvCategory.LabelWrap = false;
            this.lvCategory.Location = new System.Drawing.Point(6, 213);
            this.lvCategory.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.OwnerDraw = true;
            this.lvCategory.Size = new System.Drawing.Size(880, 341);
            this.lvCategory.TabIndex = 5;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            this.lvCategory.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            this.lvCategory.DoubleClick += new System.EventHandler(this.lvCategory_DoubleClick);
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
            this.btnClear.Location = new System.Drawing.Point(398, 148);
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
            this.btnSaveChanges.Location = new System.Drawing.Point(320, 148);
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
            this.materialLabel2.Location = new System.Drawing.Point(37, 40);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(108, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Selected Event";
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
            // lblTotalCategories
            // 
            this.lblTotalCategories.AutoSize = true;
            this.lblTotalCategories.Depth = 0;
            this.lblTotalCategories.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalCategories.Location = new System.Drawing.Point(730, 40);
            this.lblTotalCategories.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalCategories.Name = "lblTotalCategories";
            this.lblTotalCategories.Size = new System.Drawing.Size(17, 19);
            this.lblTotalCategories.TabIndex = 11;
            this.lblTotalCategories.Text = "5";
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
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(711, 148);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(142, 36);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "DELETE CATEGORY";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbEvent
            // 
            this.cmbEvent.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(152, 31);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(308, 28);
            this.cmbEvent.TabIndex = 17;
            this.cmbEvent.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            this.cmbEvent.TextChanged += new System.EventHandler(this.cmbCategory_TextChanged);
            // 
            // epCategory
            // 
            this.epCategory.ContainerControl = this;
            this.epCategory.Icon = ((System.Drawing.Icon)(resources.GetObject("epCategory.Icon")));
            // 
            // lblRemainingPercentage
            // 
            this.lblRemainingPercentage.AutoSize = true;
            this.lblRemainingPercentage.Depth = 0;
            this.lblRemainingPercentage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRemainingPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRemainingPercentage.Location = new System.Drawing.Point(730, 76);
            this.lblRemainingPercentage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRemainingPercentage.Name = "lblRemainingPercentage";
            this.lblRemainingPercentage.Size = new System.Drawing.Size(17, 19);
            this.lblRemainingPercentage.TabIndex = 20;
            this.lblRemainingPercentage.Text = "5";
            // 
            // CategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRemainingPercentage);
            this.Controls.Add(this.cmbEvent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblTotalCategories);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.materialLabel1);
            this.Name = "CategoryView";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(892, 560);
            ((System.ComponentModel.ISupportInitialize)(this.epCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.FlatTable dgvEvent;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCategoryName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPercentage;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialListView lvCategory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialFlatButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveChanges;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblTotalCategories;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ErrorProvider epCategory;
        private MaterialSkin.Controls.MaterialLabel lblRemainingPercentage;
    }
}
