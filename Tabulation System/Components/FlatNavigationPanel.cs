using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Tabulation_System.Components.Classes.Helpers;

namespace Tabulation_System.Components
{
    public class FlatNavigationPanel : Panel
    {
        private Panel _pnlSelector;

        public FlatNavigationPanel()
        {
            InitializeControls();
            SetDefaultProperties();
        }

        [Category("Custom")]
        public Color SelectorBackColor
        {
            get { return _pnlSelector.BackColor; }
            set { _pnlSelector.BackColor = value; }
        }

        private void SetDefaultProperties()
        {
            Width = 250;
            Padding = new Padding(0, 0, 5, 0);
            BackColor = ColorHelper.NoColor;
            Dock = DockStyle.Left;
        }

        private void InitializeControls()
        {
            _pnlSelector = new Panel
            {
                Size = new Size(5, 0),
                Location = GetSelectorDefaultLocation(),
                BackColor = ColorHelper.FlatYellowNormal
            };

            Controls.Add(_pnlSelector);
        }

        private Point GetSelectorDefaultLocation()
        {
            return new Point(Width - 5, 0);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            _pnlSelector.Location = GetSelectorDefaultLocation();
            base.OnSizeChanged(e);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            if (e.Control is FlatButton)
            {
                e.Control.Dock = DockStyle.Top;

                e.Control.Click += (s, ev) =>
                {
                    _pnlSelector.Top = e.Control.Top;
                    _pnlSelector.Height = e.Control.Height;
                };
            }

            base.OnControlAdded(e);
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            if (Controls.Count == 1) _pnlSelector.Location = GetSelectorDefaultLocation();

            base.OnControlRemoved(e);
        }
    }
}