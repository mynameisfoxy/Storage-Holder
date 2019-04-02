using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageHolder
{
    class ConcreteFile : AbstractFile
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public FileTypes Type { get; set; }
        public string Id { get; set; }
        public int Icon { get; set; } = 0;
        public override string GetType() { return "File"; }
    }
}
