using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageHolder.Files
{
    class ConcreteFile : AbstractFile
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public float FileSize { get; set; }
        public DateTime DateFileClientModified { get; set; }
        public DateTime DateFileServerModified { get; set; }
        public override FileDir Type() { return FileDir.File; }
    }
}
