using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public interface ISmartFreakPageCommand
    {
        string Name { get; set; }
        string Label { get; set; }
        string Method { get; set; }
        string GetContent();
    }
}
