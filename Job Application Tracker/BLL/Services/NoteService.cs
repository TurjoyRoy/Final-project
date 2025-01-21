using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NoteService
    {
        static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Note, NoteDTO>();
                cfg.CreateMap<NoteDTO, Note>();
            });
            return new Mapper(config);
        }

        public static bool Create(NoteDTO obj, int id)
        {
            var data = GetMapper().Map<Note>(obj);
            return DataAccess.NoteData().Create(data);
        }

        public static List<NoteDTO> Get()
        {
            var data = DataAccess.NoteData().Get();
            return GetMapper().Map<List<NoteDTO>>(data);

        }
        public static NoteDTO Get(int id)
        {
            var data = DataAccess.NoteData().Get(id);
            return GetMapper().Map<NoteDTO>(data);
        }

        public static bool Update(NoteDTO obj)
        {
            var data = GetMapper().Map<Note>(obj);
            return DataAccess.NoteData().Update(data);

        }

        public static bool Delete(int id)
        {
            return DataAccess.NoteData().Delete(id);

        }
    }
}
