using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Tabulation_System.Components.Classes.Helpers;
using Tabulation_System.Components.Interfaces;

namespace Tabulation_System.Components
{
    public class FlatTable : DataGridView, IEllipseOnDefault
    {
        private int _ellipseOnDefault;

        public FlatTable()
        {
            SetDefaultProperties();

            SetEllipseOnDefault();
        }

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

        private void SetDefaultProperties()
        {
            Font = FontHelper.BoldFont;
            BackgroundColor = ColorHelper.FlatWhiteLight;
            ForeColor = ColorHelper.FlatBlackNormal;
            Height = 250;
            Width = 500;
            BorderStyle = BorderStyle.None;
            Margin = new Padding(0, 0, 0, 0);

            EnableHeadersVisualStyles = false;

            //Cells
            CellBorderStyle = DataGridViewCellBorderStyle.None;
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GridColor = ColorHelper.FlatBlueNormal;

            //Columns
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            AllowUserToResizeColumns = false;
            ColumnHeadersHeight = 25;
            ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            ColumnHeadersDefaultCellStyle.BackColor = ColorHelper.FlatBlueNormal;
            ColumnHeadersDefaultCellStyle.ForeColor = ColorHelper.White;

            //Rows
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;
            DefaultCellStyle.Font = FontHelper.RegularFont;
            DefaultCellStyle.BackColor = ColorHelper.FlatWhiteDark;
            DefaultCellStyle.ForeColor = ColorHelper.FlatBlackNormal;
            DefaultCellStyle.SelectionBackColor = ColorHelper.FlatBlueLight;
            DefaultCellStyle.SelectionForeColor = ColorHelper.White;
            DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            RowsDefaultCellStyle.Font = FontHelper.RegularFont;
            RowsDefaultCellStyle.BackColor = ColorHelper.FlatWhiteDark;
            RowsDefaultCellStyle.ForeColor = ColorHelper.FlatBlackNormal;
            RowsDefaultCellStyle.SelectionBackColor = ColorHelper.FlatBlueLight;
            RowsDefaultCellStyle.SelectionForeColor = ColorHelper.White;
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AlternatingRowsDefaultCellStyle.Font = FontHelper.RegularFont;
            AlternatingRowsDefaultCellStyle.BackColor = ColorHelper.FlatWhiteNormal;
            AlternatingRowsDefaultCellStyle.ForeColor = ColorHelper.FlatBlackNormal;
            RowTemplate.Resizable = DataGridViewTriState.True;
            RowTemplate.MinimumHeight = 25;
            RowTemplate.Height = 25;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MultiSelect = false;
            ReadOnly = true;

            //Row Header
            RowHeadersWidth = 10;
            RowHeadersVisible = true;
            RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            RowHeadersDefaultCellStyle.Font = FontHelper.RegularFont;
            RowHeadersDefaultCellStyle.BackColor = ColorHelper.FlatBlackNormal;
            RowHeadersDefaultCellStyle.ForeColor = ColorHelper.White;
            RowHeadersDefaultCellStyle.SelectionBackColor = ColorHelper.FlatYellowNormal;
            RowHeadersDefaultCellStyle.SelectionForeColor = ColorHelper.White;
            RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            SetEllipseOnDefault();
        }
    }
}