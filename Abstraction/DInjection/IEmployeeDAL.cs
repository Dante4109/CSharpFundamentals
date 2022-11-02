using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.Abstraction.DInjection
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}
