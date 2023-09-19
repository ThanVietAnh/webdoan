using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Websitebandoannhanh.Models
{
    public abstract class CommonAbstract
    {
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifierDate { get; set; }
        public string Modifierby { get; set; }
    }
}