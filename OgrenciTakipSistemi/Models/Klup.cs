using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Models
{
    public class Klup
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public int Kontenjan { get; set; }

        public ICollection<Ogrenci> Ogrenci { get; set; }
    }
}
