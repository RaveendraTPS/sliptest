using Efcore;
using Microsoft.EntityFrameworkCore;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RoleRepository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly sliptestcontext _dbContext;

        public RoleRepository(sliptestcontext dbContext)
        {
            _dbContext = dbContext;
        }


        //public async Task<List<RoleDto>> GetAllRoles()
        //{
        //    var res  = await _dbContext.Roles.Select(x => new RoleDto
        //    {
        //        PKRoleId = x.PKRoleId,
        //        RoleName = x.RoleName,
        //    }).ToListAsync();
        //    return res;
        //}
    }
}
