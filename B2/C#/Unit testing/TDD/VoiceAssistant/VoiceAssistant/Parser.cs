using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace VoiceAssistant
{
    public class Parser
    {
        private Dictionary<string, string> _minutes = new Dictionary<string, string>()
        {
            {"1", "un"},
            {"2", "deux"},
            {"3", "trois"},
            {"4", "quatre"},
            {"5", "cinq"},
            {"6", "six"},
            {"7", "sept"},
            {"8", "huit"},
            {"9", "neuf"},
            {"10", "dix"},
            {"11", "onze"},
            {"12", "douze"},
            {"13", "trieze"},
            {"14", "quatorze"},
            {"15", "quinze"},
            {"16", "seize"},
            {"20", "vingt"},
            {"30", "trente"},
            {"40", "quarante"},
            {"50", "cinquante"},
        };

        public static string Parse(string time)
        {
            Regex r = new Regex(@"^(?:\d|[01]\d|2[0-3]):[0-5]\d$");

            string output = "";

            if (!r.IsMatch(time))
            {
                throw new FormatException();
            }

            string[] timeSplit = time.Split(':');

            if (time == "01:00")
            {
                return "il est une heure du matin";
            }

            if (time == "12:00")
            {
                output = "il est midi";
            }


            return time;
        }
    }
}