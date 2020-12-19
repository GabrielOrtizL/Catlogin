using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catlogin
{
    class Barcode
    {
        
        public int id { get; set; }
        public string label { get; set; }

        public Barcode() { }

        public Barcode(int id, string label)
        {
            this.id = id;
            this.label = label;
        }
    }
}
