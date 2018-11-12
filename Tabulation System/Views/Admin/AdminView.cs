using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tabulation_System.Views.Admin.SubCategories;

namespace Tabulation_System.Views.Admin
{
    public partial class AdminView : UserControl
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void flatButton10_Click(object sender, EventArgs e)
        {
            pnlBodyContainer.Controls.Clear();
            var eventView = new CriteriaView();
            pnlBodyContainer.Controls.Add(eventView);

            eventView.Dock = DockStyle.Fill;

        }
    }
}
