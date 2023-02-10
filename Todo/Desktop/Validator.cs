using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    public class Validator
    {
        public static string validityCheck(string pass)
        { if (pass.Length >= 7)
            { return null; }
            else {
                return "Error"; 
                    }
    }
}
