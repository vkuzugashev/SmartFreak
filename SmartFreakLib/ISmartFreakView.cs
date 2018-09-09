using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public interface ISmartFreakView
    {
        List<ISmartFreakPage> Pages { get; set; }
        ISmartFreakPage GetPageByName(string name);
    }
}
