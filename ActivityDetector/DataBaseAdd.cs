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
                for(int i = 0; i < DataEntry.dictionaryList.Count; i++) { 
                //de.Data_entriesID = dataE.DataEntryID;
                de.date_Time = dataE.dateTime;
                de.activity = dataE.activity;
                de.DataKey = DataEntry.dictionaryList.ElementAt<Dnary>(i).DataKey;
                de.DataValue = DataEntry.dictionaryList.ElementAt<Dnary>(i).DataValue;
                //Debug.WriteLine("before insert on sumbit saveDataEntr");
                context.dataEntry.InsertOnSubmit(de);

                }
                
                //Debug.WriteLine("after insert on sumbit saveDataEntr");
                context.SubmitChanges();
                //dataE.DataEntryID++;
            }
        }
            public void saveDictionary(Dnary dnary)
        {

            using (DataBaseContext context = new DataBaseContext(DataBaseContext.DBConnectionString))
            {
                DictionaryTable dT = new DictionaryTable();
                
                dT.DataKey = dnary.DataKey;
                //Debug.WriteLine("Dnary in DataBaseAdd.saveDictionary :"+ dnary.DataKey+","+ dnary.DataValue);
                dT.value = dnary.DataValue;
                dT.dataEntrydate = dnary.datetimeDataEntry;
                dT.activity = dnary.activity;
                
                //Debug.WriteLine("before insert on sumbit saveDictionary ");
                context.dnary.InsertOnSubmit(dT);
                //Debug.WriteLine("after insert on sumbit saveDictionary");
                context.SubmitChanges();
            }
        }
    }
}
