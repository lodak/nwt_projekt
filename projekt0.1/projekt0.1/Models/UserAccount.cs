using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace projekt0._1.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage ="Ime je obavezno za unos!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Prezime je obavezno za unos!")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Korisničko ime je obavezno za unos!")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Lozinka je obavezna za unos!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Ponovljena lozinka je obavezna za unos!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Lozinka i ponovljena lozinka moraju biti jednake!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Adresa je obavezna za unos!")]
        public string Address { get; set; }

        [Required(ErrorMessage ="Grad je obavezan za unos!")]
        public string City { get; set; }

        
        public string State { get; set; }

        [Required(ErrorMessage ="Ime poduzeća je obavezno za unos!")]
        public string Company { get; set; }

        //[Required(ErrorMessage ="OIB poduzeća je obavezan za unos!")]
        //[RegularExpression(@"^\d{13}$")]
        public int CompanyOIB { get; set; }

        
        public string Title { get; set; }

        [Required(ErrorMessage ="Pozicija zapošljenja je obavezna za unos!")]
        public string Position { get; set; }

        [Required(ErrorMessage ="Telefon je obavezna za unos!")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Email je obavezna za unos!")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email { get; set; }

    }
}