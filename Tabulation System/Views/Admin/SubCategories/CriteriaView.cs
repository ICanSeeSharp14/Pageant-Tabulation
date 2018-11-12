using System;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Tabulation_System.Commons.Helpers;
using Tabulation_System.Core.Models;
using Tabulation_System.Persistence.Repositories;

namespace Tabulation_System.Views.Admin.SubCategories
{
    public partial class CriteriaView : UserControl
    {
       
        public CriteriaView()
        {
            InitializeComponent();
            PopulateCategories();
            
            PopulateCriteria();

            cmbCategory.SelectedIndex = -1;
        }

        private void PopulateCriteria()
        {
            var totalPercentage = 0.00;
            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                lvCriteria.Items.Clear();
                var criterias = unitOfWork.Criterias.GetAll();
                
                foreach (var criteria in criterias)
                {
                    var item = new ListViewItem(criteria.Id.ToString());
                    item.SubItems.Add(criteria.CriteriaName);
                  
                    item.SubItems.Add(criteria.Percentage.ToString("##.###"));
                    totalPercentage = totalPercentage + criteria.Percentage;

                    lvCriteria.Items.Add(item);

                }

                lblRemaining.Text = (100.00 - totalPercentage).ToString("####");
                lblTotalCriteria.Text = lvCriteria.Items.Count.ToString();


                //lblTotalCriteria.Text = unitOfWork.Categories.GetTotalCategories(eventId).ToString();
                //lblRemaining.Text= (100.00 - unitOfWork.Categories.GetTotalPercentage(eventId)).ToString("##.###");

            }
        }
        private void PopulateCategories()
        {
            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                var categories = unitOfWork.Categories.GetAll();

                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "Id";


            }
            

        }

        private void materialListView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }


        private void btnSaveChanges_Click(object sender, System.EventArgs e)
        {
            if (!ValidateRequiredFields()) return;
            if (!ValidateDuplicateRecord()) return;
            //if (double.Parse(lblRemaining.Text) - double.Parse(txtPercentage.Text) < 0)
            //{
            //    MessageBox.Show("Remaining percentage must not negative");
            //    return;
            //}
            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                if (_isNew)
                {
                    var categoryId = int.Parse(cmbCategory.SelectedIndex.ToString());

                    //var selectedEvent = unitOfWork.Categories.GetById(eventId);
                    var newCriteria = new Criteria()
                    {
                        CriteriaName = txtCriteriaName.Text.Trim(),
                        Percentage = int.Parse(txtPercentage.Text.Trim()),
                        CategoryId = categoryId
                    };

                    unitOfWork.Criterias.Add(newCriteria);
                    unitOfWork.Commit();
                    MessageBox.Show("Successfully Saved");


                }
                else
                {
                    var categoryId = int.Parse(cmbCategory.SelectedIndex.ToString());

                    var criteria = unitOfWork.Criterias.GetById(_id);
                    criteria.CriteriaName = txtCriteriaName.Text.Trim();
                    criteria.CategoryId = categoryId;
                    
                    criteria.Percentage = int.Parse(txtPercentage.Text);

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
            PopulateCriteria();
            btnDelete.Enabled = true;


        }

        private void SaveCategory(ApplicationDbContext context)
        {

        }

        private bool ValidateDuplicateRecord()
        {
            var isValidated = true;

            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                var categoryId = int.Parse(cmbCategory.SelectedIndex.ToString());

                if (_isNew)
                {

                    if (unitOfWork.Criterias.CriteriaAlreadyExist(txtCriteriaName.Text, _id))
                    {
                        isValidated = SetErrorMessage(txtCriteriaName, MessageHelper.DuplicateRecord(txtCriteriaName.Text.Trim()));
                        return isValidated;
                    }
                }
                else
                {
                    
                    if (unitOfWork.Categories.CategoryAlreadyExist(txtCriteriaName.Text.Trim(), categoryId, _id))
                    {
                        isValidated = SetErrorMessage(txtCriteriaName, MessageHelper.DuplicateRecord(txtCriteriaName.Text.Trim()));
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
            if (lvCriteria.Items.Count > 0)
            {
                if (MessageBox.Show("Do you want to Delete this category?", "Delete", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
                    {
                        var criteriaId = lvCriteria.SelectedItems[0].Text;
                        var selectedCriteria = unitOfWork.Criterias.GetById(int.Parse(criteriaId));
                        unitOfWork.Criterias.Remove(selectedCriteria);
                        unitOfWork.Commit();
                        
                        PopulateCategories();
                        PopulateCriteria();
                        MessageBox.Show("Deleted");
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
            if (lvCriteria.Items.Count > 0)
            {
                using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
                {
                    _id = int.Parse(lvCriteria.SelectedItems[0].Text);
                    var selectedCriteria = unitOfWork.Criterias.GetById(_id);
                    txtCriteriaName.Text = selectedCriteria.CriteriaName;
                    txtPercentage.Text = selectedCriteria.Percentage.ToString("##.###");
                    btnDelete.Enabled = false;
                    _isNew = false;

                    PopulateCategories();
                }
            }
        }

        private bool _isNew = true;
        private int _id;

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PopulateCategories();
        }

        private void cmbCategory_TextChanged(object sender, EventArgs e)
        {
            //PopulateCategories();
        }
    }
}
