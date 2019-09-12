using System;
using System.Collections.Generic;
using System.Linq;

namespace ringba_test
{
    class Program
    {
        private const String Url = "https://ringba-test-html.s3-us-west-1.amazonaws.com/TestQuestions/output.txt";
            
        static void Main(string[] args)
        {
            String fileContent = GetFile.FromUrl(Url);
            
            IEnumerable<String> words = StringUtility.GetWordsFromText(fileContent);
            Console.WriteLine("No of letters:" + fileContent.Count());
            Console.WriteLine("No of Capitalized Letters:" + words.Count());
            
            IEnumerable<KeyValuePair<string, int>> mostFrequent = StringUtility.GetOccurenceByDescendingCount(words);
            Console.WriteLine("Most Common Word:" + mostFrequent.First().Key + "  Count:" + mostFrequent.First().Value);

            IEnumerable<String> prefixes = StringUtility.GetPrefixes(words);
            Console.WriteLine("No of prefixes:" + prefixes.Count());
            
            IEnumerable<KeyValuePair<string, int>> mostFrequentPrefix = StringUtility.GetOccurenceByDescendingCount(prefixes);
            Console.WriteLine("Most Common Prefix:" + mostFrequentPrefix.First().Key + "  Count:" + mostFrequentPrefix.First().Value);
            

        }
    }
}
