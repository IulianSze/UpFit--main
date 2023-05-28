using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UpFit__main.Models
{
    public class AlimentsList
    {
        public IEnumerable<string> SelectedAliments { get; set; }
        public IEnumerable<SelectListItem> Aliments { get; set; }
    }
}