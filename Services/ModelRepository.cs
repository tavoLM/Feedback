using IQISService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Services
{
    
    public class ModelRepository
    {
        private feedbackEntities db = new feedbackEntities();

        public IEnumerable<ModelDto> GetAll()
        {
            IEnumerable<model> modelList = db.models.ToList();
            IEnumerable<ModelDto> modelDtoList = new List<ModelDto>();

            AutoMapper.Mapper.Map(modelList, modelDtoList);

            return modelDtoList;
        }


    }
}