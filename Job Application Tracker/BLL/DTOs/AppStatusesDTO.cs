using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AppStatusesDTO : ApplicationDTO
    {
        public List<AppStatusDTO> AppStatusHistories { get; set; }

        public AppStatusesDTO()
        {
            AppStatusHistories = new List<AppStatusDTO>();
        }
    }
}
