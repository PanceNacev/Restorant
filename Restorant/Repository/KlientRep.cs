using Restorant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restorant.Repository
{
    public class KlientRep
    {
        RestorantDBEntities objrestorantDBEntities;
        public KlientRep()
        {
            objrestorantDBEntities = new RestorantDBEntities();

        }
        public IEnumerable<SelectListItem> siteKlienti()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objrestorantDBEntities.Klientis
                                  select new SelectListItem()
                                  {
                                      Text = obj.KlientIme,
                                      Value = obj.KlientId.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;
        }
    }
}