using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tabulation_System.Components;
using Tabulation_System.Views.Admin;

namespace Tabulation_System.Views.Commons
{
    public partial class MainView : FlatForm
    {
        public MainView()
        {
            InitializeComponent();
            var adminView = new AdminView();
            pnlBodyContainer.Controls.Add(adminView);
            adminView.Dock = DockStyle.Fill;
        }
    }
}
