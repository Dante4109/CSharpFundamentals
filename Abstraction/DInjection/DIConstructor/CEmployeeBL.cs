using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.Abstraction.DInjection.DIConstructor
{
    public class CEmployeeBL
    {
        public IEmployeeDAL employeeDAL;
        public CEmployeeBL(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.SelectAllEmployees();
        }

        public void PrintAllEmployees()
        {
            List<Employee> ListEmployee = GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }
        }
    }
}
