using Efcore;
using Microsoft.EntityFrameworkCore;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.LocationRepository
{
    public class LocationRepository : ILocationInterfcae
    {
        private readonly sliptestcontext _dbContext;

        public LocationRepository(sliptestcontext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<LocationDTO>> GetAllLocation()
        {
            var res = await _dbContext.Locations.Where(x => x.IsActive == true).Select(x => new LocationDTO
            {
                PkLocationID = x.PkLocationID,
                country = x.country,
                city = x.city,
                pincode = x.pincode,
                state = x.state,

            }).ToListAsync();
            return res;
        }


        public async Task Addlocation(AddLocationDTO addLocationDTO)
        {
            await _dbContext.Locations.AddAsync(new Models.Models.Location
            {
                country = addLocationDTO.country,
                city = addLocationDTO.city,
                pincode = addLocationDTO.pincode,
                state = addLocationDTO.state,

            });
            await _dbContext.SaveChangesAsync();
        }


        public async Task UpdateLocation(LocationDTO locationDTO)
        {
            var res = await _dbContext.Locations.FirstOrDefaultAsync(x => x.PkLocationID == locationDTO.PkLocationID);
            if (res != null)
            {
                res.country = locationDTO.country;
                res.city = locationDTO.city;
                res.pincode = locationDTO.pincode;
                res.city = locationDTO.state;
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new ApplicationException("Data_Not_Found");
            }

        }


        public async Task DeleteLocation(int id)
        {
            var res = _dbContext.Locations.FirstOrDefault(x => x.PkLocationID == id);
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


        public async Task<LocationDTO> GetLocationById(int id)
        {
            var res = await _dbContext.Locations.FirstOrDefaultAsync(x => x.PkLocationID == id);
            if (res != null)
            {
                return new LocationDTO()
                {
                    PkLocationID = res.PkLocationID,
                    city=res.city,
                    pincode=res.pincode,
                    state=res.state,
                    country=res.country,
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
