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
using Tabulation_System.Components.Classes.Helpers;
using Tabulation_System.Components.Interfaces;

namespace Tabulation_System.Components
{
    public partial class FlatForm : Form , IEllipseOnDefault , IGradientOnDefault
    {
        
        #region Initialization

        private const int CGrip = 16;
        private const int CCaption = 32;
        private bool _mouseDown;
        private Point _lastLocation;
        private ColorCombination _colorToneOnDefault;
        private Color _colorAOnDefault;
        private Color _colorBOnDefault;
        private Color _colorCOnDefault;
        private int _gradientAngleOnDefault;
        private int _ellipseOnDefault;

        public FlatForm()
        {
            InitializeComponent();

            CustomProperties();

            EventProperties();
        }

        private void CustomProperties()
        {
            DragType = DragState.Both;

            ColorAOnDefault = ColorHelper.FlatWhiteLight;
            ColorBOnDefault = ColorHelper.FlatWhiteLight;
            ColorCOnDefault = ColorHelper.FlatWhiteLight;

            GradientAngleOnDefault = 45;
        }

        private void EventProperties()
        {
            AllMouseMove(lblTitle.Controls);
            AllMouseDown(lblTitle.Controls);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);

            SetGradientPaintOnDefault();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            SetEllipseOnDefault();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                var cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        #endregion

        #region Properties

        [Category("Custom")]
        public bool HasTitleBar
        {
            get { return lblTitle.Visible; }
            set { lblTitle.Visible = value; }
        }

        [Category("Custom")]
        public bool HasTitleBorder
        {
            get { return pnlTitleBorder.Visible; }
            set { pnlTitleBorder.Visible = value; }
        }

        [Category("Custom")]
        public bool HasMinimize
        {
            get { return btnMinimize.Visible; }
            set { btnMinimize.Visible = value; }
        }

        [Category("Custom")]
        public bool HasMaximize
        {
            get { return btnMaximize.Visible; }
            set { btnMaximize.Visible = value; }
        }

        [Category("Custom")]
        public bool HasClose
        {
            get { return btnClose.Visible; }
            set { btnClose.Visible = value; }
        }

        [Category("Custom")]
        public bool HasIcon
        {
            get { return pbIcon.Visible; }
            set { pbIcon.Visible = value; }
        }

        #endregion

        #region Resize Properties

        /*
                [Category("Custom")]
                public bool Resizable { get; set; }

                protected sealed override void WndProc(ref Message m)
                {
                    if (m.Msg == 0x84)
                    {
                        if (!Resizable) return;

                        var pos = new Point(m.LParam.ToInt32());

                        pos = this.PointToClient(pos);

                        if (pos.Y < CCaption)
                        {
                            m.Result = (IntPtr)2;
                            return;
                        }

                        if (pos.X >= this.ClientSize.Width - CGrip && pos.Y >= this.ClientSize.Height - CGrip)
                        {
                            m.Result = (IntPtr)17;
                            return;
                        }
                    }

                    base.WndProc(ref m);
                }
        */

        #endregion

        #region Drag Properties

        [Category("Custom")]
        public DragState DragType { get; set; }

        private void AllMouseMove(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (!(c is FlatButton))
                {
                    c.MouseMove += (s, e) =>
                    {
                        if (e.Button != MouseButtons.Left || !_mouseDown) return;

                        switch (DragType)
                        {
                            case DragState.Both:
                                ConfigureLocation(e.X, e.Y, _lastLocation.X, _lastLocation.Y);
                                break;
                            case DragState.Horizontal:
                                ConfigureLocation(e.X, 0, _lastLocation.X, 0);
                                break;
                            case DragState.Vertical:
                                ConfigureLocation(0, e.Y, 0, _lastLocation.Y);
                                break;
                        }
                    };
                }

                AllMouseMove(c.Controls);
            }
        }

        private void AllMouseDown(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (!(c is FlatGradientButton))
                {
                    c.MouseDown += (s, e) =>
                    {
                        if (e.Button != MouseButtons.Left) return;

                        _mouseDown = true;
                        _lastLocation = e.Location;
                    };
                }

                AllMouseDown(c.Controls);
            }
        }

        private void ConfigureLocation(int newLocX, int newLocY, int lastLocX, int lastLocY)
        {
            this.Location = new Point
            (
                (this.Location.X - lastLocX) + newLocX,
                (this.Location.Y - lastLocY) + newLocY
            );
        }

        #endregion

        #region GradientOnDefault Properties

        [Category("Custom")]
        public ColorCombination ColorToneOnDefault
        {
            get { return _colorToneOnDefault; }
            set
            {
                _colorToneOnDefault = value;

                SetGradientPaintOnDefault();
            }
        }

        [Category("Custom")]
        public Color ColorAOnDefault
        {
            get { return _colorAOnDefault; }
            set
            {
                _colorAOnDefault = value;

                SetGradientPaintOnDefault();
            }
        }

        [Category("Custom")]
        public Color ColorBOnDefault
        {
            get { return _colorBOnDefault; }
            set
            {
                _colorBOnDefault = value;

                SetGradientPaintOnDefault();
            }
        }

        [Category("Custom")]
        public Color ColorCOnDefault
        {
            get { return _colorCOnDefault; }
            set
            {
                _colorCOnDefault = value;

                SetGradientPaintOnDefault();
            }
        }

        [Category("Custom")]
        public int GradientAngleOnDefault
        {
            get { return _gradientAngleOnDefault; }
            set
            {
                _gradientAngleOnDefault = value;

                SetGradientPaintOnDefault();
            }
        }

        public void SetGradientPaintOnDefault()
        {
            var gradient = new Gradient<Form>(this,
                ColorAOnDefault,
                ColorBOnDefault,
                ColorCOnDefault,
                ColorToneOnDefault,
                GradientAngleOnDefault);

            TransitionHelper.GradientPaint(gradient);
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

        #region Action Properties



        private void MinimizeForm()
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private FormWindowState MaximizeForm()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnMaximize.Text = "1";
                return FormWindowState.Normal;
            }
            else
            {
                btnMaximize.Text = "2";
                return FormWindowState.Maximized;
            }
        }


        private void CloseForm()
        {
            this.Close();
        }


        #endregion

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            MinimizeForm();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            MaximizeForm();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseForm();

        }
    }
}
