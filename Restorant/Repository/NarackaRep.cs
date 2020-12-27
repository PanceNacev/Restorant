using Restorant.Models;
using Restorant.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restorant.Repository
{
    public class NarackaRep
    {
        RestorantDBEntities objrestorantDBEntities;
        public NarackaRep()
        {
            objrestorantDBEntities = new RestorantDBEntities();

        }
        public bool dodadiNaracka(NarackaView objNarackaView) {
            Naracka objNaracka = new Naracka();
            objNaracka.KlientId = objNarackaView.KlientId;
            objNaracka.VkupnoPotroseno = objNarackaView.Vkupno;
            objNaracka.DatumNaracka = DateTime.Now;
            objNaracka.BrojNaracka = String.Format("{0:ddmmmyyyyhhmmss}",DateTime.Now);
            objNaracka.TipNaNaplataId = objNarackaView.TipNaNarackaId;
            objrestorantDBEntities.Narackas.Add(objNaracka);
            objrestorantDBEntities.SaveChanges();
            int NarackaId = objNaracka.NarackaId;
            foreach (var i in objNarackaView.lista) 
            {
                DetaliNaracka objDetali = new DetaliNaracka();
                objDetali.NarackaId = NarackaId;
                objDetali.ArtiklId = i.ArtiklId;
                objDetali.Vkupno = i.Vkupno;
                objDetali.Cena = i.Cena;
                objDetali.Kolicina = i.Kolicina;
                objrestorantDBEntities.DetaliNarackas.Add(objDetali);
                objrestorantDBEntities.SaveChanges();

            }
            return true;
        }

    }
}