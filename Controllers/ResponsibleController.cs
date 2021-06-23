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
    public class ResponsibleController : ApiController
    {
        private ResponsibleRepository _responsibleRepository;

        public ResponsibleController(){
            _responsibleRepository = new ResponsibleRepository();
        }

        [HttpGet]
        [GET("api/Responsibles/")]
        public List<ResponsibleDto> GetAll()
        {
            return _responsibleRepository.GetAll();
        }
    }
}
