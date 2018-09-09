using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public class SmartFreakPageCommands : ISmartFreakPageCommands
    {
        public string Name { get; set; }
        public SmartFreakPosition Position { get; set; }
        public List<ISmartFreakPageCommand> Commands { get; set; }

        public SmartFreakPageCommands()
        {
            Commands = new List<ISmartFreakPageCommand>();
        }

        public string GetContent()
        {
            string content = "";
            foreach (ISmartFreakPageCommand cmd in Commands)
                content += cmd.GetContent();
            return content;
        }
    }
}
