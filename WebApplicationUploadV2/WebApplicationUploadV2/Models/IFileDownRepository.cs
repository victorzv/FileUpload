using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationUploadV2.Models
{
    public interface IFileDownRepository
    {
        FileDownload GetFile(int Id);
        IEnumerable<FileDownload> GetAllFiles();
        FileDownload Add(FileDownload fileDown);

        void LoadFilesInPath(string path);
    }
}
