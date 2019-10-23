using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bracket_test
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass tc = new TestClass();
            tc.FirstName = "Bob";
            tc.LastName = "Bobson";


            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("FirstName", "Brett");
            names.Add("LastName", "Johnson");

            foreach(string property in names.Keys)
            {
                var value = names[property];
                tc[property] = value;
            }

            Console.WriteLine(tc["FirstName"] + " " + tc["LastName"]);
            Console.ReadLine();
        }
    }
}
