using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Diction
    {
        public Dictionary<Words,Words> translations = new Dictionary<Words,Words>();

        public override string ToString()
        {
            string str = "";
            foreach (KeyValuePair<Words,Words>kvp in translations)
            {
                str = str + kvp.Key.ToString() + " : " + kvp.Value.ToString();
            }
            return str;
        }

        public string? findTranslation (string word)
        {
            foreach (KeyValuePair<Words, Words> kvp in translations)
            {
                if (kvp.Key.Contains(word) || kvp.Value.Contains(word))
                {
                    return kvp.Key.ToString() + " : " + kvp.Value.ToString();
                }
            }
            return null;
        }
    }
}
