using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Models
{
    public class Not
    {
        public int Id { get; set; }
        
        public int Sınav1 { get; set; }
        public int Sınav2 { get; set; }
        public int Sınav3  { get; set; }
        public int Proje { get; set; }
        public double Ortalama { get; set; }
        public bool Durum { get; set; }

        public int DersId { get; set; }
        public int OgrenciId { get; set; }

        public Ders Ders { get; set; }
        public Ogrenci Ogrenci { get; set; }
    }
}
