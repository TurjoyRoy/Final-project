using System;
using System.Collections.Generic;
using System.Data.Entity;
using DAL.EF.TableModels;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class JATContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<AppStatus> AppStatuses { get; set; }

    }
}
