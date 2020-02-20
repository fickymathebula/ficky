using EmployeeRegister.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeRegister.Service.ServiceModels
{
    public class EmployeeResponse
    {
        public Employees[] EmpResponse { get; set; }
    }
}
