﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Models
{
    public static class ModelBuilderExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Hance",
                    Email = "hance@asato.com",
                    Department = Dept.IT
                },
                new Employee
                {
                    Id = 2,
                    Name = "Chang",
                    Email = "chang@asato.com",
                    Department = Dept.HR
                }
            ); ;
        }
    }
}
