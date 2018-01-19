using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Takinti.Models
{
    public class Product
    {
        public Product()
        {
            IsInStock = true;
            Quantity = 10;
            Rating = 5;
            RatingCount = 0;
            ViewCount = 0;

            IsPublished = true;
            Price = 0;
            OldPrice = 0;
            Tax = 0.18M;
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            Categories = new HashSet<Category>();
        }
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Slug { get; set; }
        [StringLength(200)]
        public string Photo { get; set; }
        [StringLength(4000)]
        public string Description { get; set; }
        public bool IsInStock { get; set; }
        public int Quantity { get; set; }
        public int SaleCount { get; set; } //buraya geri döneceğiz
        public string Details { get; set; }
        public string Features { get; set; }
        public string DataSheet { get; set; }
        public float Rating { get; set; }
        public int RatingCount { get; set; }
        public int ViewCount {get;set; }
        public bool IsPublished { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public decimal Tax { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual ICollection<Category> Categories { get; set; }


    }
}