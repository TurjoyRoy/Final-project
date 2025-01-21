using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ApplicationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string position { get; set; }
        public string company { get; set; }
        public DateTime DateApplied { get; set; }
        public string status { get; set; }
    }
}
