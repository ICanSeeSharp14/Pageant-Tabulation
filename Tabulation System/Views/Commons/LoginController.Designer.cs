using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabulation_System.Commons.Enums;
using Tabulation_System.Dialogs;
using Tabulation_System.Core.Models;
using Tabulation_System.Persistence.Repositories;
using System.Windows.Forms;

namespace Tabulation_System.Views.Commons
{
    public partial class LoginView
    {
        private void Login()
        {
            using (var repository = new UnitOfWork(new ApplicationDbContext()))
            {
                var exist = repository.Users.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (!exist)
                {
                    ShowErrorMessage();
                    return;
                }
                ShowMain(new User());
            }
        }
        private void ShowErrorMessage()
        {
            MessageAlert.Show("Invalid Credentials", "Error", alertType: AlertType.Error);

        }

        private void ShowMain(User account)
        {
            //AccountSession.SetAccount(account);
            var main = new MainView();
            main.FormClosed += (s, e) => { this.Show(); };
            main.Show();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter) Login();

            //if (keyData == (Keys.Alt | Keys.Q)) QrLogin();

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
