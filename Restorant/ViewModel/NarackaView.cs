using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restorant.ViewModel
{
    public class NarackaView
    {
        public int NarackaId { get; set; }
        public int TipNaNarackaId { get; set; }
        public int KlientId { get; set; }
        public string BrojNaracka { get; set; }
        public DateTime DatumNaracka { get; set; }
        public decimal Vkupno { get; set; }
        public IEnumerable<DetaliNarackaView> lista { get; set; }
    }
}