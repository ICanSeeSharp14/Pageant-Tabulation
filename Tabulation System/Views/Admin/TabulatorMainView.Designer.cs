namespace Tabulation_System.Views.Admin
{
    partial class TabulatorMainView
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
            this.tcMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tpsMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.tcMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tabPage1);
            this.tcMenu.Controls.Add(this.tabPage2);
            this.tcMenu.Controls.Add(this.tabPage3);
            this.tcMenu.Controls.Add(this.tabPage4);
            this.tcMenu.Controls.Add(this.tabPage5);
            this.tcMenu.Depth = 0;
            this.tcMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcMenu.Location = new System.Drawing.Point(0, 114);
            this.tcMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(900, 586);
            this.tcMenu.TabIndex = 0;
            this.tcMenu.SelectedIndexChanged += new System.EventHandler(this.tcMenu_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Category";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(892, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Criteria";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(892, 560);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Judges";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(892, 560);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Candidates";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tpsMenu
            // 
            this.tpsMenu.BaseTabControl = this.tcMenu;
            this.tpsMenu.Depth = 0;
            this.tpsMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tpsMenu.Location = new System.Drawing.Point(0, 76);
            this.tpsMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tpsMenu.Name = "tpsMenu";
            this.tpsMenu.Size = new System.Drawing.Size(900, 38);
            this.tpsMenu.TabIndex = 1;
            this.tpsMenu.Click += new System.EventHandler(this.tpsMenu_Click);
            // 
            // TabulatorMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.tpsMenu);
            this.Controls.Add(this.tcMenu);
            this.Name = "TabulatorMainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tcMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector tpsMenu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}