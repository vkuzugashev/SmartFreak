using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public class SmartFreakPageCommand : ISmartFreakPageCommand
    {
        public string Name { get; set; }
        public string Label { get; set; }
        public string Method { get; set; }

        public string GetContent()
        {
            string content = "";
            return content;
        }
    }
}
