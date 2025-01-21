using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.TableModels
{
    public class Note
    {
        public int Id { get; set; }
        public string NoteText { get; set; }

        [ForeignKey("Application")]
        public int AppId { get; set; }
        public virtual Application Application { get; set; }

    }
}
