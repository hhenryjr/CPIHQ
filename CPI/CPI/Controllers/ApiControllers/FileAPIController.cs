using System.IO;
using System.Web;
using System.Web.Http;
using CPI.Models.Responses;
using CPI.Services;
using System.Net.Http;
using System.Collections.Generic;

namespace CPI.Controllers.ApiControllers
{
    [RoutePrefix("api/files")]
    public class FileAPIController : ApiController
    {
        [Route(""), HttpPost]
        public HttpResponseMessage MyFileUpload()
        {
            string tempPath = string.Format("{0}\\TempFiles", GetSaveDirectory());
            DirectoryInfo dir = new DirectoryInfo(tempPath);
            try
            {
                foreach (var file in dir.GetFiles())
                {
                    file.Delete();
                }
            }
            catch(System.Exception e)
            {
                string dumbIdea = e.Message;
                return Request.CreateResponse(dumbIdea);
                //look I'm Marty's boss;
            }

            var request = HttpContext.Current.Request;
            List<string> filePathList = new List<string>();
            System.Web.Mvc.ContentResult PersonalityResult = null;
            foreach (string fileKey in request.Files)
            {
                HttpPostedFile file = request.Files[fileKey];
                string serverPath = PerformStandardSave(file);
                filePathList.Add(serverPath);

                if(!string.IsNullOrEmpty(serverPath))
                {
                    string content = ParseService.ParseFileExtractor(serverPath);
                    PersonalityResult = PersonalityService.GetPersonality(content);
                     
                    //File.Delete(serverPath);
                }
            }

            //foreach (string path in filePathList)
            //{
            //    File.Delete(path);
            //}

            return Request.CreateResponse(PersonalityResult);
        }

        private string PerformStandardSave(HttpPostedFile file)
        {
            string finalPath = null;
            try
            {
                string fileType = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);
                string filename = file.FileName.Substring(0, file.FileName.LastIndexOf("."));
                string savePath = string.Format("{0}\\TempFiles\\{1}", GetSaveDirectory(), file.FileName);

                file.SaveAs(savePath);
                finalPath = savePath;                
            }
            catch (System.Exception exception)
            {
                var test = exception;
                finalPath = string.Empty;
            }
            return finalPath;
        }

        private string GetSaveDirectory()
        {
            var request = HttpContext.Current.Request;
            string serverPath = request.PhysicalApplicationPath;
            return serverPath;
        }
    }
}
