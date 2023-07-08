﻿using System;
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
    }
}
