using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TomasosASP.Models
{
    public partial class Kund
    {
        public Kund()
        {
            Bestallning = new HashSet<Bestallning>();
        }

        public int KundId { get; set; }

        [Required(ErrorMessage = "Namn saknas")]
        public string Namn { get; set; }

        [Required(ErrorMessage = "Gatuadress saknas")]
        public string Gatuadress { get; set; }

        [Required(ErrorMessage = "Postnr saknas")]
        public string Postnr { get; set; }

        [Required(ErrorMessage = "Postort saknas")]
        public string Postort { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }

        [Required(ErrorMessage = "Användarnamn saknas")]
        public string AnvandarNamn { get; set; }

        [Required(ErrorMessage = "Lösenord saknas")]
        public string Losenord { get; set; }

        public ICollection<Bestallning> Bestallning { get; set; }
    }
}
