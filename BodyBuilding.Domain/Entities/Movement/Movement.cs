using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyBuilding.Domain.Entities.Movement
{
    public class Movement
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Set { get; set; }
        public int Count { get; set; }
    }
}
