﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class EmployeeRepository
    {
        //private readonly List<Employee> _employee = new List<Employee> ();
        private readonly List<Employee> _employee = new();
        public void Add(Employee employee)  => _employee.Add(employee);


    }
}