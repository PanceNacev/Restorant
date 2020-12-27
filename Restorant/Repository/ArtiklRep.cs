using Restorant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restorant.Repository
{
    public class ArtiklRep
    {

        RestorantDBEntities objrestorantDBEntities;
        public ArtiklRep()
        {
            objrestorantDBEntities = new RestorantDBEntities();

        }
        public IEnumerable<SelectListItem> siteArtikli()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objrestorantDBEntities.Artikls
                                  select new SelectListItem()
                                  {
                                      Text = obj.ArtiklIme,
                                      Value = obj.ArtiklId.ToString(),
                                      Selected = false
                                  }).ToList();
            return objSelectListItems;
        }
    }
}