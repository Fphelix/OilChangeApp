using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OilChangeApp.Models
{
    public class CarDetailing
    {
        //Fields & properties

       // [HiddenInput(DisplayValue = false)]
        public int Id{ get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "Last Service")]
        [UIHint("date")]
        public DateTime? LastService { get; set; }

        [Required(ErrorMessage = " Provider's name required")]
        public string ProvidersName { get; set; }


        [Required(ErrorMessage = " Company's name required")]
        public string CoompanyName { get; set; }

        [MaxLength(10, ErrorMessage = "10 Charachters")]
        [Required(ErrorMessage = " Contact Info required")]
        public string ContactInfo { get; set; }

       [HiddenInput(DisplayValue = false)]
        public string VehicleID { get; set; }

        // Constructors

        //Methods

    }

}
