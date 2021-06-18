using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury_Paragany_Lasery.Models
{
    public class Products
    {
        public string name { get; set; }
        public float volume { get; set; }

        public Products(string name, float volume)
        {
            this.name = name;
            this.volume = volume;
        }

        public Products()
        {
        }
    }
}
