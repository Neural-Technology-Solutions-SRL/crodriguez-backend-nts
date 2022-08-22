using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args) 
        {
            
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Lesson17\WriteText", reply);
            Console.ReadLine();
        }
    }
}