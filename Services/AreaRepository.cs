using IQISService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Services
{
    
    public class AreaRepository
    {
        private feedbackEntities db = new feedbackEntities();


        public IEnumerable<AreaDto> GetAll()
        {
            IEnumerable<area> areaList = db.areas.ToList();

            IEnumerable<AreaDto> areaDtoList = new List<AreaDto>();

            AutoMapper.Mapper.Map(areaList, areaDtoList);

            return areaDtoList;
        }

    }
}