using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB.Model
{
    public class TypeDevice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Device> Devices { get; set; } = new List<Device>();
    }
}
