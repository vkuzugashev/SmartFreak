using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using SmartFreakLib;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartFreakApp app = new SmartFreakApp();
            app.Name = "test";
            SmartFreakTable table = new SmartFreakTable() { Name = "test" };
            table.Fields.Add(new SmartFreakTableField { Name = "First" });
            table.Fields.Add(new SmartFreakTableField { Name = "Second" });
            app.Model.Tables.Add(table);
            SmartFreakPage page = new SmartFreakPage() { Name = "main", Label="Главная" };
            SmartFreakPagePart part = new SmartFreakPagePart() { Name="first", Label="Первая", OrderNumber=1 };
            page.PageParts.Add(part);
            part = new SmartFreakPagePart() { Name = "second", Label = "Вторая", OrderNumber = 1 };
            app.View.Pages.Add(page);
            page.PageParts.Add(part);
            Console.WriteLine(page.GetContent());
            HttpRequest request = new HttpRequest("", "http://localhost/myapp", "sf_action=Test");
            Console.WriteLine(page.RouteAction(request));
        }
    }
}
