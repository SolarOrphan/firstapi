using System.Collections.Generic;
using firstapi.Models;

namespace firstapi.Data
{
    public interface Ifirstapirepo
    {
        IEnumerable<Howto> GetData();
        Howto getobject(int id);

    }
}