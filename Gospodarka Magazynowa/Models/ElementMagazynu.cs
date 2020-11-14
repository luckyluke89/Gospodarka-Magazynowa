using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gospodarka_Magazynowa.Models
{
    [Table("ElementMagazynu")]
    public class ElementMagazynu
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("LokalizacjaWMagazynie")]
        public int LokalizacjaWMagazynieId{ get; set; }
        [ForeignKey("Slownik")]
        public int StatusElementuMagazynu { get; set; }
        public long Ilosc { get; set; }
        [ForeignKey("Slownik")]
        public int JednostkaMiary { get; set; }
        public long Waga { get; set; }
        public long Wysokosc { get; set; }
        public long Szerokosc { get; set; }
        public long Glembokosc { get; set; }
        [ForeignKey("Klient")]
        public int IdDostarczyciela { get; set; }
        [ForeignKey("Klient")]
        public int IdOdbiorcy { get; set; }
    }
}