using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public interface ISmartFreakFilter
    {
        string Name { get; set; }
        object Value { get; set; }
    }
}
