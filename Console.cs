using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class Console
    {
        // method for asking question and returning answer
        static public string Ask(String question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }
    }
}
