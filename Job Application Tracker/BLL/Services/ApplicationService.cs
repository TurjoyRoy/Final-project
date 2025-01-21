using AutoMapper;
using DAL;
using BLL.DTOs;
using DAL.EF.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ApplicationService
    {
        static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Application, ApplicationDTO>();
                cfg.CreateMap<ApplicationDTO, Application>();
                cfg.CreateMap<AppStatus, AppStatusesDTO>();
                cfg.CreateMap<AppStatusesDTO, AppStatus>();
            });
            return new Mapper(config);
        }

        public static bool Create(ApplicationDTO obj)
        {
            var data = GetMapper().Map<Application>(obj);
            return DataAccess.ApplicationData().Create(data);
        }

        public static List<ApplicationDTO> Get()
        {
            var data = DataAccess.ApplicationData().Get();
            return GetMapper().Map<List<ApplicationDTO>>(data);

        }
        public static ApplicationDTO Get(int id)
        {
            var data = DataAccess.ApplicationData().Get(id);
            return GetMapper().Map<ApplicationDTO>(data);
        }
        public static List<ApplicationDTO> FilterApp(string statuses)
        {
            var data = DataAccess.StatusData().FilterApp(statuses);
            return GetMapper().Map<List<ApplicationDTO>>(data);
        }
        public static AppStatusesDTO StatusTrack(int id)
        {
            var data = DataAccess.StatusData().StatusTrack(id);
            return GetMapper().Map<AppStatusesDTO>(data);
        }

        public static bool Update(ApplicationDTO obj)
        {
            var data = GetMapper().Map<Application>(obj);
            return DataAccess.ApplicationData().Update(data);

        }
        public static bool Delete(int id)
        {
            return DataAccess.ApplicationData().Delete(id);

        }
    }
}
