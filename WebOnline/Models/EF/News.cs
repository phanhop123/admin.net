using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebOnline.Models.EF
{
    [Table("tb_News")]
    public class News : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "You cannot access the file")]
        [StringLength(150)]
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Descriptione { get; set; }
        [AllowHtml]
        public string Detail { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKeywords { get; set; }
        public bool IsActive { get; set; }
        public string SeoDescriptione { get; set; }
        public virtual Category Category { get; set; }

    }
}