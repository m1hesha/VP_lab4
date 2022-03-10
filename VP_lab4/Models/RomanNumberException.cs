using System;

namespace VP_lab4.Models
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException() : base("ERROR") { }
        public RomanNumberException(string message) : base(message) { }
    }
}