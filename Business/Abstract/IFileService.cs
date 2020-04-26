using Models.File;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFileService
    {

        AddFileModel AddFile(AddFileModel file);
        FileResultModel GetFile(string key);
        List<FileResultModel> GetFileByGroupId(string key);
        List<AddFileModel> AddFileWithGroup(List<AddFileModel> files);
        AddFileModel AddFileToGroup(AddFileModel file);
    }
}
