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
    public class ColorCodeController : ApiController
    {
        private ColorCodesRepository _colorCodesRepository = new ColorCodesRepository();

        [HttpGet]
        [GET("api/ColorCodes")]
        public IEnumerable<ColorCodesDto> GetAll()
        {
            return _colorCodesRepository.GetAll();
        }
    }
}
