﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.Abstraction.DInjection
{
    // Employee Data Access Layer 
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>();
            //Get the Employees from the Database
            //for now we are hard coded the employees
            ListEmployees.Add(new Employee() { ID = 1, Name = "Pranaya", Department = "IT" });
            ListEmployees.Add(new Employee() { ID = 2, Name = "Kumar", Department = "HR" });
            ListEmployees.Add(new Employee() { ID = 3, Name = "Rout", Department = "Payroll" });
            return ListEmployees;
        }
    }
}
