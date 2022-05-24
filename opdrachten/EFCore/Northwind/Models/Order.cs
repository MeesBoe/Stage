using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Data
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
               
        [StringLength(5)]
        public string CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
       
        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
