using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gospodarka_Magazynowa.Models
{
    public class Operacja
    {
        public int Id { get; set; }
        [ForeignKey("Uzytkownik")]
        public int UzytkownikId { get; set; }
        public Uzytkownik Uzytkownik { get; set; }
        [ForeignKey("Klient")]
        public int KlientId { get; set; }
        public Klient Klient { get; set; }
        public DateTime DataOperacji { get; set; }
        [ForeignKey("ElementMagazynu")]
        public int ElementMagazynuId { get; set; }
        public ElementMagazynu ElementMagazynu { get; set; }
        [ForeignKey("Slownik")]
        public int RodzajOperacjiId { get; set; }
        public Slownik RodzajOperacji { get; set; }
        [ForeignKey("Slownik")]
        public int StatusOperacjiId { get; set; }
        public Slownik StatusOperacji { get; set; }

    }
}