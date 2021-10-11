using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2X1_Milestone
{
    class EmptyTextBoxException : Exception
    {
        public EmptyTextBoxException() { }
        public EmptyTextBoxException(string message) : base(message) { }
    }
}
