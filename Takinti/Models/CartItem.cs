using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Takinti.Models
{
    public class CartItem
    { public CartItem()
        {
            CreateDate = DateTime.Now;
            Quantity = 1;
        }
        public int Id { get; set; }
        public int CartId { get; set; }
        [ForeignKey("CartId")]
        public virtual Cart Cart { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public DateTime CreateDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get { return Product.Price; } }
        public decimal TotalPrice { get { return Product.Price * Quantity; } }
    }
}