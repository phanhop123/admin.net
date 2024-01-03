using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebOnline.Models.EF
{
    [Table("tb_Contact")]
    public class Contact : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage =" Ten khong duoc de trong")]
        [StringLength(150,ErrorMessage = "khong duoc viet qua 150")]
        public string Name { get; set; }
        [StringLength(150, ErrorMessage = "khong duoc viet qua 150")]
        public string Email { get; set; }
        public string Website { get; set; }
        [StringLength(4000)]
        public string Message { get; set; }
        public string IsRead { get; set; }
    }
}