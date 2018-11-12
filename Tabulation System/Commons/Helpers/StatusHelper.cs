using System.Collections.Generic;

namespace Tabulation_System.Commons.Helpers
{
    class StatusHelper
    {

        public static IEnumerable<Status> GetStatus()
        {
            var flag = new List<Status>()
            {
                new Status {IsActive = true, Text = "Active"},
                new Status {IsActive = false, Text = "Inactive"}
            };

            return flag;
        }

        public class Status
        {
            public bool IsActive { get; set; }
            public string Text { get; set; }
        }
    }
}
