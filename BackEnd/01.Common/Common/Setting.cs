using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common
{
    public class Setting
    {
        private static Setting _instace { get; set; }
        public Setting()
        {
            this.PathUpdate = ConfigurationManager.AppSettings["FolderUpdate"];
            this.FolderUpdate = HttpRuntime.AppDomainAppPath + this.PathUpdate;
        }
        public static Setting Instance
        {
            get
            {
                return _instace ?? (_instace = new Setting());
            }
        }
        public string FolderUpdate { get; set; }
        public string PathUpdate { get; set; }
    }
}
