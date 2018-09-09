using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

namespace SmartFreakLib
{
    public class SmartFreakPage : ISmartFreakPage
    {
        public string Name { get; set; }
        public string Label { get; set; }
        public string Url { get; set; }
        public ISmartFreakPageFilter Filter { get; set; }
        public ISmartFreakPageCommands Commands { get; set; }
        public List<ISmartFreakPagePart> PageParts { get; set; }

        public SmartFreakPage()
        {
            PageParts = new List<ISmartFreakPagePart>();
            Filter = new SmartFreakPageFilter();
            Commands = new SmartFreakPageCommands();
        }

        public string GetContent()
        {
            string content = "";

            content += "<div class='filter'>";
            content += Filter.GetContent();
            content += "</div>";

            content += "<div class='commands'>";
            content += Commands.GetContent();
            content += "</div>";

            content += "<div id='"+Name+"' class='pagebody'>";
            content += "<h1>" + Label + "</h1>";


            foreach (ISmartFreakPagePart part in PageParts)
            {
                content += "<div id='"+part.Name+"' class='"+part.ClassName+"'>";
                content += "<h2>" + part.Label + "</h2>";
                content += part.GetContent(null);
                content += "</div>";
            }

            content += "</div>";
            return content;
        }

        public string RouteAction(HttpRequest request)
        {
            string result = null;
            if (request.Params["sf_action"] != null)
            {
                string actionName =  (string)request.Params["sf_action"] + "Action";
                foreach (ISmartFreakPagePart part in PageParts)
                {
                    MethodInfo[] methods = part.GetType().GetMethods();
                    MethodInfo mi = methods.FirstOrDefault(x => x.Name == actionName);
                    if (mi != null)
                    {
                        result = mi.Invoke(part, new object[] { request }) as string;
                        break;
                    }
                }
            }
            return result;
        }

    }
}
