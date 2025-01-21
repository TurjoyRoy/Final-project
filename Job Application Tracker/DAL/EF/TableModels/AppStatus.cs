using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.TableModels
{
    public class AppStatus
    {
        public int Id { get; set; }

        [Required]
        public string Status { get; set; }

        [ForeignKey("Application")]
        public int ApplicationId { get; set; }
        public virtual Application Application { get; set; }

    }
}