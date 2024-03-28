using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWF
{
    static class Extension
    {
        public static string ToText(this object sender)
        {
            return sender.ToString().Replace("System.Windows.Forms.Button, Text: ", "");
        }
    }
}
