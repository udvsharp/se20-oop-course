using System.Collections;
using System.Collections.Generic;
using Core.IO;
using Model;

namespace Core
{
    public class EntrantList : IEnumerable<Entrant>
    {
        public IOHandler IoHandler { get; set; }
        public List<Entrant> List { get; set; }

        public int Count => List.Count;

        public EntrantList(IOHandler ioHandler)
        {
            List = new List<Entrant>();
            IoHandler = ioHandler;
        }

        public void Read()
        {
            List = IoHandler.ReadList();
        }

        public void Save()
        {
            IoHandler.SaveList(List);
        }

        public void Add(Entrant e)
        {
            List.Add(e);
            
        }

        public IEnumerator<Entrant> GetEnumerator()
        {
            return List.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}