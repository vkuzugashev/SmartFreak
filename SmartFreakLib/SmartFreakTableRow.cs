using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public class SmartFreakTableRow : ISmartFreakTableRow
    {
        public List<ISmartFreakTableColumn> Columns { get; set; }

        public SmartFreakTableRow()
        {
            Columns = new List<ISmartFreakTableColumn>();
        }

    }
}
