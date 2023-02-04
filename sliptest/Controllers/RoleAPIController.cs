using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Repository.RoleRepository;

namespace sliptest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleAPIController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;

        public RoleAPIController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

       // [HttpGet]
       // [Route("GetAllRoles")]
        // [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PaginationEntityDto<RoleDto>))]
        //public async Task<IActionResult> GetAllRoles()
        //{
        //    var res = await _roleRepository.GetAllRoles();
        //    return Ok(res);

        //}
    }
}
