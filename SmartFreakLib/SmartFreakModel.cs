using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public class SmartFreakModel : ISmartFreakModel
    {
        public List<ISmartFreakTable> Tables { get; set; }
        public ISmartFreakTable GetTable(string name)
        {
            return Tables.Where(x => x.Name == name).FirstOrDefault();
        }

        public SmartFreakModel()
        {
            Tables = new List<ISmartFreakTable>();
        }
    }
}
