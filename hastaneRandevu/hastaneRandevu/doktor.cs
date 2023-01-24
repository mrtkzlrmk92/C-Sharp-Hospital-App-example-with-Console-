using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastaneRandevu
{
    class doktor:insan
    {
        public string unvan { get; set; }
        public string asistan { get; set; }
        public int bolumId { get; set; }
        public int randevuGunu { get; set; }
        public string[] radevuSaati { get; set; }
       
    }
}
