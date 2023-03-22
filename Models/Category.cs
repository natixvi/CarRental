using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "Id")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Proszę opis kategorii")]
        [Display(Name = "Opis Kategorii")]
        [MaxLength(50, ErrorMessage = "Max 50 char")]
        public string Name { get; set; }
        public virtual ICollection<Car> Cars{ get; set; }
    }
}