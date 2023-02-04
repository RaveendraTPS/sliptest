using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Repository.DepartmentRepository;
using Repository.LocationRepository;
using Repository.RoleRepository;

namespace sliptest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentAPIController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentAPIController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }


        [HttpGet]
        [Route("GetDepartmentById")]

        public async Task<ActionResult<DepartmentDTO>> GetDepartmentById(int id)
        {
            var res = await _departmentRepository.GetDepartmentById(id);
            return Ok(res);
        }
        [HttpGet]
        [Route("GetAllDepartment")]
        public async  Task<List<DepartmentDTO>> GetAllDepartment()
        {
            var res = await _departmentRepository.GetAllDepartment();
            return res;
        }

        [HttpPost]
        [Route("AddDepartment")]
        [Route("AddDepartment")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AddDepartmentDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<AddDepartmentDTO>> AddDepartment(AddDepartmentDTO addDepartmentDTO)
        {
            if (ModelState.IsValid)
            {
                await _departmentRepository.AddDepartment(addDepartmentDTO);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("UpdateDepartment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateDepartment(DepartmentDTO departmentDTO)
        {
            if (ModelState.IsValid)
            {
                await _departmentRepository.UpdateDepartment(departmentDTO);
                return Ok(departmentDTO);
            }
            return BadRequest();
        }

        [HttpDelete("DeleteDepartment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            await _departmentRepository.DeleteDepartment(id);
            return Ok(id);
        }
    }
}

