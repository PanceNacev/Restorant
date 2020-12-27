using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restorant.ViewModel
{
    public class DetaliNarackaView
    {
        public int DetaliNarackaId { get; set; }
        public int ArtiklId { get; set; }
        public decimal Cena { get; set; }
        public decimal Kolicina { get; set; }
        public decimal Vkupno{ get; set; }
    }
}