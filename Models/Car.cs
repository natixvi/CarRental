using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Car
    {

        [Key]
        [Display(Name = "Id")]
        public int CarId { get; set; }

        [Required]
        [Display(Name = "Kategoria")]
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Display(Name = "Marka")]
        [MaxLength(50, ErrorMessage = "Max 50 char")]
        public string Brand { get; set; }

  
        [Display(Name = "Model")]
        [MaxLength(50, ErrorMessage = "Max 50 char")]
        public string Model { get; set; }

        
        [Display(Name = "Rok produkcji")]
        [Range(1,10000)]
        public int Production { get; set; }

        [Required(ErrorMessage = "Proszę podac numer rejestracyjny auta")]
        [Display(Name = "Numer Rejestracyjny")]
        [MaxLength(50, ErrorMessage = "Max 50 char")]
        public string LicensePlate { get; set; }

        [Required(ErrorMessage = "Proszę podac cene za dzień")]
        [Display(Name = "Cena za dzień")]
        [Range(1, 100000)]
        public int PriceForADay { get; set; }

        [Display(Name = "Kraj")]
        [MaxLength(50, ErrorMessage = "Max 50 char")]
        public string Country { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }

    }
}
