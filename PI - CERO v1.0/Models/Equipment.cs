using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI___CERO_v1._0.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string EquipmentName { get; set; }
        public string Description { get; set; }
        public int Project_finance { get; set; }
        public DateTime Arrival { get; set; }
        public string Project { get; set; }
        public string Reason { get; set; }
        public DateTime Expected { get; set; }
        public int App_User { get; set; }
        public int Employee { get; set; }

        public override string ToString()
        {
            return EquipmentName;
        }

    }
}
