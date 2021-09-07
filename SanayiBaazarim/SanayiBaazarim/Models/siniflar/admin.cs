using System.ComponentModel.DataAnnotations;

namespace SanayiBaazarim.Models.siniflar
{
    public class admin
    {
        [Key]
        public int id { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
    }

}