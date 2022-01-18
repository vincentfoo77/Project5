using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.Shared.Domain
{
    public class Event_Details
    {
        public int Id { get; set; }
        public int EventsId { get; set; }
        public virtual Events Events { get; set; }
        public String Category { get; set; }
        public String Venue { get; set; }

    }
}
