using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public interface ISmartFreakModel
    {
        List<ISmartFreakTable> Tables { get; set; }
        ISmartFreakTable GetTable(string name);
    }
}
