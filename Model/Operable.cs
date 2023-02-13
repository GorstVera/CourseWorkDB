using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB.Model
{
    public class Operable
    {
        public int Id { get; set; }
        public string Usable { get; set; }
        public ICollection<Device> Devices { get; set; } = new List<Device>();
    }
}
