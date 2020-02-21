using AutoMapper;
using EmployeeRegister.Domain.Models;
using EmployeeRegister.Infrastructure.Repository;
using EmployeeRegister.Service.Contracts;
using EmployeeRegister.Service.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeContext dbContext;
        private IMapper _mapper;

        public EmployeeService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task AddNewEmployee(ServiceModels.Employees request)
        {
            try
            {
                dbContext.Add(request);
                await dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task EditEmployee(ServiceModels.Employees request)
        {
            try
            {
                dbContext.Update(request);
                await dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<EmployeeResponse> GetEmployeeList()
        {
            return new EmployeeResponse()
            {
                EmployeeResponseDto = _mapper.Map<List<EmployeeListDto>>(dbContext.Employees.ToList())
            };
        }
    }
}
