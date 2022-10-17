using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    enum Language
    {
        English, 
        Czech
    }
    internal class Words
    {
        public List<string> words_list = new List<string>();
        public Language type;

        public Words (Language type, params string[]? w)
        {
            this.type = type;
            foreach (string word in w)
            {
                words_list.Add (word);
            }
        }

        public bool Contains(string word)
        {
            return words_list.Contains(word);
        }

        public override string ToString()
        {
            String str = "";
            foreach (var s in words_list)
            {
                str = str + s + " ";
            }
            return str;
        }

    }
}
