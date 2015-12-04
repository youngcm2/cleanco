using System;
using System.Collections.Generic;
using cleanco;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleancoTesting
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void BasicCleanup()
        {
            RunTests("Hello World", "cleanup of {0} ({1}) failed", new List<Tuple<string, string>>
            {
                new Tuple<string, string>(@"name w/ suffix", "Hello World Oy"),
                new Tuple<string, string>(@"name w/ ', ltd.'", "Hello World, ltd."),
                new Tuple<string, string>(@"name w/ ws suffix ws", "Hello    World ltd"),
                new Tuple<string, string>(@"name w/ suffix ws", "Hello World ltd "),
                new Tuple<string, string>(@"name w/ suffix dot ws", "Hello World ltd. "),
                new Tuple<string, string>(@"name w/ ws suffix dot ws", " Hello World ltd. ")
            });
        }

        [TestMethod]
        public void MultiCleanup()
        {
            RunTests("Hello World", "cleanup of {0} ({1}) failed", new List<Tuple<string, string>>
            {
                new Tuple<string, string>(@"name + suffix", "Hello World Oy"),
                new Tuple<string, string>(@"name + two suffix", "Hello World Ab Oy"),
                new Tuple<string, string>(@"prefix + name", "Oy Hello World"),
                new Tuple<string, string>(@"prefix + name + suffix", "Oy Hello World Ab"),
                new Tuple<string, string>(@"name w/ term in middle", "Hello Oy World"),
                new Tuple<string, string>(@"name w/ mid + suffix", "Hello Oy World Ab")
            }, true, true, true, true);
        }

        [TestMethod]
        public void PreservingCleanup()
        {
            RunTests("preserving cleanup of {0} ({1}) failed", new List<Tuple<string, Tuple<string, string>>>
            {
                new Tuple<string, Tuple<string, string>>(@"name with comma", new Tuple<string, string>("Hello, World, ltd.", "Hello, World")),
                new Tuple<string, Tuple<string, string>>(@"name with dot", new Tuple<string, string>("Hello. World, Oy", "Hello. World"))
            });
        }

        [TestMethod]
        public void UmlautCleanup()
        {
            RunTests("preserving cleanup of {0} ({1}) failed", new List<Tuple<string, Tuple<string, string>>>
            {
                new Tuple<string, Tuple<string, string>>(@"name with umlaut in end", new Tuple<string, string>("Säätämö Oy", "Säätämö")),
                new Tuple<string, Tuple<string, string>>(@"name with umlauts & comma", new Tuple<string, string>("Säätämö, Oy", "Säätämö")),
                new Tuple<string, Tuple<string, string>>(@"name with no ending umlaut", new Tuple<string, string>("Säätämo Oy", "Säätämo")),
                new Tuple<string, Tuple<string, string>>(@"name with beginning umlaut", new Tuple<string, string>("Äätämo Oy", "Äätämo")),
                new Tuple<string, Tuple<string, string>>(@"name with just umlauts", new Tuple<string, string>("Äätämö", "Äätämö"))
            });
        }

        private static void RunTests(string expected, string errmsg, IEnumerable<Tuple<string, string>> tests,
            bool suffix = true, bool prefix = false, bool middle = false, bool multi = false)
        {
            foreach (var test in tests)
                Assert.AreEqual(expected, new CompanyCleaner(test.Item2).CleanName(suffix, prefix, middle, multi),
                    string.Format(errmsg, test.Item1, test.Item2));
        }

        private static void RunTests(string errmsg, IEnumerable<Tuple<string, Tuple<string, string>>> tests,
            bool suffix = true, bool prefix = false, bool middle = false, bool multi = false)
        {
            foreach (var test in tests)
            {
                Assert.AreEqual(test.Item2.Item2, new CompanyCleaner(test.Item2.Item1).CleanName(suffix, prefix, middle, multi),
                    string.Format(errmsg, test.Item1, test.Item2.Item1));
            }
        }
    }
}
