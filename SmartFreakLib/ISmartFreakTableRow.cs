using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public interface ISmartFreakTableRow
    {
        List<ISmartFreakTableColumn> Columns { get; set; }
    }
}
