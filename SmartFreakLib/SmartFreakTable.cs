using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public class SmartFreakTable : ISmartFreakTable
    {
        public string Name { get; set; }
        public List<ISmartFreakTableField> Fields { get; set; }

        public SmartFreakTable()
        {
            Fields = new List<ISmartFreakTableField>();
        }

        public List<ISmartFreakTableRow> GetAll()
        {

            return new List<ISmartFreakTableRow>();
        }

        public List<ISmartFreakTableRow> GetByFilter(List<ISmartFreakFilter> filter)
        {
            return new List<ISmartFreakTableRow>();
        }

        public ISmartFreakTableRow GetById(int id)
        {
            return new SmartFreakTableRow();
        }

        public Exception Update(ISmartFreakTableRow row)
        {
            return null;
        }

    }
}
