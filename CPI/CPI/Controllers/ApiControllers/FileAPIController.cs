using System.Web;
using System.Web.Http;
using CPI.Models.Responses;
using CPI.Services;
using System.Net.Http;

namespace CPI.Controllers.ApiControllers
{
    [RoutePrefix("api/files")]
    public class FileAPIController : ApiController
    {
        [Route("supplier/{id:int}"), HttpPost]
        public HttpResponseMessage MyFileUpload(int id)
        {
            var request = HttpContext.Current.Request;
            foreach (string fileKey in request.Files)
            {
                HttpPostedFile file = request.Files[fileKey];
                PerformStandardSave(file, id);
            }

            ItemResponse<string> response = new ItemResponse<string>();
            response.Item = "Uploaded Successfully";//FileUploadService.UploadResult();
            return Request.CreateResponse(response);
        }

        private void PerformStandardSave(HttpPostedFile file, int supplierId)
        {
            try
            {
                string fileType = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);
                string savePath = string.Format("{0}\\{1}_{2}.{3}", GetSaveDirectory(), /*Users.CurrentUser.Id,*/ supplierId, fileType);

                file.SaveAs(savePath);
                //SessionHelper.Instance.MostRecentlyUploadedFilePath = savePath;
                //FuelSheetHandler handler = new FuelSheetHandler();
                //handler.Process(savePath, Users.CurrentUser.ClientID, supplierId);
            }
            catch (System.Exception exception)
            {
                var test = exception;
            }
        }

        private string GetSaveDirectory()
        {
            var request = HttpContext.Current.Request;
            string serverPath = request.PhysicalApplicationPath;
            string uploadPath = serverPath + @"Uploads\";
            return uploadPath;
        }
    }
}
