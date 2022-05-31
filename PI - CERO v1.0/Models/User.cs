using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI___CERO_v1._0.Models
{
    public abstract class User
    {
        public int OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

        public static explicit operator User(string v)
        {
            throw new NotImplementedException();
        }
    }
}
