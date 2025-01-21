using DAL.EF.TableModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class NoteRepo : Repo, IRepo<Note, int, bool>
    {
        public bool Create(Note obj)
        {
            db.Notes.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Notes.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Note> Get()
        {
            return db.Notes.ToList();
        }

        public Note Get(int id)
        {
            return db.Notes.Find(id);
        }

        public bool Update(Note obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
