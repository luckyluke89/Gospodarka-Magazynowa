using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gospodarka_Magazynowa.Models
{
    public class LokalizacjaWMagazynie
    {
        public int Id { get; set; }
        [ForeignKey("Magazyn")]
        public int MagazynId { get; set; }
        public Magazyn Magazyn { get; set; }
        public string Regal { get; set; }
        public string Miejsce { get; set; }
        public string Poziom { get; set; }
        [ForeignKey("Slownik")]
        public int StatusLokalizacjiId { get; set; }
        public Slownik StatusLokalizacji { get; set; }
        public string Etykieta { get; set; }

    }
}