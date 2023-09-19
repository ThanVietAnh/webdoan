using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Websitebandoannhanh.Models.EF
{
    [Table("tb_ProductImage")]
    public class ProductImage
    {
        [key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Image { get; set; }
        public bool IsDefault { get; set; }
        public int ProductId { get; set; }
        public virtual Products Products { get; set; }
    }
}