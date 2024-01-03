using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebOnline.Models.EF
{
    [Table("tb_ProductCategory")]
    public class ProductCategory: CommonAbstract
    {
        public ProductCategory()
        {
            this.Products = new HashSet<Product>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        public string Descriptione { get; set; }
        public string Icon { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescriptione { get; set; }
        public int SeoKeywords { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}