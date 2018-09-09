using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public class SmartFreakFilter : ISmartFreakFilter
    {
        public string Name { get; set; }
        public object Value { get; set; }
    }
}
