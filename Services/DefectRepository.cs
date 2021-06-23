using IQISService.Models;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace IQISService.Services
{
    public class DefectRepository
    {
        private feedbackEntities db = new feedbackEntities();
        public IEnumerable<DefectModel> GetAll()
        {
            IEnumerable<defect> defectList = db.defects.ToList();

            IEnumerable<DefectModel> defectModelList = new List<DefectModel>();

            AutoMapper.Mapper.Map(defectList, defectModelList);

            return defectModelList;
        }
        
    } 
}