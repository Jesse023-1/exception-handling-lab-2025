using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number:");
                string first = Console.ReadLine();
                int number1 = int.Parse(first);
                Console.WriteLine("Enter second number:");
                string second = Console.ReadLine();
                int number2 = int.Parse(second);
                int answer = number1 / number2;
                Console.WriteLine(answer);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.WriteLine("Cannot be divided by 0");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Cannot be empty or a string");
            }
            finally
            {
             using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry("Log message example", EventLogEntryType.Information, 101, 1);
                }   
            }
        }
    }
}
