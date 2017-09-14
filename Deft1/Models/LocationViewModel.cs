using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Deft1.Models
{
    public class LocationViewModel
    {
        [Key]
        public int LocationId { get; set; }

        [Display(Name = "Location")]
        public string LocationName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "Days of Operation")]
        public string OperationDay { get; set; }

        [Display(Name = "Hours of Operation")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:t}")]
        public DateTime OperationHours { get; set; }
    }
}