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
    public class ModelController : ApiController
    {

        private ModelRepository _modelRepository = new ModelRepository();
        [HttpGet]
        [GET("api/Models/")]
        public IEnumerable<ModelDto> GetAll()
        {
            return _modelRepository.GetAll();
        }
    }
}
