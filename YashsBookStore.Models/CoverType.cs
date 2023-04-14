using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YashsBookStore.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "CoverType Name")]
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Auther { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int CoverTypeId { get; set; }
        public double ListPrice { get; set; }
    }
}
