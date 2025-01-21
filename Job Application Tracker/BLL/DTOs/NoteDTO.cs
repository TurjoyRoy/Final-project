using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class NoteDTO
    {
        public int Id { get; set; }
        public string NoteText { get; set; }
        public int AppId { get; set; }
    }
}
