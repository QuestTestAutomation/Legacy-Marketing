using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParallelSelenium.Common
{
    public class DELLQAException : Exception
    {
        public DELLQAException()
        {
            Logger.Error("Error");
        }

        public DELLQAException(string message)
            : base(message)
        {
            Logger.Error(message);
        }

        public DELLQAException(string message, Exception inner)
            : base(message, inner)
        {
            Logger.Error(message + "exception = " + inner);
        }
    }
}

