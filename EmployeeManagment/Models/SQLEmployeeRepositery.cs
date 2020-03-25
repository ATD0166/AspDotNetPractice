using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Models
{
    public class SQLEmployeeRepositery : IEmployeeRepository
    {
        private readonly AppDBContext context;

        public SQLEmployeeRepositery(AppDBContext context)
        {
            this.context = context;
        }

        public Employee AddEmp(Employee emp)
        {
            context.Employees.Add(emp);
            context.SaveChanges();
            return emp;
        }

        public Employee Delete(int id)
        {
            Employee emp = context.Employees.Find(id);
            if (emp != null)
            {
                context.Employees.Remove(emp);
                context.SaveChanges();
            }
            return emp;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employees;
        }

        public Employee GetEmployee(int id)
        {
            return context.Employees.Find(id);
        }

        public Employee Update(Employee employeeChanges)
        {
            var emp = context.Employees.Attach(employeeChanges);
            emp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return employeeChanges;
        }
    }
}
