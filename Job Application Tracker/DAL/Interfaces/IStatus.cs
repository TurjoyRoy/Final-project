using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IStatus<CLASS, ID>
    {
        List<CLASS> FilterApp(string statuses);
        CLASS StatusTrack(ID id);
    }
}
