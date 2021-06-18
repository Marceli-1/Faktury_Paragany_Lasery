using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury_Paragany_Lasery.Models
{
    public class Company
    {
        public string name { get; set; }
        public int nip { get; set; }
        public string address { get; set; }

        public Company(string name, int nip, string address)
        {
            this.name = name;
            this.nip = nip;
            this.address = address;
        }

        public Company()
        {
        }
    }
}
