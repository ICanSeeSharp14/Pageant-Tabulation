using System;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Tabulation_System.Commons.Helpers;
using Tabulation_System.Core.Models;
using Tabulation_System.Persistence.Repositories;

namespace Tabulation_System.Views.Admin.Categories
{
    public partial class CategoryView : UserControl
    {
       
        public CategoryView()
        {
            InitializeComponent();
            PopulateCategories();

            PopulateEvents();

            cmbEvent.SelectedIndex = -1;
        }

        private void PopulateEvents()
        {
            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                var events = unitOfWork.Events.GetAll();

                cmbEvent.DataSource = events;
                cmbEvent.DisplayMember = "EventTitle";
                cmbEvent.ValueMember = "Id";


            }
        }
        private void PopulateCategories()
        {
            var totalPercentage = 0.00;
            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                lvCategory.Items.Clear();
                var categories = unitOfWork.Categories.GetAll();
                foreach (var category in categories)
                {
                    var item = new ListViewItem(category.Id.ToString());
                    item.SubItems.Add(category.CategoryName);
                    item.SubItems.Add(category.Description);
                    item.SubItems.Add(category.Percentage.ToString("##.###"));
                    totalPercentage = totalPercentage  + category.Percentage;
                
                    lvCategory.Items.Add(item);
                   
                }

                lblRemainingPercentage.Text = (100 - totalPercentage).ToString("####");
                lblTotalCategories.Text = lvCategory.Items.Count.ToString();
          
                
                //lblTotalCategories.Text = unitOfWork.Categories.GetTotalCategories(eventId).ToString();
                //lblRemaining.Text= (100.00 - unitOfWork.Categories.GetTotalPercentage(eventId)).ToString("##.###");

            }

        }

        private void materialListView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }


        private void btnSaveChanges_Click(object sender, System.EventArgs e)
        {
            if (!ValidateRequiredFields()) return;
            if (!ValidateDuplicateRecord()) return;
           // if (!ValidateRemainingPercentage()) return;

            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
               
                if (_id < 1)
                {

                    var eventId = int.Parse(cmbEvent.SelectedIndex.ToString());

                    var selectedEvent = unitOfWork.Categories.GetById(eventId);
                    var newCategory = new Category()
                    {
                        CategoryName = txtCategoryName.Text.Trim(),
                        Percentage = double.Parse(txtPercentage.Text.Trim()),
                       // Description = txtDescription.Text.Trim(),
                        EventId = eventId

                    };

                    unitOfWork.Categories.Add(newCategory);
                    unitOfWork.Commit();
                    MessageBox.Show("Successfully Saved");

                }
                else
                {
                    var eventId = int.Parse(cmbEvent.SelectedIndex.ToString());

                    var selectedCategory = unitOfWork.Categories.GetById(_id);
                    selectedCategory.CategoryName = txtCategoryName.Text.Trim();
                    //selectedCategory.Description = txtDescription.Text.Trim();
                    selectedCategory.EventId = eventId;
                    selectedCategory.Percentage = double.Parse(txtPercentage.Text);

                    unitOfWork.Commit();
                    _id = 0;
                    MessageBox.Show("Successfully Updated");
                    ClearText();
                    ClearErrors();
                }

            }
            _isNew = true;
            _id = 0;

            PopulateCategories();

            btnDelete.Enabled = true;


        }

        private void ValidateNumericValue()
        {

        }
        private bool ValidateRemainingPercentage()
        {
            if (double.Parse(lblRemainingPercentage.Text) - double.Parse(txtPercentage.Text) < 0)
            {
                MessageBox.Show("Remaining percentage must not negative");
                return false;
            }

            return true;
        }
        private void SaveCategory(ApplicationDbContext context)
        {

        }

        private bool ValidateDuplicateRecord()
        {
            var isValidated = true;

            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                var eventId = int.Parse(cmbEvent.SelectedIndex.ToString());

                if (_isNew)
                {

                    if (unitOfWork.Categories.CategoryAlreadyExist(txtCategoryName.Text.Trim(),eventId))
                    {
                        isValidated = SetErrorMessage(txtCategoryName, MessageHelper.DuplicateRecord(txtCategoryName.Text.Trim()));
                        return isValidated;
                    }
                }
                else
                {
                    
                    if (unitOfWork.Categories.CategoryAlreadyExist(txtCategoryName.Text.Trim(), eventId, _id))
                    {
                        isValidated = SetErrorMessage(txtCategoryName, MessageHelper.DuplicateRecord(txtCategoryName.Text.Trim()));
                        return isValidated;
                    }
                }
                
            }

            return isValidated;
        }

        private bool ValidateRequiredFields()
        {
            var isValidated = true;
            foreach (var control in Controls.Cast<Control>())
            {
                if (control is MaterialSingleLineTextField)
                {
                    var textBox = control as MaterialSingleLineTextField;
                    if (string.IsNullOrEmpty(textBox.Text.Trim()))
                    {
                        isValidated = SetErrorMessage(textBox, MessageHelper.NoInput());
                        textBox.Focus();
                        return isValidated;
                    }
                    ClearErrors();
                }

            }

            return isValidated;
        }

       
        private bool SetErrorMessage(Control control, string errorMessage)
        {
            epCategory.SetError(control, errorMessage);

            return false;
        }

        private void ClearErrors()
        {
            epCategory.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvCategory.Items.Count > 0)
            {
                if (MessageBox.Show("Do you want to Delete this category?", "Delete", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
                    {   
                        var categoryId = lvCategory.SelectedItems[0].Text;
                        var selectedCategory = unitOfWork.Categories.GetById(int.Parse(categoryId));
                        unitOfWork.Categories.Remove(selectedCategory);
                        unitOfWork.Commit();
                        MessageBox.Show("Deleted");
                        PopulateCategories();
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
            _isNew = true;
            _id = 0;
        }

        private void ClearText()
        {
            ControlHelper.ClearTextBox(this);
        }

        private void lvCategory_DoubleClick(object sender, EventArgs e)
        {
            if (lvCategory.Items.Count > 0)
            {
                using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
                {
                    _id = int.Parse(lvCategory.SelectedItems[0].Text);
                    var selectedCategory = unitOfWork.Categories.GetById(_id);
                    txtCategoryName.Text = selectedCategory.CategoryName;
                    //txtDescription.Text = selectedCategory.Description;
                    txtPercentage.Text = selectedCategory.Percentage.ToString("##.###");
                    btnDelete.Enabled = false;
                    _isNew = false;

                    PopulateCategories();
                }
            }
        }


        private bool _isNew = true;
        private int _id = 0;

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PopulateCategories();
        }

        private void cmbCategory_TextChanged(object sender, EventArgs e)
        {
            PopulateCategories();
        }
    }
}
