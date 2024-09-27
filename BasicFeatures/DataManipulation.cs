using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFeatures
{
    public class DataManipulation
    {
        public static void TestDictionary()
        {
            Dictionary<int,string> friends = new Dictionary<int, string>
            {
                {1, "Nickson" },
                {2, "John" },
                {3, "Stephen " },
                {4, "Rose" },
                {5, "Trevor" },
            };
            for(int i=0; i< friends.Count; i++)
            {
                KeyValuePair<int, string> friend = friends.ElementAt(i);
                Console.WriteLine($"{friend.Key} -  {friend.Value}");
            }
            Console.WriteLine(friends[5]);
        }
    }
}
