using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SmartFreakLib
{
    public interface ISmartFreakPagePart
    {
        string Name { get; set; }
        string Label { get; set; }
        string ClassName { get; set; }
        SmartFreakPosition Position { get; set; }
        int OrderNumber { get; set; }
        ISmartFreakTable Table { get; set; }
        string GetContent(List<ISmartFreakFilter> filter);
        //string GetContent(List<ISmartFreakFilter> filter, ISmartFreakTable table);
        string TestAction(HttpRequest request);
    }
}
