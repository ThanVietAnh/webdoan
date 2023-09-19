﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Websitebandoannhanh.Models.EF
{
    [Table("tb_Subcribe")]
    public class Subcribe
    {
        [key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
    }
}