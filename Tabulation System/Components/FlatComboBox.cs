using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Tabulation_System.Components.Classes.Helpers;
using Tabulation_System.Components.Interfaces;

namespace Tabulation_System.Components
{
    public class FlatComboBox : ComboBox, IColorOnDefault, IColorOnHover, IColorOnClick
    {
        #region Initialization

        private Color _backColorOnDefault;
        private Color _foreColorOnDefault;

        public FlatComboBox()
        {
            InitDefaultProperties();
            InitCustomProperties();
        }

        private void InitDefaultProperties()
        {
            Font = FontHelper.BoldFont;
            Width = 200;
            FlatStyle = FlatStyle.Flat;
            DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InitCustomProperties()
        {
            BackColorOnDefault = ColorHelper.FlatBlueNormal;
            BackColorOnHover = ColorHelper.FlatBlueLight;
            BackColorOnClick = ColorHelper.FlatBlueDark;

            ForeColorOnDefault = ColorHelper.FlatWhiteLight;
            ForeColorOnHover = ColorHelper.FlatWhiteLight;
            ForeColorOnClick = ColorHelper.FlatWhiteLight;
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            SetBackColorOnHover();
            SetForeColorOnHover();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            SetBackColorOnDefault();
            SetForeColorOnDefault();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            SetBackColorOnClick();
            SetForeColorOnClick();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            SetBackColorOnHover();
            SetForeColorOnHover();
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
            BackColor = BackColorOnHover;
        }

        [Category("Custom")] public Color BackColorOnClick { get; set; }

        public void SetBackColorOnClick()
        {
            BackColor = BackColorOnClick;
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
    }
}