using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageHolder.Files
{
    class ConcreteFolder : AbstractFile
    {
        public string FolderName { get; set; }
        public string FolderPath { get; set; }
        public override FileDir Type() { return FileDir.Folder; }
    }
}
