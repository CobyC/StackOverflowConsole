using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleRegExStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"<<[\w\s\#\:\,\|]+\>>");

            //DocumentRange[] pTokenRangeList = document.FindAll(expr, document.Range);
            Console.WriteLine("Hello World!");

            MatchReply mr = new MatchReply()
            {
                Matches = new List<Match>
                {
                    new Match{ ConfidenceProbability = 1.1f, ReleaseNumber = "1", UnitNumber = "abc" },
                    new Match{ ConfidenceProbability = 1.2f, ReleaseNumber = "2", UnitNumber = "def" },
                    new Match{ ConfidenceProbability = 1.3f, ReleaseNumber = "3", UnitNumber = "ghi" },
                }
            };

            //copy matches to release
            EventMessage em = new EventMessage();

            em.Releases = mr.Matches.Select(m => new Release
            {
                ConfidenceProbability = m.ConfidenceProbability,
                ReleaseNumber = m.ReleaseNumber
            });


        }
    }
    public class Match
    {
        public string ReleaseNumber { get; set; }
        public string UnitNumber { get; set; }
        public float ConfidenceProbability { get; set; }
    }

    public class MatchReply
    {
        public IEnumerable<Match> Matches { get; set; }
    }

    public class Release
    {
        public string ReleaseNumber { get; set; }
        public float ConfidenceProbability { get; set; }
    }

    public class EventMessage
    {
        public IEnumerable<Release> Releases { get; set; }
    }

}
