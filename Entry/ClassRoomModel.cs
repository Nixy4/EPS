using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry
{
    public class ClassRoomModel
    {
        public string ClassRoomID { get; set; }
        public string ClassRoomName { get; set; }
        public int ClassRoomType { get; set; }
        public int MaxCapacity { get; set; }
        public string BuildingName { get; set; }
        public int Floor { get; set; }
    }
}
