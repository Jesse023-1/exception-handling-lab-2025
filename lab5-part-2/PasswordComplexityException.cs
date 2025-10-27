using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab5_part_2
{
    internal class PasswordComplexityException : Exception
    {
        private string message { get; set; }

        public PasswordComplexityException(string message)
        {
            this.message = message;
        }

        public override string Message
        {
            get { return string.Format("Password creation error: {0}", message); }
        }
    }
}
