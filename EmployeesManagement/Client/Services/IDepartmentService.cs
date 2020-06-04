using EmployeesManagement.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeesManagement.Client.Services
{
    public interface IDepartmentService
    {
        Task<Department> GetDepartment(int id);
        Task<IEnumerable<Department>> GetDepartments();
    }
}