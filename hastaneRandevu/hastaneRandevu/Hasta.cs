using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastaneRandevu
{
    class Hasta:insan
    {
        public int doktorId { get; set; }
        public int bolumId { get; set; }
        public int saatId { get; set; }
        public int randevuGunId { get; set; }
        private string _tcNo;
        public string TcNo {
            get { return _tcNo; }
            set {
                _tcNo = value.Substring(0, 2);
                for (int i = 2; i < value.Length - 3; i++)
                {
                    _tcNo += "*";
                }
                _tcNo += value.Substring(value.Length - 3, 3);
            } }
    }
}
