using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace cleanco
{
    public class CompanyCleaner
    {
        private readonly string mOriginalName;
        private readonly string mBusinessName;

        private static readonly Tuple<string, string>[] SortedTypes;
        private static readonly Tuple<string, string>[] SortedCountries;
        private static readonly Tuple<string, string>[] AllSorted;
        private static readonly string[] SortedSuffix;

        static CompanyCleaner()
        {
            SortedTypes =
                (from kvp in TermsData.TermsByType
                    from item in kvp.Value
                    select new Tuple<string, string>(kvp.Key, item)).OrderByDescending(tuple => tuple.Item2.Length)
                    .ToArray();

            SortedCountries =
                (from kvp in TermsData.TermsByCountry
                    from item in kvp.Value
                    select new Tuple<string, string>(kvp.Key, item)).OrderByDescending(tuple => tuple.Item2.Length)
                    .ToArray();

            AllSorted = new Tuple<string, string>[SortedTypes.Length + SortedCountries.Length];
            Array.Copy(SortedTypes, AllSorted, SortedTypes.Length);
            Array.Copy(SortedCountries, 0, AllSorted, SortedTypes.Length, SortedCountries.Length);

            SortedSuffix = (from item in AllSorted
                select item.Item2).OrderByDescending(i => i.Length).ToArray();
        }

        public CompanyCleaner(string companyName)
        {
            mOriginalName = companyName;
            
            Regex regex = new Regex(@"[ ]{2,}", RegexOptions.None);
            companyName = regex.Replace(companyName.Trim(), @" ").Trim();

            mBusinessName = string.Join(" ", companyName.Split(' '));
        }

        public string CleanName(bool suffix = true, bool prefix = false, bool middle = false, bool multi = false)
        {
            string name = mBusinessName;

            foreach (string item in SortedSuffix)
            {
                if (suffix)
                {
                    if (name.EndsWith(" " + item, StringComparison.OrdinalIgnoreCase))
                    {
                        name = StringStripper(name.Substring(0, name.Length - item.Length));
                        if (!multi) break;
                    }
                }

                if (prefix)
                {
                    if (name.StartsWith(item + " ", StringComparison.OrdinalIgnoreCase))
                    {
                        name = name.Substring(item.Length + 1);
                        if (!multi) break;
                    }
                }

                if (middle)
                {
                    string term = string.Concat(" ", item, " ");
                    if (name.ToLower().Contains(term))
                    {
                        int start = name.ToLower().IndexOf(term, StringComparison.OrdinalIgnoreCase);
                        int end = start + term.Length;
                        name = string.Concat(name.Substring(0, start), " ", name.Substring(end));
                        if (!multi) break;
                    }
                }
            }

            return StringStripper(name);
        }

        public string[] Type()
        {
            return EndStrip(SortedTypes);
        }

        public string[] Country()
        {
            return EndStrip(SortedCountries);
        }

        private string[] EndStrip(IEnumerable<Tuple<string, string>> set)
        {
            string name = StringStripper(mBusinessName);
            List<string> keys =
                (from tuple in set where name.ToLower().EndsWith(string.Concat(" ", tuple.Item2)) select tuple.Item1)
                    .ToList();

            return keys.Count != 0 ? keys.ToArray() : null;
        }

        private static string StringStripper(string companyName)
        {
            Regex regex = new Regex(@"[ ]{2,}", RegexOptions.None);
            companyName = regex.Replace(companyName.Trim(), @" ").Trim();
            return Regex.Replace(string.Join(" ", companyName.Split()), @"\W+$", "");
        }
    }
}
