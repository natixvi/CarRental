using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Customer
    {
        [Key]
        [Display(Name = "Id")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Proszę podac imie")]
        [Display(Name = "Imie")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Proszę podac nazwisko")]
        [Display(Name = "Nazwisko")]
        [MaxLength(50, ErrorMessage = "Max 50 char")]
        public string LastName { get; set; }


        [Display(Name = "Adres")]
        [MaxLength(255, ErrorMessage = "Max 255char")]
        public string Address { get; set; }

        [Display(Name = "Miasto")]
        [MaxLength(50, ErrorMessage = "Max 50 char")]
        public string City { get; set; }

        [Display(Name = "Kod pocztowy")]
        [MaxLength(15, ErrorMessage = "Max 15 char")]
        public string ZIPCode { get; set; }

        [Required(ErrorMessage = "Proszę podac numer dowody osobistego")]
        [Display(Name = "Numer dowodu osobistego")]
        [MaxLength(15, ErrorMessage = "Max 15 char")]
        public string IDNumber { get; set; }

        [Required(ErrorMessage = "Proszę podac numer telefonu")]
        [Display(Name = "Numer telefonu")]
        [MaxLength(15, ErrorMessage = "Max 15 char")]
        public string PhoneNumber { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }

    }
}
