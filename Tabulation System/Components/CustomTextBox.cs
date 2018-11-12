using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Tabulation_System.Components
{
    public class CustomTextBox : TextBox
    {
        
        private string _placeHolder;

        public CustomTextBox()
        {
            Text = PlaceHolder;
        }
        

        [Category("Custom")]
        public string PlaceHolder
        {
            get
            {
               return _placeHolder;
            }
            set { _placeHolder = value; }
        }

        protected  override  void OnEnter(EventArgs e)
        {
            Text = "";
        }

        protected override void OnLeave(EventArgs e)
        {
            PropertiesOnLeave();

        }

        private void PropertiesOnLeave()
        {
            if (Text == "")
            {
                Text = PlaceHolder;
            }
        }
    }
}
