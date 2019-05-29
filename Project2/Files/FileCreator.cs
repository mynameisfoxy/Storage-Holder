namespace StorageHolder.Files
{
    enum FileDir
    {
        File = 0,
        Folder = 1
    }

    class FileCreator
    {
        public AbstractFile GetNew(FileDir type)
        {
            AbstractFile Result = null;
            switch (type)
            {
                case FileDir.File: Result = new ConcreteFile(); break;
                case FileDir.Folder: Result = new ConcreteFolder(); break;
            }
            return Result;
        }
    }
}
