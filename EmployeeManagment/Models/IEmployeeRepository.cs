﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Models
{
    public interface IEmployeeRepository
    {
        public Employee GetEmployee(int id);
        public IEnumerable<Employee> GetAllEmployees();
        public Employee AddEmp(Employee emp);
        Employee Update(Employee employeeChanges);
        Employee Delete(int Id);
    }
}
