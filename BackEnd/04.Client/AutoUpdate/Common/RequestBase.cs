using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdate.Common
{
    public class RequestBase
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string Host = "http://api.mup.com";
        public static async Task<List<T>> Get<T>(string Url)
        {
            var responseString = await client.GetStringAsync(Host + Url);
            return JsonConvert.DeserializeObject<List<T>>(responseString);
        }
        public static void DownloadFile(FileResult file)
        {
            using(var c = new WebClient())
            {
                if (!string.IsNullOrEmpty(file.Folder) && !Directory.Exists(file.Folder))
                {
                    Directory.CreateDirectory(file.Folder);
                }
                c.DownloadFile(file.FullName, file.Name);
            }
        }
    }
}
