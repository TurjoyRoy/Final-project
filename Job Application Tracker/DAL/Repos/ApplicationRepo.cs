using DAL.EF.TableModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ApplicationRepo : Repo, IRepo<Application, int, bool>, IStatus<Application, int>
    {
        public bool Create(Application obj)
        {
            db.Applications.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Applications.Remove(ex);
            return db.SaveChanges() > 0;
        }
        public List<Application> FilterApp(string statuses)
        {
            var applications = db.Applications
                          .Where(a => a.status.Equals(statuses))
                          .ToList();

            return applications;
        }

        public List<Application> Get()
        {
            return db.Applications.ToList();
        }

        public Application Get(int id)
        {
            return db.Applications.Find(id);
        }

        public Application StatusTrack(int id)
        {
            return Get(id);
        }

        public bool Update(Application obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
