using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SF = SmartFreakLib;

namespace SmartFreakApp.Models
{
    public class Model
    {
        public SF.SmartFreakApp app { get; set; }

        public Model()
        {
            //Конфигурируем приложение
            app = new SF.SmartFreakApp();
            //app.CreateApp();
            app.Name = "test";
            SF.SmartFreakTable table = new SF.SmartFreakTable() { Name = "test" };
            table.Fields.Add(new SF.SmartFreakTableField { Name = "First" });
            table.Fields.Add(new SF.SmartFreakTableField { Name = "Second" });
            app.Model.Tables.Add(table);
            SF.SmartFreakPage page = new SF.SmartFreakPage() { Name = "main", Label = "Главная" };
            SF.SmartFreakPagePart part = new SF.SmartFreakPagePart() { Name = "first", Label = "Первая", OrderNumber = 1 };
            page.PageParts.Add(part);
            part = new SF.SmartFreakPagePart() { Name = "second", Label = "Вторая", OrderNumber = 1 };
            part.
            page.PageParts.Add(part);
            app.View.Pages.Add(page);
        }

    }
}