using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI___CERO_v1._0.Models
{
    public class FinanceSource
    {
        public int Id { get; set; }
        public string FinanceName { get; set; }

        public override string ToString()
        {
            return FinanceName;
        }
    }
}
