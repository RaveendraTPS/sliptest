using Efcore;
using Microsoft.EntityFrameworkCore;
using Models.DTO;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DepartmentRepository
{
    public class DepartmentRepository : IDepartmentRepository
    {

        private readonly sliptestcontext _dbContext;

        public DepartmentRepository(sliptestcontext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<DepartmentDTO>> GetAllDepartment()
        {
            var res = await _dbContext.Departments.Where(x => x.IsActive == true).Select(x => new DepartmentDTO
            {
                PKDepartmentId = x.PKDepartmentId,
                Title = x.Title,
                Description = x.Description,
                IsActive= x.IsActive,
                JobCode = x.JobCode,
            }).ToListAsync();
            return res;
        }


        public async Task AddDepartment(AddDepartmentDTO addDepartmentDTO)
        {
            await _dbContext.Departments.AddAsync(new Department
            {
                Title = addDepartmentDTO.Title,
                Description = addDepartmentDTO.Description,
                JobCode = addDepartmentDTO.JobCode,
                IsActive=true
            });
            await _dbContext.SaveChangesAsync();
        }


        public async Task UpdateDepartment(DepartmentDTO departmentDTO)
        {
            var res = await _dbContext.Departments.FirstOrDefaultAsync(x => x.PKDepartmentId == departmentDTO.PKDepartmentId);
            if (res != null)
            {
                res.Title = departmentDTO.Title;
                res.Description = departmentDTO.Description;
                res.PKDepartmentId = departmentDTO.PKDepartmentId;
               res.IsActive= departmentDTO.IsActive;

                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new ApplicationException("Data_Not_Found");
            }

        }

        public async Task DeleteDepartment(int id)
        {
            var res =  _dbContext.Departments.FirstOrDefault(x => x.PKDepartmentId == id);
            if (res != null)
            {
                res.IsActive = false;

                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new ApplicationException("Data_Not_Found");
            }
        }

        public async Task<DepartmentDTO> GetDepartmentById(int id)
        {
            var res = await _dbContext.Departments.FirstOrDefaultAsync(x => x.PKDepartmentId == id);
            if (res != null)
            {
                return new DepartmentDTO()
                {
                    JobCode= res.JobCode,
                    Description= res.Description,
                    PKDepartmentId= res.PKDepartmentId,
                    Title= res.Title,
                    IsActive = res.IsActive,
                };
            }
            else
            {
                return null;
            }
        }
    }
}
