using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DepartmentRepository
{
    public interface IDepartmentRepository
    {
        Task<List<DepartmentDTO>> GetAllDepartment();
        Task AddDepartment(AddDepartmentDTO addDepartmentDTO);
        Task DeleteDepartment(int id);
        Task UpdateDepartment(DepartmentDTO departmentDTO);
        Task<DepartmentDTO> GetDepartmentById(int id);

    }
}
