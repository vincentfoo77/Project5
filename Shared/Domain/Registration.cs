using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.Shared.Domain
{
    public class Registration
    {
        public String Id { get; set; }
        public int StudentsId { get; set; }
        public virtual Students Students { get; set; }
    }
}
