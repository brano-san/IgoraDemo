using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgoraDemo.Models
{
    internal class OrdersRow
    {
        public string Fio { get; set; }
        public int? rating { get; set; }
        public DateTime? Date { get; set; }
        public double? Sum { get; set; }
        public string status { get; set; }
    }
}
