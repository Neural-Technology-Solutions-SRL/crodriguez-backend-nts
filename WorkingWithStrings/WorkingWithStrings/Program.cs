using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program 
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a\nnew line?";
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";
            //string myString = String.Format("{1} = {0}", "First", "second");
            //string myString = String.Format("{0:C}", 549.99);
            //string myString = String.Format("{0:N}", 657464687336);
            //string myString = String.Format("Percentage: {0:P}", .785);
            //string myString = String.Format("Phone Number: {0:(###) ###-####}", 8095841982);

            //string myString = "  I can see clearly now the rain is gone   ";

            //myString = myString.Substring(4, 17);
            //myString = myString.ToUpper();
            //myString = myString.Replace("can", "cannot");
            //myString = myString.Remove(0, 18);

            /*
            myString = String.Format("Length before: {0} -- Length after: {1}",
                myString.Length,
                myString.Trim().Length);
            */

            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}