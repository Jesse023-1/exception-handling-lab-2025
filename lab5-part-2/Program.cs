using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Create a password:");
                string Pw = Console.ReadLine();

                if (Pw.Length < 8)
                {
                    PasswordComplexityException ex = new PasswordComplexityException("Password below minimum 8 characters");
                    throw ex;
                }
            }
            catch (PasswordComplexityException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
