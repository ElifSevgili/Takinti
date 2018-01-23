using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Takinti.Models
{
    public class Post
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Slug { get; set; }
        [StringLength(200)]
        public string Photo { get; set; }
        [StringLength(4000)]
        public string Description { get; set; }
        public string Body { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}