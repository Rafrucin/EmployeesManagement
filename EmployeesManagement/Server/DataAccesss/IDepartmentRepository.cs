using EmployeesManagement.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeesManagement.Server.DataAccesss
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
    }
}