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

        [Column(IsPrimaryKey = true,IsDbGenerated =true)]
        public int Data_entriesID
        {
            get;
            set;
        }


         [Column ]
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
        public String DataKey {
            get;
            set;
        }
        [Column]
        public double DataValue
        {
            get;
            set;
        }

       // [Column]
         //   public String DataId
       // {
         //       get;
           //     set;

            //}
            

    }
    }
