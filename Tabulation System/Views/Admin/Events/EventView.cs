using System;
using System.Windows.Forms;
using Tabulation_System.Core.Models;
using Tabulation_System.Persistence.Repositories;

namespace Tabulation_System.Views.Admin.Events
{
    public partial class EventView : UserControl
    {
        public EventView()
        {
            InitializeComponent();
            PopulateEvents();

    
        }

        private void PopulateEvents()
        {
            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
               lvEvents.Items.Clear();
                var events = unitOfWork.Events.GetAll();

                foreach (var row in events)
                {
                    var item = new ListViewItem(row.Id.ToString());
                    item.SubItems.Add(row.EventTitle);
                    item.SubItems.Add(row.Location);
                    item.SubItems.Add(row.EventDate.ToString());
                    lvEvents.Items.Add(item);
                }
                
            }
        }

        
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            
            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                var newEvent = new Event()
                {
                    EventTitle = txtTitle.Text.Trim(),
                    EventDate = DateTime.Now,
                    Location = txtLocation.Text.Trim()
                };

                unitOfWork.Events.Add(newEvent);
                unitOfWork.Commit();

                PopulateEvents();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvEvents.Items.Count > 0)
            {
                if (MessageBox.Show("Do you want to Delete this event?", "Delete", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
                    {
                        var eventId = lvEvents.SelectedItems[0].Text;
                        var selectedEvent = unitOfWork.Events.GetById(int.Parse(eventId));
                        unitOfWork.Events.Remove(selectedEvent);
                        unitOfWork.Commit();

                        PopulateEvents();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvEvents.Items.Count > 0)
            {
                using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
                {
                    var eventId = lvEvents.SelectedItems[0].Text;
                    var selectedEvent = unitOfWork.Events.GetById(int.Parse(eventId));

                    txtTitle.Text = selectedEvent.EventTitle;
                    txtLocation.Text = selectedEvent.Location;
                }

                
            }
            else
            {
                txtTitle.Clear();
                txtLocation.Clear();
            }
        }
    }
}
