using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFreakLib
{
    public interface ISmartFreakTable
    {
        string Name { get; set; }
        List<ISmartFreakTableField> Fields { get; set; }
        List<ISmartFreakTableRow> GetAll();
        List<ISmartFreakTableRow> GetByFilter(List<ISmartFreakFilter> filter);
        ISmartFreakTableRow GetById(int id);
        Exception Update(ISmartFreakTableRow row);
    }
}
