using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Data
{
    public class Product
    {
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public Product()
        {
            OrderDetails = new List<OrderDetail>();
        }

        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }

        [Key]
        public int ProductID { get; set; }

        [Required, StringLength(40)]
        public string ProductName { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        [StringLength(20)]
        public string QuantityPerUnit { get; set; }

        [Required]
        public Int16 UnitsInStock { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public Int16 UnitsOnOrder { get; set; }

        [Required]
        public Int16 ReorderLevel { get; set; }

        [Required]
        public bool Discontinued { get; set; }
    }
}