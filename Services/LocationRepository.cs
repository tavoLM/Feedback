using IQISService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Services
{


    public class LocationRepository
    {
        private feedbackEntities db = new feedbackEntities();

        public IEnumerable<LocationDto> GetAll()
        {
            IEnumerable<location> locationList = db.locations.ToList();
            IEnumerable<LocationDto> locDtoList = new List<LocationDto>();

            AutoMapper.Mapper.Map(locationList, locDtoList);

            return locDtoList;
        }
    }
}