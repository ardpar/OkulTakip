using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string Cinsiyet { get; set; }
        public int KlupId { get; set; }
        public Klup Klup { get; set; }
        public ICollection<Not> Not { get; set; }
    }
}
