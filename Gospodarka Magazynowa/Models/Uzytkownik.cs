using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gospodarka_Magazynowa.Models
{
    public class Uzytkownik
    {
        public int Id { get; set; }
        public string Nick { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Haslo { get; set; }
        [ForeignKey("Slownik")]
        public int PoziomUprawnienId { get; set; }
        public Slownik PoziomUprawnien { get; set; }
    }
}