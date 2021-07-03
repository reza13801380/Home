using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Models
{
    public class MyFile
    {
        public MyFile(string name,string path)
        {
            Id = Guid.NewGuid();
            Name = name;
            Path = path;
        }
        public Guid Id { get; set; }
        public string Name  { get; set; }
        public string Path { get; set; }
        public long? Size { get; set; }
        private MyFile()
        {
        }
    }
}
