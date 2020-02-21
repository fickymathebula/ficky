using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeRegister.Service.Contracts;
using EmployeeRegister.Service.ServiceModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeRegister.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeesController : ControllerBase
    {        
        private IEmployeeService employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        // This calls the service to get list of employees
        [HttpGet]
        [Route("GetEmployees")]
        public async Task<EmployeeResponse> GetEmployees()
        {
            return await employeeService.GetEmployeeList();
        }

        // api/
        // Add new employee
        [HttpPost]
        [Route("AddEmployee")]
        public void AddEmployee([FromBody] Employees request)
        {
            employeeService.AddNewEmployee(request);
        }

        // Update employee
        [HttpPut]
        [Route("UpdateEmployee")]
        public void UpdateEmployee([FromBody] Employees request)
        {
            employeeService.EditEmployee(request);
        }
    }
}