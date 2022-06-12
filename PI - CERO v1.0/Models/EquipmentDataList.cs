using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI___CERO_v1._0.Models
{
    public class EquipmentDataList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Project { get; set; }
        public string Finance { get; set; }
        public string CIPEmployee { get; set; }
        public string AppUser{ get; set; }
        public DateTime Arrival { get; set; }
    }
}
