using HtmlAgilityPack;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace Лаба3
{
    class DonwloadFiles
    {
        string url { get; set; }
        string type { get; set; }
        string path { get; set; }

        public DonwloadFiles(string url, string type, string path)
        {
            this.url = url;
            this.type = type;
            this.path = path;
        }

        public void Donwload()
        {
            var htmlDoc = new HtmlWeb();
            var doc = htmlDoc.Load(url);

            var node = doc.DocumentNode.SelectNodes("//li").ToList();
            string urldonw = "";
            node.ForEach(item => urldonw += item.OuterHtml + "\n");
            Regex regex = new Regex($"ht.*{type}\"");

            MatchCollection mathes = regex.Matches(urldonw);

            foreach (Match math in mathes)
            {
                Console.WriteLine("Wait !");
                new WebClient().DownloadFile(math.ToString().TrimEnd('\"'), path + Path.GetFileName(String.Join(null, math.ToString().TrimEnd('\"').Skip(28))));
            }

            Console.WriteLine("End!");
        }
    }
}
