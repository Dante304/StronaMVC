using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Proszę podać swoje imie i nazwisko")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę podać ades e-mail")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Proszę podać prawidłowy adres e-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Podaj numer telefonu")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Proszę określić czy weźmiesz udział")]
        public bool? WillAttend { get; set; }

    }
}
