using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Tabulation_System.Components.Classes.Helpers;
using Tabulation_System.Components.Interfaces;

namespace Tabulation_System.Components
{
    public class FlatCheckBox : CheckBox, IColorOnCheck, IColorOnUncheck, IFontOnCheck, IFontOnUncheck, IEllipseOnCheck,
        IEllipseOnUncheck
    {
        #region Initalization

        private Color _backColorOnCheck;
        private Color _backColorOnUncheck;
        private Color _foreColorOnUncheck;
        private Color _foreColorOnCheck;
        private Font _fontOnUncheck;
        private Font _fontOnCheck;
        private int _ellipseOnCheck;
        private int _ellipseOnUncheck;

        public FlatCheckBox()
        {
            InitDefaultProperties();

            InitCustomProperties();
        }

        private void InitDefaultProperties()
        {
            Padding = new Padding(5, 0, 5, 0);
            Cursor = Cursors.Hand;
        }

        private void InitCustomProperties()
        {
            BackColorOnUncheck = ColorHelper.NoColor;
            BackColorOnCheck = ColorHelper.FlatBlueNormal;
            ForeColorOnUncheck = ColorHelper.FlatBlackNormal;
            ForeColorOnCheck = ColorHelper.FlatWhiteLight;
            FontOnUncheck = FontHelper.RegularFont;
            FontOnCheck = FontHelper.BoldFont;

            EllipseOnCheck = 0;
            EllipseOnUncheck = 0;
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);

            ApplyTransitions();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            ApplyTransitions();
        }


        private void ApplyTransitions()
        {
            if (Checked)
            {
                BackColor = BackColorOnCheck;
                ForeColor = ForeColorOnCheck;
                Font = FontOnCheck;

                SetEllipseOnCheck();
            }
            else
            {
                BackColor = BackColorOnUncheck;
                ForeColor = ForeColorOnUncheck;
                Font = FontOnUncheck;

                SetEllipseUncheck();
            }
        }

        #endregion

        #region Color Properties

        [Category("Custom")]
        public Color BackColorOnUncheck
        {
            get { return _backColorOnUncheck; }
            set
            {
                _backColorOnUncheck = value;

                ApplyTransitions();
            }
        }

        [Category("Custom")]
        public Color BackColorOnCheck
        {
            get { return _backColorOnCheck; }
            set
            {
                _backColorOnCheck = value;

                ApplyTransitions();
            }
        }

        [Category("Custom")]
        public Color ForeColorOnUncheck
        {
            get { return _foreColorOnUncheck; }
            set
            {
                _foreColorOnUncheck = value;

                ApplyTransitions();
            }
        }

        [Category("Custom")]
        public Color ForeColorOnCheck
        {
            get { return _foreColorOnCheck; }
            set
            {
                _foreColorOnCheck = value;

                ApplyTransitions();
            }
        }

        [Category("Custom")]
        public Font FontOnUncheck
        {
            get { return _fontOnUncheck; }
            set
            {
                _fontOnUncheck = value;

                ApplyTransitions();
            }
        }

        [Category("Custom")]
        public Font FontOnCheck
        {
            get { return _fontOnCheck; }
            set
            {
                _fontOnCheck = value;

                ApplyTransitions();
            }
        }

        #endregion

        #region Ellipse Properties

        [Category("Custom")]
        public int EllipseOnCheck
        {
            get { return _ellipseOnCheck; }
            set
            {
                _ellipseOnCheck = value;

                ApplyTransitions();
            }
        }

        public void SetEllipseOnCheck()
        {
            TransitionHelper.SetEllipse(this, EllipseOnCheck);
        }


        [Category("Custom")]
        public int EllipseOnUncheck
        {
            get { return _ellipseOnUncheck; }
            set
            {
                _ellipseOnUncheck = value;

                ApplyTransitions();
            }
        }

        public void SetEllipseUncheck()
        {
            TransitionHelper.SetEllipse(this, EllipseOnUncheck);
        }

        #endregion
    }
}