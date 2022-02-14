using assignmentcore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignmentcore.EmployeeData
{
     public interface IEmployeeData
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(Guid Id);
        Employee AddEmployee(Employee employee);
        

    }
}
