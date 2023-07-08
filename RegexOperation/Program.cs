﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexOperation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            string ans = "";
            do {
                Console.WriteLine("1:Charctor Checking \n2: Sequence Of Char Checking \n3: Fetch HTML tag");
                Console.WriteLine("Enter the choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the string : ");
                            string str = Console.ReadLine();
                            pattern.CharMatch(str);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the string : ");
                            string str = Console.ReadLine();
                            pattern.CharMatch(str);
                            break;
                        }
                        case 3:
                        {
                            string str = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
                            pattern.Match_HTML_Tag(str);                          
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please insert the valid number");
                            break;
                        }

                }
                Console.WriteLine("Do you want to continue..?");
                ans=Console.ReadLine();
            } while (ans=="yes" || ans=="y");
            Console.ReadLine();
        }
    }
}
