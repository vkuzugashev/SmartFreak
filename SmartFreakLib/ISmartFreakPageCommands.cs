using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public interface ISmartFreakPageCommands
    {
        string Name { get; set; }
        SmartFreakPosition Position { get; set; }
        List<ISmartFreakPageCommand> Commands { get; set; }
        string GetContent();
    }
}
