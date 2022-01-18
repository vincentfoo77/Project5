using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.Shared.Domain
{
    public class Attendees
    {
        public int Id { get; set; }
        public int StudentsId { get; set; }
        public virtual Students Students { get; set; }
    }
}
