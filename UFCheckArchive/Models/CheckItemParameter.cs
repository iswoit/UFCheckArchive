using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UFCheckArchive
{
    public class CheckItemParameter
    {
        private string _table;           // 当前表
        private string _dateColumn;      // 列
        private string _actualValue;     // 实际值


        public string Table
        {
            get { return _table; }
        }

        public string DateColumn
        {
            get { return _dateColumn; }
        }

        public string ActualValue
        {
            get { return _actualValue; }
            set { _actualValue = value; }
        }



        public CheckItemParameter(string table, string column)
        {
            _table = table;
            _dateColumn = column;
            _actualValue = string.Empty;
        }
    }
}
