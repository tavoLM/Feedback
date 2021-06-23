using IQISService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Services
{
    public class PartRepository
    {
        private feedbackEntities db = new feedbackEntities();
        public IEnumerable<PartModel> GetAll()
        {
            IEnumerable<part> partList = db.parts.ToList();
            IEnumerable<PartModel> partModelList = new List<PartModel>();
            AutoMapper.Mapper.Map(partList, partModelList);

            return partModelList;
        }
    }
}