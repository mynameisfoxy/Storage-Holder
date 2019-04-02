using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageHolder.Files
{
    class CreateConcreteFolder : FileCreator
    {
        public override AbstractFile Create() { return new ConcreteFolder(); }
    }
}
