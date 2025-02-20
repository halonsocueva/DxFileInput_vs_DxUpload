using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DxFileInput_vs_DxUpload.Blazor.Server.Editors.UploadDragEditor
{
    [Route("api/Upload")]
    [ApiController]
    public class DxUploadController : ControllerBase
    {
        [HttpPost("[action]")]
        public ActionResult Upload(IFormFile myFile)
        {
            try
            {
                // Write code that saves the 'myFile' file.
                // Don't rely on or trust the FileName property without validation.
            }
            catch
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
