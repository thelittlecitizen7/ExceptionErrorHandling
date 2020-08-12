using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionErrorHandling
{
    public class ScubaException : Exception
    {
        public int StudentNumber { get; set; }
        
        public ScubaException(string  message,int studentNumber) : base(message)
        {
            StudentNumber = studentNumber;
        }
    }
}
