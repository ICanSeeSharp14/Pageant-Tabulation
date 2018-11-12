using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Tabulation_System.Components;
using Tabulation_System.Components.Classes.Helpers;

namespace Tabulation_System.Commons.Helpers
{
    public class ControlHelper
    {
        public static int GetRowIndex(FlatTable dgv)
        {
            return dgv.CurrentRow?.Index ?? 0;
        }
        public static dynamic GetDataGridViewKey(FlatTable dgv, dynamic column)
        {
            if (dgv.Rows.Count < 1) return 1;
            return dgv.Rows[GetRowIndex(dgv)].Cells[column].Value.ToString();
        }

        private void SetButtonTabEvent(TableLayoutPanel tablePanel, TabControl tabControl)
        {
            var controls = tablePanel.Controls.Cast<Control>().ToList();

            foreach (var control in controls)
            {
                if (control is FlatButton)
                {
                    var button = control as FlatButton;
                    button.Click += (s, e) =>
                    {
                        SelectButtonTab(tablePanel, button);
                        GetSelectedTab(tabControl, button);

                    };
                }
            }
        }

        public static void ClearTextBox(Control container)
        {
            foreach (var control in container.Controls)
            {
                if (control is MaterialSingleLineTextField)
                {
                    var textBox = control as MaterialSingleLineTextField;
                    textBox.Text = String.Empty;
                  
                }
            }
        }
        public static void SelectButtonTab(TableLayoutPanel tablePanel, FlatButton button)
        {
            SelectedButtonTheme(button);
            DeselectTabButton(tablePanel,button);
        }


        static void SelectedButtonTheme(FlatButton button)
        {
            button.Margin = new Padding(1, 1, 1, 1);
            button.Dock = DockStyle.Fill;
            button.BackColorOnDefault = ColorHelper.FlatYellowNormal;
            button.BackColorOnHover = ColorHelper.FlatYellowNormal;
            button.BackColorOnClick = ColorHelper.FlatYellowNormal;
            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }

        static void DeselectTabButton(TableLayoutPanel tablePanel, FlatButton button)
        {
            foreach (var control in tablePanel.Controls.Cast<Control>())
            {
                var currentButton = control as FlatButton;

                if (control is FlatButton && !currentButton.Equals(button))
                {
                    DeselectButtonTheme(currentButton);
                }
            }
        }

        static void DeselectButtonTheme(FlatButton button)
        {
            button.Margin = new Padding(1, 1, 1, 1);
            button.Dock = DockStyle.Fill;
            button.BackColorOnDefault = Color.FromArgb(72, 72, 72);
            button.BackColorOnHover = Color.FromArgb(72, 72, 72);
            button.BackColorOnClick = Color.FromArgb(72, 72, 72);
            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }

        static void GetSelectedTab(TabControl tabControl, FlatButton button)
        {
            var selectedButton = button.Text;
            tabControl.SelectTab("tp" + selectedButton.Replace(" ", ""));
        }
    }
}
