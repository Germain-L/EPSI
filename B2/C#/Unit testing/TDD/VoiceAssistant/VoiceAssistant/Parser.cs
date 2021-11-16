using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace VoiceAssistant
{
    public class Parser
    {
        static private Dictionary<string, string> _minutes = new Dictionary<string, string>()
        {
            {"05", "cinq"},
            {"10", "dix"},
            {"15", "et quart"},
            {"20", "vingt"},
            {"25", "vingt-cinq"},
            {"45", "le quart"}
        };

        static private Dictionary<string, string> _heures = new Dictionary<string, string>()
        {
            {"00", "minuit"},
            {"1", "une"},
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
            {"13", "une"},
            {"14", "deux"},
            {"15", "trois"},
            {"16", "quatre"},
            {"17", "cinq"},
            {"18", "six"},
            {"19", "sept"},
            {"20", "huit"},
            {"21", "neuf"},
            {"22", "dix"},
            {"23", "onze"},
        };

        static private Dictionary<string, string> _heuresSpecial = new Dictionary<string, string>()
        {
            {"12", "midi"},
            {"00", "minuit"}
        };


        public static string Parse(string time)
        {
            string output = "il est";

            //split time in hours and minutes
            string[] timeSplit = time.Split(':');
            string hours = timeSplit[0];
            string minutes = timeSplit[1];


            output = output + " " + _heures[hours];

            // singulier plurier
            if (int.Parse(hours) < 2)
            {
                output += " heure";
            }
            else
            {
                output += " heures";
            }

            // minutes
            if (_minutes.ContainsKey(minutes))
            {
                if (int.Parse(minutes) > 30)
                {
                    output += " moins " + _minutes[minutes];
                }

                else
                {
                    output += " " + _minutes[minutes];
                }
            }

            // matin aprèm
            if (int.Parse(hours) > 12)
            {
                output += " de l'après-midi";
            }
            else
            {
                output += " du matin";
            }

            // heure spéciale
            if (_heuresSpecial.ContainsKey(hours))
            {
                output = "il est " + _heuresSpecial[hours];

                // minutes
                if (_minutes.ContainsKey(minutes))
                {
                    output += " " + _minutes[minutes];
                }
            }


            return output;
        }
    }
}