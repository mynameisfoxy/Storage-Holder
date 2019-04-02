using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageHolder
{
    class ConcreteFolder : AbstractFile
    {
        public string FolderName { get; set; }
        public string FolderPath { get; set; }
        public FileTypes Type { get; } = FileTypes.Folder;
        public string Id { get; set; }
        public int Icon { get; set; } = 1;
        public override string GetType() { return "Folder"; }
    }
}
