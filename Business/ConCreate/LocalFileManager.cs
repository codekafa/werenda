using Business.Abstract;
using Models.File;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ConCreate
{
    public class LocalFileManager : IFileService
    {


        public AddFileModel AddFile(AddFileModel file)
        {
            return file;
        }

        public AddFileModel AddFileToGroup(AddFileModel file)
        {
            throw new NotImplementedException();
        }

        public List<AddFileModel> AddFileWithGroup(List<AddFileModel> files)
        {
            throw new NotImplementedException();
        }

        public FileResultModel GetFile(string key)
        {
            throw new NotImplementedException();
        }

        public List<FileResultModel> GetFileByGroupId(string key)
        {
            throw new NotImplementedException();
        }
    }
}
