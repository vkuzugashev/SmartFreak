using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public interface ISmartFreakApp
    {
        string Name { get; set; }
        string AssemblyName { get; set; }
        ISmartFreakModel Model { get; set; }
        ISmartFreakView View { get; set; }
        void CreateApp();
    }
}
