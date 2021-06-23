using AttributeRouting.Web.Http;
using IQISService.Models;
using IQISService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IQISService.Controllers
{
    public class LocationController : ApiController
    {
        private LocationRepository _locationRepository = new LocationRepository();

        [HttpGet]
        [GET("api/Locations")]
        public IEnumerable<LocationDto> GetAll()
        {
            return _locationRepository.GetAll();
        }

    }
}
