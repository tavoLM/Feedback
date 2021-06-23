using IQISService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IQISService.Services
{
    public class ResponsibleGroupRepository 
    {
        private feedbackEntities db = new feedbackEntities();


        public List<ResponsibleGroupDto> GetAll()
        {
            List<ResponsibleGroup> respList = db.ResponsibleGroups.ToList();

            List<ResponsibleGroupDto> respDtoList = new List<ResponsibleGroupDto>();
            AutoMapper.Mapper.Map(respList, respDtoList);

            return respDtoList;
        }
        

    }
}
