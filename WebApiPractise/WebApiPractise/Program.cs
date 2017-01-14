using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiPractise
{
    class Program
    {
        static string downloadedData;
        static void Main(string[] args)
        {
            Console.WriteLine("Request For DownLoad start");
            var downloadedDataLength=WebsiteContentDownLoader.GetUrlContentAsync("http://www.google.com", "");
            Console.WriteLine("Download task status = " + downloadedDataLength.Status);
            Console.WriteLine("Download task status = " + 
                (downloadedDataLength.IsCompleted?"Completed": "In Progress"));
            Thread.Sleep(20000);
            Console.WriteLine("Total length = " + downloadedDataLength.Result);
            Console.ReadLine();
        }
    }
}
