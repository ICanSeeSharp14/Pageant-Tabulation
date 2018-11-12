using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabulation_System.Views.Customs
{
    public partial class ActionView
    {

        private void Initialize()
        {
            ShowSearchBar = true;
            ShowActionButtons = true;
        }

        public string GetSearchedValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public event EventHandler SearchButtonClicked
        {

            add { btnSearch.Click += value; }

            remove { btnSearch.Click -= value; }
        }
        public event System.Windows.Forms.KeyEventHandler FilterOnEnter
        {

            add { txtSearch.KeyDown += value; }

            remove { txtSearch.KeyDown -= value; }
        }



        public event EventHandler UnFilterOnClearText
        {

            add { txtSearch.TextChanged += value; }

            remove { txtSearch.TextChanged -= value; }
        }




        [Category("Custom")]
        public bool ShowSearchBar
        {
            get
            {
                if (pnlSearchBar.Visible)
                {
                    btnSearch.Visible = pnlSearchBar.Visible;

                    return true;
                }
                return false;
            }
            set
            {
                if (pnlSearchBar.Visible = value) return;
            }
        }


        private void ShowSearch(bool visibility)
        {
            pnlSearchBar.Visible = visibility;
            btnSearch.Visible = visibility;
        }


        [Category("Custom")]
        public bool ShowActionButtons
        {
            get
            {
                if (pnlCommandButton.Visible)
                {
                    return true;
                }

                return false;
            }
            set
            {
                if (pnlCommandButton.Visible = value) return;
            }
        }


        public event EventHandler AddButtonClicked
        {
            add
            {
                btnNew.Click += value;

            }
            remove
            {
                btnNew.Click -= value;

            }
        }

        public event EventHandler EditButtonClicked
        {
            add
            {

                btnEdit.Click += value;
            }
            remove
            {

                btnEdit.Click -= value;
            }
        }

        public event EventHandler DeleteButtonClicked
        {
            add
            {

                btnDelete.Click += value;
            }
            remove
            {

                btnDelete.Click -= value;
            }
        }

    }
}

