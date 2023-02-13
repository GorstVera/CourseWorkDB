using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB.Model
{
    public class Device
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public DateTime Date_release { get; set; }
        public DateTime? Date_sale { get; set; }
        public float Weight { get; set; }
        public TypeDevice TypeDevice { get; set; } = new TypeDevice();
        public Maker Maker { get; set; } = new Maker();
        public Country Country { get; set; } = new Country();
    }
}
