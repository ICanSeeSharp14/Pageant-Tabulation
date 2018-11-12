using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tabulation_System.Commons.Enums;
using Tabulation_System.Components;
using Tabulation_System.Core.Models;
using Tabulation_System.Persistence.Repositories;
using Tabulation_System.Views.Admin;
using Tabulation_System.Views.Judge;

namespace Tabulation_System.Views.Commons
{
    public partial class LoginView : FlatForm
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Length == 0) return;
            if (txtPassword.Text.Trim().Length == 0) return;

            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                var exist = unitOfWork.Users.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (!exist)
                {
                    MessageBox.Show("Invalid credentials");
                    return;
                }

                var user = unitOfWork.Users.CheckLoginUser(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                if (user.UserType == UserType.Admin)
                     new TabulatorMainView().Show();

                new JudgeMainView().Show();

            }



        }

        private void ShowMain()
        {

        }
    }
}
