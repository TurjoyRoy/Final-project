using DAL.EF.TableModels;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        public static IRepo<Application, int, bool> ApplicationData()
        {
            return new ApplicationRepo();
        }

        public static IRepo<Note, int, bool> NoteData()
        {
            return new NoteRepo();
        }
        public static IStatus<Application, int> StatusData()
        {
            return new ApplicationRepo();
        }
    }
}
