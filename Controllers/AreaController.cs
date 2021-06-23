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
    public class AreaController : ApiController
    {

        private AreaRepository _areaRepository = new AreaRepository();
        [HttpGet]
        [GET("api/Areas/")]
        public IEnumerable<AreaDto> GetAll()
        {
            return _areaRepository.GetAll();
        }
    }
}
