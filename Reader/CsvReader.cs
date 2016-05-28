using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader
{
    public class CsvReader
    {
        public List<ReaderData> ReaderListData { get; set; }

        public CsvReader()
        {
            ReaderListData = new List<ReaderData>();
            ReaderListData.Add(new ReaderData("Julius Caesar 2", 50));
            ReaderListData.Add(new ReaderData("Pompeius Magnus 2", 56));
            ReaderListData.Add(new ReaderData("Marcus Crassus 2", 65));
        }
    }
}
