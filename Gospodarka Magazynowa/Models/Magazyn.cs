using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gospodarka_Magazynowa.Models
{
    public class Magazyn
    {
        public int Id { get; set; }
        public string Nazwa{ get; set; }
        public string AdresMagazynu { get; set; }
        public long PrzestrzenCalkowita { get; set; }
        public long WolnaPrzestrzen { get; set; }
        public long ZajetaPrzestrzen { get; set; }
        [ForeignKey("Slownik")]
        public int StatusMagazynu { get; set; }
    }
}