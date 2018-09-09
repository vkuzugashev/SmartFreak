using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SmartFreakLib
{
    public interface ISmartFreakPage
    {
        string Name { get; set; }
        string Label { get; set; }
        string Url { get; set; }
        ISmartFreakPageFilter Filter { get; set; }
        ISmartFreakPageCommands Commands { get; set; }
        List<ISmartFreakPagePart> PageParts { get; set; }
        string GetContent();
        string RouteAction(HttpRequest request);
    }
}
