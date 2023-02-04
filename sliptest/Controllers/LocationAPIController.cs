using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Repository.DepartmentRepository;
using Repository.LocationRepository;

namespace sliptest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationAPIController : ControllerBase
    {

        private readonly ILocationInterfcae _locationInterfcae ;

        public LocationAPIController(ILocationInterfcae locationInterfcae )
        {
            _locationInterfcae = locationInterfcae;
        }


        [HttpPost]
        [Route("Addlocation")]

        public async Task<IActionResult> Addlocation(AddLocationDTO addLocationDTO )
        {
            if (ModelState.IsValid)
            {
                await _locationInterfcae.Addlocation(addLocationDTO);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("UpdateLocation")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateLocation(LocationDTO locationDTO )
        {
            if (ModelState.IsValid)
            {
                await _locationInterfcae.UpdateLocation(locationDTO);
                return Ok(locationDTO);
            }
            return BadRequest();
        }

        [HttpDelete("DeleteLocation")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            await _locationInterfcae.DeleteLocation(id);
            return Ok(id);
        }

        [HttpGet]
        [Route("GetAllLocation")]
        public async Task<IActionResult> GetAllLocation()
        {
            var res = await _locationInterfcae.GetAllLocation();
            return Ok(res);
        }

        [HttpGet]
        [Route("GetLocationById")]
      
        public async Task<ActionResult<DepartmentDTO>> GetLocationById(int id)
        {
            var res = await _locationInterfcae.GetLocationById(id);
            return Ok(res);
        }
    }
}
