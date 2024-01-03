using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebOnline.Models
{
    public abstract class CommonAbstract
    {
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModfiedDate { get; set; }
        public string Modfiedby { get; set; }

    }
}