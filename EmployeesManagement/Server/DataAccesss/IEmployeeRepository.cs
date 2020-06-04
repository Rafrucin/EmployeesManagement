using EmployeesManagement.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeesManagement.Server.DataAccesss
{
    public interface IEmployeeRepository
    {
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int employeeId);
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> UpdateEmployee(Employee employee);
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
    }
}