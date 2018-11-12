using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tabulation_System.Commons.Enums;
using Tabulation_System.Components;
using Tabulation_System.Components.Classes.Helpers;

namespace Tabulation_System.Dialogs
{
    public partial class MessageAlert : Form
    {
        private readonly int _screenX = Screen.PrimaryScreen.Bounds.Width;
        private readonly int _screenY = Screen.PrimaryScreen.Bounds.Height;
        private int _interval;

        public const int WmNclbuttondown = 0xA1;
        private const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private MessageAlert(string message, string messageTitle, AlertType alertType)
        {
            Initialize(message);

            SetMessageAlert(alertType, messageTitle);
        }


        private void Initialize(string message)
        {
            InitializeComponent();
            TopMost = true;
            Left = _screenX - Width - 50;
            Top = -1 * _screenY;

            lblMessage.Text = message;

            AllMouseMove(Controls);
        }

        private void AllMouseMove(Control.ControlCollection coll)
        {
            foreach (Control c in coll)
            {
                if (!(c is FlatButton))
                {
                    c.MouseMove += (sender, e) =>
                    {
                        if (e.Button != MouseButtons.Left) return;

                        ReleaseCapture();

                        SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
                    };
                }

                AllMouseMove(c.Controls);
            }
        }

        private void SetMessageAlert(AlertType alertType, string messageTitle)
        {
            SetAlertType(alertType);

            SetMessageTitle(alertType, messageTitle);
            BeginShowing();
        }

        private void SetAlertType(AlertType alertType)
        {
            switch (alertType)
            {
                case AlertType.Info:
                    BackColor = ColorHelper.FlatBlueNormal;
                    pbIcon.Image = Properties.Resources.Info_48;
                    break;
                case AlertType.BadInfo:
                    BackColor = ColorHelper.FlatRedNormal;
                    pbIcon.Image = Properties.Resources.Info_48;
                    break;
                case AlertType.Update:
                    BackColor = ColorHelper.FlatGreenNormal;
                    pbIcon.Image = Properties.Resources.Update_48;
                    break;
                case AlertType.Delete:
                    BackColor = ColorHelper.FlatRedNormal;
                    pbIcon.Image = Properties.Resources.Delete_48;
                    break;
                case AlertType.Notification:
                    BackColor = ColorHelper.FlatGreenNormal;
                    pbIcon.Image = Properties.Resources.Notification_48;
                    break;
                case AlertType.Message:
                    BackColor = ColorHelper.FlatGreenNormal;
                    pbIcon.Image = Properties.Resources.Message_48;
                    break;
                case AlertType.Hand:
                    BackColor = ColorHelper.FlatYellowNormal;
                    pbIcon.Image = Properties.Resources.Hand_48;
                    break;
                case AlertType.Warning:
                    BackColor = ColorHelper.FlatYellowNormal;
                    pbIcon.Image = Properties.Resources.Warning_48;
                    break;
                case AlertType.Error:
                    BackColor = ColorHelper.FlatRedNormal;
                    pbIcon.Image = Properties.Resources.Error_48;
                    break;
            }
        }

        private void BeginShowing()
        {
            tmrShow.Enabled = true;
            tmrShow.Start();
        }

        private void SetMessageTitle(AlertType alertType, string messageTitle)
        {
            lblTitle.Text = string.IsNullOrEmpty(messageTitle) ? alertType.ToString() : messageTitle;
        }




        public static void Show(string message, string messageTitle = "Info", AlertType alertType = AlertType.Info)
        {

            new MessageAlert(message, messageTitle, alertType).Show();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            if (Top < 40)
            {
                Top = _interval;
                _interval += 1;
            }
            else
            {
                tmrShow.Stop();

                tmrDelay.Enabled = true;
                tmrDelay.Start();
            }
            lblMessage.Focus();

        }

        private void tmrDelay_Tick(object sender, EventArgs e)
        {

            tmrDelay.Stop();
            tmrClose.Enabled = true;
            tmrClose.Start();
        }

        private void tmrClose_Tick(object sender, EventArgs e)
        {
            if (Math.Abs(Opacity) > 0.00)
                Opacity -= 0.1;
            else
                Close();
        }

        private void MessageAlert_Load(object sender, EventArgs e)
        {
            lblMessage.Focus();

        }
    }


}
