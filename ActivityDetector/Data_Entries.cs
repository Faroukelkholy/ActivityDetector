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
        public class Data_Entries
        {

 
        [Column (IsPrimaryKey = true)]
        public DateTime date_Time
            {
                get;
                set;
            }
            [Column]
            public string activity
            {
                get;
                set;
            }
            [Column]
            public String DataKey
        {
                get;
                set;

            }

        }
    }
