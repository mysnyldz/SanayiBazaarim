using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanayiBaazarim.Models.siniflar
{
    public class ürünler
    {
        public int Id { get; set; }
        public int categoryId { get; set; }
        public char productName { get; set; }
        public DateTime offerCreateTime { get; set; }
        public DateTime offerFinishedTime { get; set; }
        public char productImage { get; set; }
        public string productDescribtion  { get; set; }
        public string productSubDescription { get; set; }
    }
}