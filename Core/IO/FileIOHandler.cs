using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Model;

namespace Core.IO
{
    public class FileIOHandler : IOHandler
    {
        private Serializer _serializer;
        private string _path;

        public FileIOHandler(string path, Serializer serializer)
        {
            _serializer = serializer;
            _path = path;
        }

        public void SaveList(List<Entrant> list)
        {
            string data = _serializer.Serialize(list);
            File.WriteAllText(_path, data);
        }

        public List<Entrant> ReadList()
        {
            if (File.Exists(_path))
            {
                string data = File.ReadAllText(_path);
                return _serializer.Deserialize(data);
            }
            else
            {
                Console.WriteLine($"File {_path} Not Found! Creating one!");
                File.Create(_path);
                return new List<Entrant>();
            }
        }
    }
}