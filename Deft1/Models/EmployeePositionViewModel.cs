using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Deft1.Models
{
    public class EmployeePositionViewModel
    {
        [Key]
        public int EmployeePositionId { get; set; }

        public int EmployeeId { get; set; }

        public int PositionId { get; set; }
    }
}