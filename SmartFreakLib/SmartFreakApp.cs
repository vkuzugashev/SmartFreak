using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public class SmartFreakApp : ISmartFreakApp
    {
        public string Name { get; set; }
        public string AssemblyName { get; set; }
        public ISmartFreakModel Model { get; set; }
        public ISmartFreakView View { get; set; }

        public SmartFreakApp() {
            Model = new SmartFreakModel();
            View = new SmartFreakView();
        }

        public void CreateApp()
        {

        }

    }
}
