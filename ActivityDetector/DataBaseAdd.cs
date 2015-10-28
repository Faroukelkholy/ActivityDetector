using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityDetector
{
    class DataBaseAdd
    {
        public void saveDataEntry(DataEntry dataE)
        {

            using (DataBaseContext context = new DataBaseContext(DataBaseContext.DBConnectionString))
            {
                Data_Entries de = new Data_Entries();
                Dnary dn = new Dnary();
                de.date_Time = dataE.dateTime;
                de.activity = dataE.activity;
                de.DataKey = dn.DataKey;
                Debug.WriteLine("before insert on sumbit");
                context.dataEntry.InsertOnSubmit(de);
                Debug.WriteLine("after insert on sumbit");
                context.SubmitChanges();
            }
        }
    }
}
