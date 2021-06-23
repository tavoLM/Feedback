using IQISService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Services
{
    public class ColorCodesRepository
    {
        private feedbackEntities db = new feedbackEntities();

        public IEnumerable<ColorCodesDto> GetAll()
        {
            IEnumerable<ColorCode> colorList = db.ColorCodes.ToList();
            IEnumerable<ColorCodesDto> colorDtoList = new List<ColorCodesDto>();

            AutoMapper.Mapper.Map(colorList, colorDtoList);

            return colorDtoList;
        }
    }
}