using EmployeeRegister.Service.Contracts;
using EmployeeRegister.Service.ServiceModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegister.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeesController: ControllerBase
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

        // Employee by unique employee Id
        [HttpGet]
        [Route("GetEmployeeById")]
        public async Task<EmployeeResponse> GetEmployeeById([FromBody] int EmployeeID)
        {
            return await employeeService.GetEmployeeById(EmployeeID);
        }

        // api/
        // Add new employee
        [HttpPost]
        [Route("AddEmployee")]
        public void AddEmployee([FromBody] EmployeeRequest request)
        {
            employeeService.AddNewEmployee(request);
        }

        // Update employee
        [HttpPut]
        [Route("UpdateEmployee")]
        public void UpdateEmployee([FromBody] EmployeeRequest request)
        {
            employeeService.EditEmployee(request);
        }
    }
}
