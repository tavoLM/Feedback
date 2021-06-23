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
    public class ResponsibleGroupController : ApiController
    {
         private ResponsibleGroupRepository _responsibleGroupRepository;
         public ResponsibleGroupController(){
            _responsibleGroupRepository = new ResponsibleGroupRepository();
        }

        [HttpGet]
        [GET("api/ResponsibleGroups/")]
        public List<ResponsibleGroupDto> GetAll()
        {
            return _responsibleGroupRepository.GetAll();
        }
    }
}
