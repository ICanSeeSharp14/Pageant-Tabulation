using System;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Tabulation_System.Commons.Helpers;
using Tabulation_System.Core.Models;
using Tabulation_System.Persistence.Repositories;

namespace Tabulation_System.Views.Admin.Judges
{
    public partial class JudgeView : UserControl
    {
       
        public JudgeView()
        {
            InitializeComponent();
            
            PopulateJudge();

         
        }

        private void PopulateJudge()
        {
            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                lvJudge.Items.Clear();
                var judges = unitOfWork.Judges.GetAll();
                
                foreach (var judge in judges)
                {
                    var item = new ListViewItem(judge.Id.ToString());
                    item.SubItems.Add(judge.FirstName);
                    item.SubItems.Add(judge.LastName);
                    item.SubItems.Add(judge.Username);
                    

                    lvJudge.Items.Add(item);

                }

                //lblRemaining.Text = (100.00 - totalPercentage).ToString("####");
                //lblTotalCriteria.Text = lvJudge.Items.Count.ToString();


                //lblTotalCriteria.Text = unitOfWork.Categories.GetTotalCategories(eventId).ToString();
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
            
            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                if (_isNew)
                {
                    var user = new User()
                    {
                        Username = txtUsername.Text.Trim(),
                        Password = txtPassword.Text.Trim(),
                        FirstName = txtFirstName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        
                    };

                    unitOfWork.Judges.Add(user);
                    unitOfWork.Commit();
                    MessageBox.Show("Successfully Saved");


                }
                else
                {
                   
                    var judge = unitOfWork.Judges.GetById(_id);
                    judge.Username = txtFirstName.Text.Trim();
                    judge.Username = txtUsername.Text.Trim();
                    judge.Password = txtPassword.Text.Trim();
                    judge.FirstName = txtFirstName.Text.Trim();
                    judge.LastName = txtLastName.Text.Trim();


                    unitOfWork.Commit();
                    _id = 0;
                    MessageBox.Show("Successfully Updated");
                    ClearText();
                    ClearErrors();
                }
               
            }
            _isNew = true;
            _id = 0;

            PopulateJudge();
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
  
                if (_isNew)
                {

                    if (unitOfWork.Judges.JudgeAlreadyExist(txtFirstName.Text, txtLastName.Text))
                    {
                        SetErrorMessage(txtFirstName, MessageHelper.DuplicateRecord(txtFirstName.Text.Trim()));
                        SetErrorMessage(txtLastName, MessageHelper.DuplicateRecord(txtLastName.Text.Trim()));
                        return false;
                    }
                }
                else
                {
                    
                    if (unitOfWork.Judges.JudgeAlreadyExist(txtFirstName.Text, txtLastName.Text, _id))
                    {
                        SetErrorMessage(txtFirstName, MessageHelper.DuplicateRecord(txtFirstName.Text.Trim()));
                        SetErrorMessage(txtLastName, MessageHelper.DuplicateRecord(txtLastName.Text.Trim()));
                        return false;
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
            epJudge.SetError(control, errorMessage);

            return false;
        }

        private void ClearErrors()
        {
            epJudge.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvJudge.Items.Count > 0)
            {
                if (MessageBox.Show("Do you want to Delete this category?", "Delete", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
                    {
                        var judgeId = lvJudge.SelectedItems[0].Text;
                        var selectedJudge = unitOfWork.Judges.GetById(int.Parse(judgeId));
                        unitOfWork.Judges.Remove(selectedJudge);
                        unitOfWork.Commit();
                        PopulateJudge();
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
            if (lvJudge.Items.Count > 0)
            {
                using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
                {
                    _id = int.Parse(lvJudge.SelectedItems[0].Text);
                    var judge = unitOfWork.Judges.GetById(_id);
                    txtFirstName.Text = judge.FirstName;
                    txtLastName.Text = judge.LastName;
                    txtUsername.Text = judge.Username;
                    txtPassword.Text = judge.Password;
                    btnDelete.Enabled = false;
                    _isNew = false;

                   
                }
            }
        }

        private bool _isNew = true;
        private int _id;

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PopulateEvent();
        }

        private void cmbCategory_TextChanged(object sender, EventArgs e)
        {
            //PopulateEvent();
        }
    }
}
