using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Tabulation_System.Views.Admin.Categories;
using Tabulation_System.Views.Admin.Events;
using Tabulation_System.Views.Admin.Judges;
using Tabulation_System.Views.Admin.SubCategories;

namespace Tabulation_System.Views.Admin
{
    public partial class TabulatorMainView : MaterialForm
    {
        public TabulatorMainView()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            var eventView = new EventView();
            this.tabPage1.Controls.Add(eventView);
            eventView.Dock = DockStyle.Fill;

            var categoryView = new CategoryView();
            this.tabPage2.Controls.Add(categoryView);
            categoryView.Dock = DockStyle.Fill;

            var criteriaView = new CriteriaView();
            this.tabPage3.Controls.Add(criteriaView);
            criteriaView.Dock = DockStyle.Fill;

            var judgeView = new JudgeView();
            this.tabPage4.Controls.Add(judgeView);
            judgeView.Dock = DockStyle.Fill;


        }

        private void tpsMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void tcMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
