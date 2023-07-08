using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexOperation
{
    public class Pattern
    {
        public void CharMatch(string message)
        {
            string pattern = "^ab{2,3}";

            bool match = Regex.IsMatch(message, pattern);
             
            if (match)
            {
                Console.WriteLine("String is valid...!");
            }
            else
            {
                Console.WriteLine("String is not valid...!");
            }         
        }
        public void SequenceCharMatch(string message)
        {     
            string pattern = "^[a-z]+_[a-z]+$";

        bool match = Regex.IsMatch(message, pattern);
            if (match)
            {
                Console.WriteLine("String is valid...!");
            }
            else
            {
                Console.WriteLine("String is not valid...!");
            }
        }
        public void Match_HTML_Tag(string message)
        {       
        string pattern = @"<.*?>";

        var matches = Regex.Matches(message, pattern);

            if (matches.Count > 0)
            {
                Console.WriteLine("Match found:");
                foreach (Match m in matches)
                {
                    Console.WriteLine(m.Value);
                }
            }
        }
        public int Count_Frequency_Of_String(string message)
        {   
            string pattern = @"fox(es)?";

        var n = Regex.Matches(message, pattern.ToString()).Count;
            return n;
        }
        public void Image_File_Extention(string message)
        {   
            string pattern = @"([^\s]+(\.(?i)(jpe?g|png|gif|bmp))$)";

        bool match = Regex.IsMatch(message, pattern);
            if (match)
            {
                Console.WriteLine("File Type extention is valid...!");
            }
            else
            {
                Console.WriteLine("File Type extention is not valid...!");
            }
        }
    }
}
