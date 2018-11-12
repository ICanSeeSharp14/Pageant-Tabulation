using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Tabulation_System.Components.Classes.Helpers;
using Tabulation_System.Components.Interfaces;

namespace Tabulation_System.Components
{
    public class FlatButton : Button, IColorOnDefault, IColorOnHover, IColorOnClick, IEllipseOnDefault, IEllipseOnHover,
        IEllipseOnClick
    {
        #region Properties

        [Category("Custom")]
        public string ToolTip
        {
            get { return _toolTip.GetToolTip(this); }
            set { _toolTip.SetToolTip(this, value); }
        }

        #endregion
    
        #region Initialize

        private Color _backColorOnDefault;
        private Color _backColorOnHover;
        private Color _backColorOnClick;
        private Color _foreColorOnDefault;
        private int _ellipseOnDefault;

        private ToolTip _toolTip;

        public FlatButton()
        {
            InitDefaultProperties();
            InitCustomProperties();
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

        private UserControl _module;

        private TabPage _tabPage;
        public void SetModule(UserControl module)
        {
            _module = module;
        }


        public void SetSelectedTab(TabPage tabPage)
        {
            _tabPage = tabPage;
        }
        public UserControl GetModule()
        {
            return _module;
        }

        public TabPage GetSelectedTab()
        {
            return _tabPage;
        }
        private void InitCustomProperties()
        {
            InitializeBackColor();
            InitializeForeColor();
            InitializeEllipse();

            _toolTip = new ToolTip();
            ToolTip = string.Empty;
        }

        private void InitializeBackColor()
        {
            BackColorOnDefault = ColorHelper.MediumTransparent;
            BackColorOnHover = ColorHelper.LightTransparent;
            BackColorOnClick = ColorHelper.DarkTransparent;
        }

        private void InitializeForeColor()
        {
            ForeColorOnDefault = ColorHelper.FlatBlackDark;
            ForeColorOnHover = ColorHelper.FlatBlackDark;
            ForeColorOnClick = ColorHelper.FlatBlackDark;
        }

        private void InitializeEllipse()
        {
            EllipseOnDefault = 0;
            EllipseOnHover = 0;
            EllipseOnClick = 0;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);

            SetEllipseOnClick();
            SetForeColorOnClick();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);

            SetEllipseOnHover();
            SetForeColorOnHover();
        }

        
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            SetEllipseOnDefault();
            SetForeColorOnDefault();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            SetEllipseOnHover();
            SetForeColorOnHover();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            SetEllipseOnDefault();
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

        [Category("Custom")]
        public Color BackColorOnHover
        {
            get { return _backColorOnHover; }
            set
            {
                _backColorOnHover = value;

                SetBackColorOnHover();
            }
        }

        public void SetBackColorOnHover()
        {
            FlatAppearance.MouseOverBackColor = BackColorOnHover;
        }

        [Category("Custom")]
        public Color BackColorOnClick
        {
            get { return _backColorOnClick; }
            set
            {
                _backColorOnClick = value;

                SetBackColorOnClick();
            }
        }

        public void SetBackColorOnClick()
        {
            FlatAppearance.MouseDownBackColor = BackColorOnClick;
        }

        #endregion

        #region ForeColor Properties

        [Category("Custom")]
        public Color ForeColorOnDefault
        {
            get { return _foreColorOnDefault; }
            set
            {
                _foreColorOnDefault = value;

                SetForeColorOnDefault();
            }
        }

        public void SetForeColorOnDefault()
        {
            ForeColor = ForeColorOnDefault;
        }

        [Category("Custom")] public Color ForeColorOnHover { get; set; }

        public void SetForeColorOnHover()
        {
            ForeColor = ForeColorOnHover;
        }

        [Category("Custom")] public Color ForeColorOnClick { get; set; }

        public void SetForeColorOnClick()
        {
            ForeColor = ForeColorOnClick;
        }

        #endregion

        #region EllipseOnDefault Properties

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

        #endregion

        #region EllipseOnHover Properties

        [Category("Custom")] public int EllipseOnHover { get; set; }

        public void SetEllipseOnHover()
        {
            TransitionHelper.SetEllipse(this, EllipseOnHover);
        }

        #endregion

        #region EllipseOnClick Properties

        [Category("Custom")] public int EllipseOnClick { get; set; }

        public void SetEllipseOnClick()
        {
            TransitionHelper.SetEllipse(this, EllipseOnClick);
        }

        #endregion
    }
}