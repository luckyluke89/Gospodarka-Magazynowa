using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gospodarka_Magazynowa.Models
{
    public class Klient
    {
        public int Id { get; set; }
        public string Nazwa{ get; set; }
        [ForeignKey("Slownik")]
        public int RodzajKlienta { get; set; }

    }
}