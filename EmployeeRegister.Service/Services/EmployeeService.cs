using EmployeeRegister.Domain.Models;
using EmployeeRegister.Infrastructure.Repository;
using EmployeeRegister.Service.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister.Service.Services
{
    public class EmployeeService
    {
        private readonly EmployeeContext dbContext;

        public Task AddNewEmployee(EmployeeRequest request)
        {
            throw new NotImplementedException();
        }

        public void EditEmployee()
        {
            Employees employee = new Employees();

            //try
            //{
            //    employee.EmployeeName = request.EmployeeName;
            //    employee.StaffNumber = request.StaffNumber;
            //    employee.EmployeeName = request.StaffNumber;

            //}
            //catch (Exception ex)
            //{

            //}

        }

        public Task EditEmployee(EmployeeRequest request)
        {
            throw new NotImplementedException();
        }

        public void EmployeeList()
        {

        }

        public Task<EmployeeResponse> GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeResponse> GetEmployeeList()
        {
            throw new NotImplementedException();
        }
    }
}
