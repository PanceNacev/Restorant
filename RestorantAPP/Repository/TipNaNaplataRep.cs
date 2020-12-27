using Restorant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restorant.Repository
{
    public class TipNaNaplataRep
    {
        RestorantDBEntities objrestorantDBEntities;
        public TipNaNaplataRep()
        {
            objrestorantDBEntities = new RestorantDBEntities();
            
        }
        public IEnumerable<SelectListItem> siteTipNaNaplati() {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objrestorantDBEntities.TipNaNaplatas
                                  select new SelectListItem()
                                  {
                                      Text = obj.TipNaNaplataIme,
                                      Value = obj.TipNaNaplataId.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;
        }
    }
}