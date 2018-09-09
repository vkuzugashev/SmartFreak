using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public interface ISmartFreakTableField
    {
        string Name { get; set; }
        SmartFreakFieldTypes FieldType { get; set; }
        int MaxSize { get; set; }
        int OrderNumber { get; set; }
        string Label { get; set; }
        string Description { get; set; }
        string DisplayFormat { get; set; }
    }
}
