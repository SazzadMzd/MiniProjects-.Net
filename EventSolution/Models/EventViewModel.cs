using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSolution.Models
{
    public class EventViewModel
    {
        // Every event should have name, description, date, address, assigned user, any other fields you feel necessary
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string AssignedUser { get; set; }
        public int Capacity { get; set; }

    }
}
