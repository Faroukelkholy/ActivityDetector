using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ActivityDetector
{
   
        public class DataBaseContext : DataContext
        {
            public static string DBConnectionString = @"isostore:/DataEntries9.sdf";
            public DataBaseContext(string connectionString)
        : base(connectionString)
            { }
            public Table<Data_Entries> dataEntry
            {
                get
                {
                    return this.GetTable<Data_Entries>();
                }
            }
        public Table<DictionaryTable> dnary
        {
            get
            {
                return this.GetTable<DictionaryTable>();
            }
        }
    }
}
