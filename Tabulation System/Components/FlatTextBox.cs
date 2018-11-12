using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Tabulation_System.Components.Classes.Helpers;
using Tabulation_System.Components.Interfaces;

namespace Tabulation_System.Components
{
    public class FlatTextBox : TextBox, IColorOnEnter, IColorOnLeave, IFontOnEnter, IFontOnLeave
    {
        #region Properties
        

        [Category("Custom")]
        public string PlaceHolder
        {
            get { return _placeHolder; }
            set
            {
                _placeHolder = value;

                SendMessage(Handle, EmSetcuebanner, 0, value);
            }
        }


        //public bool ValidateOnSubmit { get; set; }

        [Category("Custom")]
        public bool Required
        {
            get
            {
                return _required;
            }
            set { _required = value; }
        }

        [Category("Custom")]
       


       
        public bool ValidateOnLeave { get; set; }
        #endregion

        #region Initialization

        private Color _backColorOnLeave;
        private Color _foreColorOnLeave;
        private Font _fontOnLeave;
        private string _placeHolder;
     
        private bool _required = false;
        [DllImport("user32")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam,
            [MarshalAs(UnmanagedType.LPWStr)] string lParam);


        private const int WmNcpaint = 0x85;
        private const int EmSetcuebanner = 0x1501;


        public FlatTextBox()
        {
         
            InitDefaultProperties();

            InitCustomProperties();
        }

        private void InitDefaultProperties()
        {
            Width = 200;
            Padding = new Padding(5, 0, 5, 0);
            Margin = new Padding(0, 0, 0, 0);
        }

        private void InitCustomProperties()
        {
            BorderColor = ColorHelper.FlatGreenDark;

            BackColorOnEnter = ColorHelper.FlatWhiteLight;
            ForeColorOnEnter = ColorHelper.FlatBlackNormal;
            FontOnEnter = FontHelper.BoldFont;

            BackColorOnLeave = ColorHelper.FlatWhiteLight;
            ForeColorOnLeave = ColorHelper.FlatBlackNormal;
            FontOnLeave = FontHelper.RegularFont;

            InputValidation = Validation.None;
            Required = true;
            BackColorOnRequired = ColorHelper.FlatRedLight;
            RequiredForeColorOnLeave = ColorHelper.FlatBlackNormal;
            BorderColorOnRequired = ColorHelper.FlatRedDark;
            SendMessage(Handle, EmSetcuebanner, 0, PlaceHolder);
            RequiredFontStyle = FontHelper.LightFont;
            RequiredForeColorOnValidate = ColorHelper.FlatWhiteNormal;
            ValidateOnLeave = false;
            //ValidateOnSubmit = false;



        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WmNcpaint && Focused)
            {
                var dc = GetWindowDC(Handle);
                using (var g = Graphics.FromHdc(dc))
                {
                    g.DrawRectangle(new Pen(BorderColor), 0, 0, Width - 1, Height - 1);
                }
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            SetPropertiesOnEnter();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
           
            SetPropertiesOnLeave();

            //if (Required && Text == "" && ValidateOnLeave)
            //{
            //    ValidateRequiredFields();
            //}
           
        }
        
        private void SetPropertiesOnEnter()
        {
            SetBackColorOnEnter();
            SetForeColorOnEnter();
            SetFontOnEnter();
            
        }

        private void SetPropertiesOnLeave()
        {
            SetBackColorOnLeave();
            SetForeColorOnLeave();
            SetFontOnLeave();

        }

        #endregion

        #region Color Properties

        [Category("Custom")] public Color BorderColor { get; set; }

        [Category("Custom")] public Color BackColorOnEnter { get; set; }
        [Category("Custom")] public Color BackColorOnError { get; set; }

        [Category("Custom")] public Color BackColorOnRequired { get; set; }
        [Category("Custom")] public Color RequiredForeColorOnLeave { get; set; }
        [Category("Custom")] public Color RequiredForeColorOnValidate { get; set; }
        [Category("Custom")] public Font RequiredFontStyle { get; set; }

        [Category("Custom")] public Color BorderColorOnRequired { get; set; }

        public void SetRequiredFontStyle()
        {
            Font = RequiredFontStyle;
        }
        public void SetRequiredForeColorOnValidate()
        {

            ForeColor = RequiredForeColorOnValidate;
        }

        public void SetBackColorOnEnter()
        {
            BackColor = BackColorOnEnter;
            
        }

