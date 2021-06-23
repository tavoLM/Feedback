using IQISService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Infrastructure
{
    public class AutomapperWebProfiler : AutoMapper.Profile
    {
        public static void Run(){

            AutoMapper.Mapper.Initialize(a =>{
                a.AddProfile<AutomapperWebProfiler>();
            });
        }


        public AutomapperWebProfiler()
        {
            CreateMap<user, UserModel>();
            CreateMap<UserModel, user>();
            CreateMap<defect, DefectModel>();
            CreateMap<DefectModel, defect>();
            CreateMap<part, PartModel>();
            CreateMap<PartModel, part>();
            CreateMap<model, ModelDto>();
            CreateMap<ModelDto, model>();
            CreateMap<area, AreaDto>();
            CreateMap<AreaDto, area>();
            CreateMap<location, LocationDto>();
            CreateMap<LocationDto, location>();
            CreateMap<ColorCode, ColorCodesDto>();
            CreateMap<ColorCodesDto, ColorCode>();
            CreateMap<FEEDBACK_DATA, FeedbackDto>();
            CreateMap<FeedbackDto, FEEDBACK_DATA>();
            CreateMap<ResponsibleDto, responsible>();
            CreateMap<responsible, ResponsibleDto>();
            CreateMap<countermeasure, CountermeasureDto>();
            CreateMap<CountermeasureDto, countermeasure>();
            CreateMap<ResponsibleGroup, ResponsibleGroupDto>();
            CreateMap<ResponsibleGroupDto, ResponsibleGroup>();
        }
    }
}