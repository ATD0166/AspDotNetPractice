using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Albert", Email = "albert@asato.com", Department = "HR" },
                new Employee { Id = 2, Name = "Jon", Email = "jon@asato.com", Department = "IT" },
                new Employee { Id = 3, Name = "Helen", Email = "henlen@asato.com", Department = "IT"}
            };
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
