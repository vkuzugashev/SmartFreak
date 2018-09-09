using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public interface ISmartFreakTableColumn
    {
        string Name { get; set; }
        string Label { get; set; }
        int OrderNumber { get; set; }
        string DisplayFormat { get; set; }
        SmartFreakFieldTypes FieldType { get; set; }
        object Value { get; set; }
        object OldValue { get; set; }
    }
}
