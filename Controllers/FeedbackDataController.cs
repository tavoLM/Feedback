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

    public class FeedbackDataController : ApiController
    {
        private FeedbackDataRepository _feedbackDataRepository = new FeedbackDataRepository();


        [HttpPost]
        [POST("api/Feedback/")]
        public FeedbackDto Post(FeedbackDto feedback)
        {
            return _feedbackDataRepository.Post(feedback);
        }

    }
}
