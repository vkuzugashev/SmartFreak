using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public class SmartFreakView : ISmartFreakView
    {
        public List<ISmartFreakPage> Pages { get; set; }

        public SmartFreakView()
        {
            Pages = new List<ISmartFreakPage>();
        }

        public ISmartFreakPage GetPageByName(string name)
        {
            return Pages.Where(x => x.Name == name).FirstOrDefault();
        }
    }
}
