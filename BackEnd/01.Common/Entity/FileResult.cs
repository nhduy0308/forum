using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FileResult
    {
        public string Name { get; set; }
        public long Version { get; set; }
        public string Extension { get; set; }
        public string FullName { get; set; }
        public string Folder { get; set; }
        public bool Service { get; set; }
    }
}
