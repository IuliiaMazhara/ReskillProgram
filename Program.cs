using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create console application which as argument accept string value (string1) and accept additional string from console (string 2).
    String1 and string2 should be join in one single string. Joined string should be outputted in console. 
    After that user should enter one more string (string3). String 3 should be removed from joined string, result string after remove should be outputted in console  */

namespace ReskillProgram
{
    internal class Program
    {

        static string readLine() {

            Console.WriteLine("Please enter the string");           
            return  Console.ReadLine();

        }
        static string joinLine(string firstLine, string secondLine)
        {

            Console.WriteLine("The joined line is " + firstLine + secondLine);
            return firstLine + secondLine;

        }

        static void removeLine(string originalLine, string toBeRemovedLine)
        {

             Console.WriteLine("The string excluded the last entered one is " + originalLine.Replace(toBeRemovedLine, "")); 

        }
        static void Main(string[] args)
        {
            string fromMainMethod = args[0];
            string joinedLine = joinLine(fromMainMethod, readLine());                     
            string toBeRemoved = readLine();
            removeLine(joinedLine, toBeRemoved);


        }
    }
}
