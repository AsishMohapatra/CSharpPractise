using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace WebApiPractise
{
    class WebsiteContentDownLoader
    {
        public async static Task<int>  GetUrlContentLengthAsync(string baseurl,string requesturi)
        {
            HttpClient webclient = new HttpClient();
            webclient.BaseAddress = new Uri(baseurl);
            var downloadingTaskToTrack= webclient.GetStringAsync(requesturi);
            Console.WriteLine("DownLoad Not Yet Started but wee have a task Id"+downloadingTaskToTrack.Id+
                "   and TasState as"  + downloadingTaskToTrack.AsyncState);
            var downloadedData= await downloadingTaskToTrack;
            return downloadedData.Length;
        }

        public async static Task<string> GetUrlContentAsync(string baseurl, string requesturi)
        {
            HttpClient webclient = new HttpClient();
            webclient.BaseAddress = new Uri(baseurl);
            var downloadingTaskToTrack = webclient.GetStringAsync(requesturi);
            Console.WriteLine("DownLoad Not Yet Started but wee have a task Id" + downloadingTaskToTrack.Id +
                "   and TasState as" + downloadingTaskToTrack.AsyncState);
            var downloadedData = await downloadingTaskToTrack;
            return downloadedData;
        }

        public async static Task<T> GetUrlContentJsonAsync<T>(string baseurl, string requesturi)
        {
            HttpClient webclient = new HttpClient();
            webclient.BaseAddress = new Uri(baseurl);
            var downloadingTaskToTrack = webclient.GetStringAsync(requesturi);
            Console.WriteLine("DownLoad Not Yet Started but wee have a task Id" + downloadingTaskToTrack.Id +
                "   and TasState as" + downloadingTaskToTrack.AsyncState);
            var downloadedData = await downloadingTaskToTrack;
            var jsonOutput = JsonConvert.DeserializeObject<T>(downloadedData);
            return jsonOutput;
        }
    }
}
