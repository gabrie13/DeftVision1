using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Deft1.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public int PositionId { get; set; }

        public int Locationid { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime HireDate { get; set; }

        public virtual Position Position { get; set; }

        public virtual Location Location { get; set; }
    }
}