using System;
using System.ComponentModel.DataAnnotations;

namespace Deft1.Models
{
    public class EmployeeViewModel
    {
        [Key]
        public int EmployeeId { get; set; }

        public int PositionId { get; set; }

        public int Locationid { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return String.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Display(Name = "Position")]
        public virtual Position Position { get; set; }

        [Display(Name = "Location")]
        public virtual Location Location { get; set; }
    }
}