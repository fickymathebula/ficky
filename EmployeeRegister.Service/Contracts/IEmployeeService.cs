using EmployeeRegister.Service.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister.Service.Contracts
{
    public interface IEmployeeService
    {
        Task<EmployeeResponse> GetEmployeeList();
        Task AddNewEmployee(Employees request);
        Task EditEmployee(Employees request); 
    }
}
