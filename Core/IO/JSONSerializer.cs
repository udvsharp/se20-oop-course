using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using Model;

namespace Core.IO
{
    public class JSONSerializer : Serializer
    {
        public string Serialize(List<Entrant> list)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    IncludeFields = true,
                };

                return JsonSerializer.Serialize(list, options);
            }
            catch (JsonException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public List<Entrant> Deserialize(string data)
        {
            try
            {
                return JsonSerializer.Deserialize<List<Entrant>>(data);
            }
            catch (JsonException e)
            {
                Console.WriteLine(e);
                return new List<Entrant>();
            }
        }
    }
}