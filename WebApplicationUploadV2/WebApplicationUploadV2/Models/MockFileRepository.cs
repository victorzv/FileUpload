using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WebApplicationUploadV2.Models
{
    public class MockFileRepository : IFileDownRepository
    {
        private List<FileDownload> _fileDowns;
        public FileDownload GetFile(int Id)
        {
            return _fileDowns.FirstOrDefault(e => e.Id == Id);
        }

        public IEnumerable<FileDownload> GetAllFiles()
        {
            return _fileDowns;
        }

        public FileDownload Add(FileDownload fileDown)
        {
            fileDown.Id = _fileDowns.Max(e => e.Id) + 1;
            _fileDowns.Add(fileDown);
            return fileDown;
        }

        public void LoadFilesInPath(string path)
        {
            _fileDowns = new List<FileDownload>();

            int Id = 1;
            foreach (string file in Directory.GetFiles(path))
            {
                FileDownload fileDownload = new FileDownload();
                fileDownload.Id = Id++;
                fileDownload.Path = file;

                var fileName = file.Contains("\\")
                    ? file.Trim('"').Substring(file.LastIndexOf("\\", StringComparison.Ordinal) + 1)
                    : file.Trim('"');

                fileDownload.Filename = fileName;
                _fileDowns.Add(fileDownload);
            }
            
        }

        public MockFileRepository()
        {

        }
    }
}
