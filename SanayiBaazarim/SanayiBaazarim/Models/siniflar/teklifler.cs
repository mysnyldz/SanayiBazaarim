using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanayiBaazarim.Models.siniflar
{
    public class teklifler
    {
        public int Id { get; set; }
        public int productId { get; set; }
        public string offerHead {get; set;}
        public string offerValue { get; set; }
        public DateTime offerCreateTime { get; set; }
    }

}