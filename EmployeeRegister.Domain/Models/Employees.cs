using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeRegister.Domain.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [MaxLength(100)]
        public string EmployeeName { get; set; }

        [Required]
        [MaxLength(10)]
        public string StaffNumber { get; set; }

        [Required]
        [MaxLength(10)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
