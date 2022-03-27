using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;

namespace Anti_Double_Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Anti-Double Counter | By ImGqbbo";
            Console.Write(" [Double Counter] Insert Double Counter link: ");
            string link = Console.ReadLine();
            Console.WriteLine(" [Double Counter] Bypassing...");

            var headers = new Dictionary<string, string>()
            {
                ["Host"] = "verify.dcounter.space",
                ["Connection"] = "keep-alive",
                ["sec-ch-ua"] = "\" Not;A Brand\";v=\"99\", \"Google Chrome\";v=\"97\", \"Chromium\";v=\"97\"",
                ["sec-ch-ua-mobile"] = "?0",
                ["sec-ch-ua-platform"] = "\"Windows\"",
                ["Upgrade-Insecure-Requests"] = "1",
                ["User-Agent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.71 Safari/537.36",
                ["Accept"] = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9",
                ["Sec-Fetch-Site"] = "none",
                ["Sec-Fetch-Mode"] = "navigate",
                ["Sec-Fetch-User"] = "?1",
                ["Sec-Fetch-Dest"] = "document",
                ["Accept-Encoding"] = "gzip, deflate, br",
                ["Accept-Language"] = "it-IT,it;q=0.9,en-US;q=0.8,en;q=0.7",
                ["Cookie"] = ""
            };
            var client = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip,
                AllowAutoRedirect = true,
            });

            foreach (var header in headers)
                client.DefaultRequestHeaders.TryAddWithoutValidation(header.Key, header.Value);

            var res = client.GetAsync(link).Result;
            Console.WriteLine(" [Double Counter] Request status code => " + res.StatusCode);

            if (res.Content.ReadAsStringAsync().Result.Contains("Success!")) Console.WriteLine(" [Double Counter] Almost done...");
            Thread.Sleep(6000);

            Console.WriteLine(" [Double Counter] Successfully bypassed Double Counter!");
            Console.Write(" [Double Counter] Press any key to exit...");

            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
