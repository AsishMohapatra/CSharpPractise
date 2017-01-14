using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WebApiPractise
{
    class WebsiteContentDownLoader
    {
        public static string  GetContent(string baseurl,string requesturi)
        {
            HttpClient webclient = new HttpClient();
            webclient.BaseAddress = new Uri(baseurl);
            Task<string> webContent=webclient.GetStringAsync(requesturi);

        }
    }
}
