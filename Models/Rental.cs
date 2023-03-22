using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Rental
    {
        [Key]
        [Display(Name = "Id")]
        public int RentalId { get; set; }

        [Required]
        [ForeignKey("CarId")]
        [Display(Name = "Id auta")]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        [Required]
        [ForeignKey("CustomerId")]
        [Display(Name = "Id klienta")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data wypożyczenia")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RentStartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data zwrotu")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RentEndDate { get; set; }



    }
}
