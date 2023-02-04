using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.LocationRepository
{
    public interface ILocationInterfcae
    {
        Task<List<LocationDTO>> GetAllLocation();
        Task Addlocation(AddLocationDTO addLocationDTO);
        Task UpdateLocation(LocationDTO locationDTO);
        Task DeleteLocation(int id);
        Task<LocationDTO> GetLocationById(int id);

    }
}
