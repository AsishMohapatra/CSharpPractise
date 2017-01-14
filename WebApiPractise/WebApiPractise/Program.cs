using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WebApiPractise
{
    class Program
    {
        static string downloadedData;
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Step -1");
            var downloadedDataTask = WebsiteContentDownLoader.GetUrlContentAsync("http://www.google.com", "");
            Console.WriteLine("Download task status = " + downloadedDataTask.Status);
            Console.WriteLine("Download task status = " +
                (downloadedDataTask.IsCompleted ? "Completed" : "In Progress"));
            while (!downloadedDataTask.IsCompleted)
            {
                Console.WriteLine("Main Thread free   " + "Download in progress");
            }
            Console.WriteLine("Download Completed with data length " + downloadedDataTask.Result.Length);
            Console.ReadLine();
        }
    }
}
