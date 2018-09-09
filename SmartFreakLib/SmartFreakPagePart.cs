using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SmartFreakLib
{
    public class SmartFreakPagePart : ISmartFreakPagePart
    {
        public string Name { get; set; }
        public string Label { get; set; }
        public string ClassName { get; set; }
        public SmartFreakPosition Position { get; set; }
        public int OrderNumber { get; set; }
        public ISmartFreakTable Table { get; set; }

        public string TestAction(HttpRequest request)
        {
            string result = "";
            result += "<div>";
            result += "<h1>TestAction</h1>";
            result += "<p>You call TestAction Method and past this parameters:</p>";
            result += "<table>";
            foreach (string key in request.Params.Keys)
            {
                result += "<tr>";
                result += "<td>";
                result += key;
                result += "</td>";
                result += "<td>";
                result += request.Params[key] as string;
                result += "</td>";
                result += "</tr>";
            }
            result += "</table>";
            result += "</div>";
            return result;
        }

        public string GetContent(List<ISmartFreakFilter> filter)
        {
            string content = "";

            if (Table == null)
            {
                content = @"
<h2>Тестовый блок</h2>
<p>Тестовый блок. Тестовый блок. Тестовый блок. Тестовый блок. Тестовый блок. Тестовый блок. Тестовый блок. Тестовый блок. Тестовый блок. Тестовый блок. </p>
";
            }
            else
            {
                List<ISmartFreakTableRow> rows = Table.GetByFilter(filter);
                content += "<table>";
                foreach (ISmartFreakTableField row in Table.Fields.OrderBy(x=>x.OrderNumber))
                {
                    content += "<th>";
                    content += row.Label;
                    content += "</th>";
                }
                foreach (ISmartFreakTableRow row in rows)
                {
                    content += "<tr>";
                    foreach (ISmartFreakTableColumn col in row.Columns.OrderBy(x => x.OrderNumber))
                    {
                        content += "<td>";
                        content += col.Value;
                        content += "</td>";
                    }
                    content += "</tr>";
                }
                content += "</table>";
            }
            return content;
        }

       
    }
}
