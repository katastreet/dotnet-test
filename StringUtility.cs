using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ringba_test
{
    public static class StringUtility
    {
        public static IEnumerable<string> GetWordsFromText(String text)
        {
            return Regex.Matches(text, "[A-Z][a-z]*[^A-Z]").Select(match => match.Value);
        }


        public static IEnumerable<KeyValuePair<string, int>> GetOccurenceByDescendingCount(IEnumerable<String> words)
        {
            return words.GroupBy(word => word)
                .Select(group => new KeyValuePair<string, int>(group.Key, group.Count()))
                .OrderByDescending(kvp => kvp.Value);
        }
        
        public static IEnumerable<String> GetPrefixes(IEnumerable<String> words)
        {
            return words.Where(a => a.Length > 2).Select(match => match.Substring(0, 2));
        }
    }
}