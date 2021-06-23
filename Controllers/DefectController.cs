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
    public class DefectController : ApiController
    {
        private DefectRepository _defectRepository = new DefectRepository();

        
        public DefectController(){
            
        }

        [HttpGet]
        [GET("api/Defects/")]
        public IEnumerable<DefectModel> GetAll()
        {

            return _defectRepository.GetAll();

        }


    }//end class
}
