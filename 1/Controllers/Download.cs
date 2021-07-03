using _1.DBcontext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public DownloadController(DataBaseContext context)
        {
            _context = context;
        }

        [HttpGet("{id}/Download")]
        public async Task<IActionResult> Download(Guid id)
        {
            var myFile = await _context.myFiles.FirstOrDefaultAsync(f => f.Id == id);

            if (myFile is null)
                return NotFound();

            if (!System.IO.File.Exists(myFile.Path))
                return NotFound();

            var memory = new MemoryStream();

            await using (var stream = new FileStream(myFile.Path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }

            memory.Position = 0;

            return File(memory, GetContentType(myFile.Path), myFile.Name);
        }
        #region Private Method
        private string GetContentType(string path)
        {
            var provider = new FileExtensionContentTypeProvider();
            string contentType;

            if (!provider.TryGetContentType(path, out contentType))
            {
                contentType = "application/octet-stream";
            }

            return contentType;
        }
        #endregion
    }
}
