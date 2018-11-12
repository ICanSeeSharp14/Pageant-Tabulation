using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Tabulation_System.Components.Classes.Helpers;
using Tabulation_System.Components.Interfaces;

namespace Tabulation_System.Components
{
    public sealed class FlatGlowButton : Button, IBackColorOnDefault, IBackColorOnHover, IEllipseOnDefault,
        IEllipseOnHover, IEllipseOnClick
    {
        #region Initialization

        private Timer _timer;
        private int _alpha;
        private Color _backColorOnDefault;

        private ToolTip _toolTip;
        private int _ellipseOnDefault;

        public FlatGlowButton()
        {
            InitDefaultProperties();

            InitCustomProperties();

            InitEventProperties();
        }

        private void InitDefaultProperties()
        {
            Font = FontHelper.BoldFont;
            Size = new Size(150, 50);
            Margin = new Padding(0, 0, 0, 0);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
        }

        private void InitCustomProperties()
        {
            BackColorOnDefault = ColorHelper.FlatBlueNormal;
            BackColorOnHover = ColorHelper.FlatYellowNormal;

            _toolTip = new ToolTip();
            ToolTip = string.Empty;
        }

        private void InitEventProperties()
        {
            _timer = new Timer
            {
                Interval = 50
            };

            _timer.Tick += Timer_Tick;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            FlatAppearance.MouseOverBackColor = CalculateColor();

            _timer.Start();

            SetEllipseOnHover();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            _timer.Stop();
            _alpha = 0;

            FlatAppearance.MouseOverBackColor = CalculateColor();

            SetEllipseOnDefault();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            SetEllipseOnClick();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);

            SetEllipseOnHover();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            SetEllipseOnDefault();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_alpha + 25 < 255)
            {
                _alpha += 25;
            }
            else
            {
                _timer.Stop();
                _alpha = 255;
            }

            FlatAppearance.MouseOverBackColor = CalculateColor();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) _timer.Dispose();

            base.Dispose(disposing);
        }

        private Color CalculateColor()
        {
            return AlphaBlend(Color.FromArgb(_alpha, BackColorOnHover), BackColor);
        }

        public Color AlphaBlend(Color colorA, Color colorB)
        {
            var r = colorA.R * colorA.A / 255 + colorB.R * colorB.A * (255 - colorA.A) / (255 * 255);
            var g = colorA.G * colorA.A / 255 + colorB.G * colorB.A * (255 - colorA.A) / (255 * 255);
            var b = colorA.B * colorA.A / 255 + colorB.B * colorB.A * (255 - colorA.A) / (255 * 255);
            var a = colorA.A + colorB.A * (255 - colorA.A) / 255;
            return Color.FromArgb(a, r, g, b);
        }

        #endregion

        #region Properties

        [Category("Custom")]
        public int ColorTransition
        {
            get { return _timer.Interval; }
            set { _timer.Interval = value; }
        }

        [Category("Custom")]
        public string ToolTip
        {
            get { return _toolTip.GetToolTip(this); }
            set { _toolTip.SetToolTip(this, value); }
        }

        #endregion

        #region BackColor Properties

        [Category("Custom")]
        public Color BackColorOnDefault
        {
            get { return _backColorOnDefault; }
            set
            {
                _backColorOnDefault = value;

                SetBackColorOnDefault();
            }
        }

        public void SetBackColorOnDefault()
        {
            BackColor = BackColorOnDefault;
        }

        [Category("Custom")] public Color BackColorOnHover { get; set; }

        public void SetBackColorOnHover()
        {
            FlatAppearance.MouseOverBackColor = BackColorOnHover;
        }

        #endregion

        #region Ellipse Properties

        [Category("Custom")]
        public int EllipseOnDefault
        {
            get { return _ellipseOnDefault; }
            set
            {
                _ellipseOnDefault = value;

                SetEllipseOnDefault();
            }
        }

        public void SetEllipseOnDefault()
        {
            TransitionHelper.SetEllipse(this, EllipseOnDefault);
        }


        [Category("Custom")] public int EllipseOnHover { get; set; }

        public void SetEllipseOnHover()
        {
            TransitionHelper.SetEllipse(this, EllipseOnHover);
        }

        [Category("Custom")] public int EllipseOnClick { get; set; }

        public void SetEllipseOnClick()
        {
            TransitionHelper.SetEllipse(this, EllipseOnClick);
        }

        #endregion
    }
}