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
        [ForeignKey("Klient")]
        public int KlientId { get; set; }
        public DateTime DataOperacji { get; set; }
        [ForeignKey("ElementMagazynu")]
        public int ElementMagazynuId { get; set; }
        [ForeignKey("Slownik")]
        public int RodzajOperacjiId { get; set; }
        [ForeignKey("Slownik")]
        public int StatusOperacjiId { get; set; }


    }
}