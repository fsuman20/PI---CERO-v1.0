using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI___CERO_v1._0.Models
{
    public class Employee : User
    {
        public string Username { get; set; }
        public string Lozinka { get; set; }

        public static explicit operator Employee(string v)
        {
            throw new NotImplementedException();
        }
    }
    
}
