using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Takinti.Models
{
    public class Category
    {  
        public Category()
        {
            ChildCategories = new HashSet<Category>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        [StringLength(200)]
        public string Slug { get; set; }
        [StringLength(200)]
        public string Icon { get; set; }
        [StringLength(200)]
        public string Photo { get; set; }
        public bool ShowInHome { get; set; }

        public int? ParentCategoryId { get; set; }
        [ForeignKey("ParentCategoryId")]
        public virtual Category ParentCategory { get; set; }
        public virtual ICollection<Category> ChildCategories { get; set; }
        public virtual ICollection<Product> Products {get;set;}

       
    }
}