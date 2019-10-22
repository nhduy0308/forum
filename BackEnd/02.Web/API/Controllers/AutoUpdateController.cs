using Common;
using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class AutoUpdateController : ApiController
    {
        public IHttpActionResult Get()
        {
            var service = new List<string>() { "ZeroEye.exe", "base.dll" };
            var files = Directory.GetFiles(Setting.Instance.FolderUpdate,"*.*",SearchOption.AllDirectories);
            var result = files?.Select(file => {
                var f = new FileInfo(file);
                var folder = f.Directory.FullName.Replace(Setting.Instance.FolderUpdate, "");
                if (!string.IsNullOrEmpty(folder))
                {
                    folder = folder.Remove(0, 1);
                }
                return new FileResult
                {
                    Version = f.Length,
                    Name = f.FullName.Replace(Setting.Instance.FolderUpdate + "\\", ""),
                    Extension = f.Extension,
                    Folder = folder,
                    Service = service.Any(x => x.Equals(f.Name)),
                    FullName = f.FullName.Replace(HttpRuntime.AppDomainAppPath, $"{HttpContext.Current.Request.Url.Scheme}://{HttpContext.Current.Request.Url.Authority}/").Replace("\\","/")
                };
            });
            if (!files.Any())
            {
                return NotFound();
            }
            return Ok(result);

        }
    }
}
