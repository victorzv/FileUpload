using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApplicationUploadV2.Models;

namespace WebApplicationUploadV2.Controllers
{
    [Consumes("application/json", "applicatiion/json-patch+json", "multipart/form-data")]
    public class HomeController : Controller
    {
        private IHostingEnvironment _hosting;
        private IFileDownRepository _fileDownRepository;

        public HomeController(IFileDownRepository fileDownRepository, IHostingEnvironment hosting)
        {
            _hosting = hosting;
            _fileDownRepository = fileDownRepository;
            var filePath = $"{this._hosting.WebRootPath}\\files";
            _fileDownRepository.LoadFilesInPath(filePath);
        }
        public ViewResult Index()
        {
            var model = _fileDownRepository.GetAllFiles();
            return View(model);            
        }

        public ViewResult Details(int id)
        {
            FileDownload model = _fileDownRepository.GetFile(id);
            return View("Test", model);
        }

        public JsonResult Files()
        {
            return Json(_fileDownRepository.GetAllFiles());
        }

        [HttpPost]
        public JsonResult Download(string Ids)
        {
            string[] idArray = Ids.Split(",");

            foreach (string id in idArray)
            {
                FileDownload fileDownload = _fileDownRepository.GetFile(Int32.Parse(id));
                using (var client = new WebClient())
                {
                    client.DownloadFile(fileDownload.Path, fileDownload.Filename);
                }

            }

            return Json("ok");
        }


        [HttpPost]        
        public JsonResult Upload(IFormFile files)
        {
            var filePath = $"{this._hosting.WebRootPath}\\files";

                var fileName = ContentDispositionHeaderValue.Parse(files.ContentDisposition).FileName;

                // Ensure the file name is correct
                fileName = fileName.Contains("\\")
                    ? fileName.Trim('"').Substring(fileName.LastIndexOf("\\", StringComparison.Ordinal) + 1)
                    : fileName.Trim('"');

                var fullFilePath = Path.Combine(filePath, fileName);


                using (var stream = new FileStream(fullFilePath, FileMode.Create))
                {
                    files.CopyTo(stream);
                }


            FileDownload fileDownload = new FileDownload();
            fileDownload.Path = fullFilePath;
            fileDownload.Filename = fileName;
            fileDownload =_fileDownRepository.Add(fileDownload);
            return Json(fileDownload);
        }
    }
}
