using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using try_automapper.DTOS;
using try_automapper.Models;

namespace try_automapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        List<Employee> Employees = new() { new Employee() { ID = 1, address = "alex", Name = "omar reda" } };
        



        private readonly IMapper _mapper;

        public EmployeesController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // not use auto mapper

        [HttpPost("Employees/new")]
        public IActionResult addwithoutautomapper(EmployeeDTO employeeDTO)
        {
            Employee emp = new Employee()
            {
            Name = employeeDTO.Name,
            address = employeeDTO.address
            };
            Employees.Add(emp);
            return Ok(emp);

        }


        // use auto mapper
         [HttpPost]
        public  IActionResult addwithautomapper(EmployeeDTO employee)
        {
            var item = _mapper.Map<Employee>(employee);
            Employees.Add(item);
            return Ok(item);
        }
        

    }
}
