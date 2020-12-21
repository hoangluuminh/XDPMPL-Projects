using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop_Web.Models
{
    [Table("QuantityLog")]
    public class QuantityLog
    {
        public int Id { get; set; }
        
        public int ProductId { get; set; }
        
        public int Quantity { get; set; }

        [DisplayName("Ngày giờ")]
        public DateTime Date { get; set; }
        
        [DisplayName("Sản phẩm")]
        public virtual Product Product { get; set; }
    }
}