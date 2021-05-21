using System.Collections.Generic;
using Model;

namespace Core.IO
{
    public interface Serializer
    {
        string Serialize(List<Entrant> list);
        List<Entrant> Deserialize(string data);
    }
}