        public void SetRequiredBackColor()
        {
            BackColor = BackColorOnRequired;
        }
        public void SetRequiredProperty()
        {
            
                BackColor = BackColorOnRequired;
                
                BorderColor = BorderColorOnRequired;
                ForeColor = RequiredForeColorOnLeave;
                SetRequiredFontStyle();
        }

      
        

        public void ValidateRequiredFields()
        {
            SetRequiredProperty();
            SetRequiredForeColorOnValidate();
        }

        [Category("Custom")] public Color ForeColorOnEnter { get; set; }

        public void SetForeColorOnEnter()
        {
            ForeColor = ForeColorOnEnter;
        }

        [Category("Custom")]
        public Color BackColorOnLeave
        {
            get { return _backColorOnLeave; }
            set
            {
                _backColorOnLeave = value;

                SetBackColorOnLeave();
            }
        }

        public void SetBackColorOnLeave()
        {
            BackColor = BackColorOnLeave;
            
        }

        [Category("Custom")]
        public Color ForeColorOnLeave
        {
            get { return _foreColorOnLeave; }
            set
            {
                _foreColorOnLeave = value;

                SetForeColorOnLeave();
            }
        }

        public void SetForeColorOnLeave()
        {
            ForeColor = ForeColorOnLeave;
        }

        #endregion

        #region Font Properties

        [Category("Custom")] public Font FontOnEnter { get; set; }

        public void SetFontOnEnter()
        {
            Font = FontOnEnter;
        }

        [Category("Custom")]
        public Font FontOnLeave
        {
            get { return _fontOnLeave; }
            set
            {
                _fontOnLeave = value;

                SetFontOnLeave();
            }
        }

        public void SetFontOnLeave()
        {
            Font = FontOnLeave;
        }

        #endregion

        #region Validation Properties

        public enum Validation : byte
        {
            None = 0,
            AlphaNumeric = 1,
            Alphabet = 2,
            Numeric = 3,
            AlphaNumericNoSpace = 4,
            AlphabetNoSpace = 5,
            NumericNoSpace = 6,
            Decimal = 7,
            Email = 8
        }

        [Category("Custom")] public Validation InputValidation { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            switch (InputValidation)
            {
                case Validation.None:
                    e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || IsBack(e.KeyChar) || IsSpace(e.KeyChar) ||
                                  !IsInjectionCharacter(e.KeyChar));
                    break;
                case Validation.AlphaNumeric:
                    e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || IsBack(e.KeyChar) || IsSpace(e.KeyChar));
                    break;
                case Validation.Alphabet:
                    e.Handled = !(char.IsLetter(e.KeyChar) || IsBack(e.KeyChar) || IsSpace(e.KeyChar));
                    break;
                case Validation.Numeric:
                    e.Handled = !(char.IsDigit(e.KeyChar) || IsBack(e.KeyChar) || IsSpace(e.KeyChar));
                    break;
                case Validation.AlphaNumericNoSpace:
                    e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || IsBack(e.KeyChar));
                    break;
                case Validation.AlphabetNoSpace:
                    e.Handled = !(char.IsLetter(e.KeyChar) || IsBack(e.KeyChar));
                    break;
                case Validation.NumericNoSpace:
                    e.Handled = !(char.IsDigit(e.KeyChar) || IsBack(e.KeyChar));
                    break;
                case Validation.Decimal:
                    e.Handled = IsBack(e.KeyChar)
                        ? e.Handled = false
                        : IsDecimal(e.KeyChar) && Text.Contains('.')
                            ? e.Handled = true
                            : e.Handled = !(char.IsDigit(e.KeyChar) || IsBack(e.KeyChar) || IsSpace(e.KeyChar) ||
                                            IsDecimal(e.KeyChar));
                    break;
                case Validation.Email:
                    e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || IsBack(e.KeyChar) || IsEmailCharacter(e.KeyChar));
                    break;
                default:
                    e.Handled = false;
                    break;
            }
        }

        private static bool IsBack(char key)
        {
            return key == (char) Keys.Back;
        }

        private static bool IsSpace(char key)
        {
            return key == (char) Keys.Space;
        }

        private static bool IsDecimal(char key)
        {
            return key == '.';
        }

        private static bool IsEmailCharacter(char key)
        {
            return "._@".Contains(key.ToString());
        }

        private static bool IsInjectionCharacter(char key)
        {
            return "\\\'\"\t\n%_;{}&".Contains(key.ToString());
        }

        #endregion
    }
}