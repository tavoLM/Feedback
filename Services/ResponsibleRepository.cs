using IQISService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Services
{
    
    public class ResponsibleRepository
    {
        private feedbackEntities db = new feedbackEntities();

        public List<ResponsibleDto> GetAll()
        {
            List<responsible> respList = db.responsibles.ToList();

            List<ResponsibleDto> respDtoList = new List<ResponsibleDto>();
            AutoMapper.Mapper.Map(respList, respDtoList);

            return respDtoList;
        }
    }
}