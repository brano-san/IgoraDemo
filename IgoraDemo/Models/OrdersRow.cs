using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgoraDemo.Models
{
    internal class OrdersRow
    {
        public int? OrderNumber { get; set; }

        [DisplayName("ФИО")]
        public string Fio { get; set; }

        [DisplayName("Рейтинг")]
        public int? rating { get; set; }

        [DisplayName("Дата оформления")]
        public DateTime? Date { get; set; }

        [DisplayName("Сумма заказа")]
        public double? Sum { get; set; }

        [DisplayName("Статус")]
        public string status { get; set; }
    }
}
