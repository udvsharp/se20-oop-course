using System.Collections.Generic;
using Model;

namespace Core.IO
{
    public interface IOHandler
    {
        void SaveList(List<Entrant> list);
        List<Entrant> ReadList();
    }
}