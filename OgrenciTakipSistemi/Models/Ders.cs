using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Models
{
    public class Ders
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public ICollection<Not> Not { get; set; }
    }
}
