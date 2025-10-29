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
            using (EventLog eventlog = new EventLog())
            {
                string source = "Lab 5";
                string logName = "Application";
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
                    Console.WriteLine("Cannot divide by 0");
                    //string source = "Lab 5";
                    //string logName = "Application";
                    if (!EventLog.SourceExists(source))
                        EventLog.CreateEventSource(source, logName);
                    EventLog.WriteEntry(source, "Divided by Zero Exception", EventLogEntryType.Information, 101, 1);
                    return;

                }
                catch (FormatException ex)
                {
                    ///string source = "Lab 5";
                    //string logName = "Application";
                    Console.WriteLine("Cannot be empty or a string");
                    if (!EventLog.SourceExists(source))
                        EventLog.CreateEventSource(source, logName);
                    EventLog.WriteEntry(source, "Format Exception", EventLogEntryType.Information, 101, 2);
                    return;
                }
                finally
                {
                    if (!EventLog.SourceExists(source))
                        EventLog.CreateEventSource(source, logName);
                    EventLog.WriteEntry(source, "Log message example", EventLogEntryType.Information, 101, 3);
                    
                }
            }
        }
        
    }
}
