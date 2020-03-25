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
                new Employee { Id = 1, Name = "Albert", Email = "albert@asato.com", Department = Dept.HR },
                new Employee { Id = 2, Name = "Jon", Email = "jon@asato.com", Department = Dept.IT },
                new Employee { Id = 3, Name = "Helen", Email = "henlen@asato.com", Department = Dept.Payroll}
            };
        }

        public Employee AddEmp(Employee emp)
        {
            emp.Id = _employeeList.Max(emp => emp.Id) + 1; //LINQ MAX
            _employeeList.Add(emp);
            return emp;
        }

        public Employee Delete(int Id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == Id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
