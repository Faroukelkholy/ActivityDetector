using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ActivityDetector
{
    [Table]
    public class DictionaryTable
    {

        [Column(IsPrimaryKey = true)]
        public string DataKey
        {
            get;
            set;
        }
        [Column]
        public Double value
        {
            get;
            set;
        }
        [Column]
        public DateTime date
        {
            get;
            set;

        }

    }
}
