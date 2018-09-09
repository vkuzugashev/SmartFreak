using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public class SmartFreakTableField : ISmartFreakTableField
    {
        public string Name { get; set; }
        public SmartFreakFieldTypes FieldType { get; set; }
        public int MaxSize { get; set; }
        public string Label { get; set; }
        public int OrderNumber { get; set; }
        public string Description { get; set; }
        public string DisplayFormat { get; set; }
        public object Value { get; set; }
        public object OldValue { get; set; }
    }
}
