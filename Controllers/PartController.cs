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
    public class PartController : ApiController
    {
        private PartRepository _partRepository = new PartRepository();
        [HttpGet]
        [GET("api/Parts/")]
        public IEnumerable<PartModel> GetAll()
        {
            return _partRepository.GetAll();
        }
    }
}
