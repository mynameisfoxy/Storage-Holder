using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using StorageHolder.Files;
using Google.Apis;

namespace StorageHolder.Storages
{
    class GoogleStorage : IStorage
    {
        public GoogleStorage()
        {

        }

        public Task CreateFolder(string NewFolder)
        {
            throw new NotImplementedException();
        }

        public Task<List<AbstractFile>> GetList(string path)
        {
            throw new NotImplementedException();
        }

        public Task<List<AbstractFile>> GetMetadata(List<AbstractFile> List)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetSharedLink(string path)
        {
            throw new NotImplementedException();
        }

        public Task InitializeDelete(Form OwnerForm, List<AbstractFile> DeleteList)
        {
            throw new NotImplementedException();
        }

        public Task InitializeDownload(Form OwnerForm, string path, List<AbstractFile> DownloadList)
        {
            throw new NotImplementedException();
        }

        public Task InitializeUpload(Form OwnerForm, List<AbstractFile> UploadList, string path)
        {
            throw new NotImplementedException();
        }

        public Task Rename(string path, AbstractFile file)
        {
            throw new NotImplementedException();
        }

        public Task ShowMetadata(string path)
        {
            throw new NotImplementedException();
        }
    }
}
