using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gospodarka_Magazynowa.Models
{
    public class Slownik
    {
        public int Id { get; set; }
        public string NazwaSlownika { get; set; }
        public int ElementSlownika { get; set; }
        public string NazwaElementuSlownika { get; set; }
        public bool CzyZastrzeczowny { get; set; }
    }
}