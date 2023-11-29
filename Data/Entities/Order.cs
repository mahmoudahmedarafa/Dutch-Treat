using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dutch_Treat.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        [MinLength(4)]
        public string OrderNumber { get; set; }
        public ICollection<OrderItem> Items { get; set; }
        public StoreUser User { get; set; }
    }
}
