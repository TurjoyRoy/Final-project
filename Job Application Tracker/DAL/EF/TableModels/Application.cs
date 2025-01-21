using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.TableModels
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string position { get; set; }
        public string company { get; set; }
        public DateTime DateApplied { get; set; }
        public string status { get; set; }
        public virtual ICollection<Note> AppId { get; set; }
        public virtual ICollection<AppStatus> ApplicationId { get; set; }

        public Application()
        {
            AppId = new List<Note>();
            ApplicationId = new List<AppStatus>();
        }

    }
}
