using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ActivityDetector
{
    class DataBaseFetch
    {
        public IList<Data_Entries> GetAllDataEntries()
        {
            IList<Data_Entries> list = null;
            using (DataBaseContext context = new DataBaseContext(DataBaseContext.DBConnectionString))
            {
                
                IQueryable<Data_Entries> query = from c in context.dataEntry select c;
                list = query.ToList();
            }
            return list;
        }

        public List<DataEntry> getListAllDataEntries()
        {
            IList<Data_Entries> dtes = this.GetAllDataEntries();
            List<DataEntry> AllDataEntries = new List<DataEntry>();
            foreach (Data_Entries m in dtes)
            {
                DataEntry n = new DataEntry();
                DateTime date = Convert.ToDateTime(m.date_Time);
                n.dateTime = date;
                n.activity = m.activity;
                n.datas.Add(m.DataKey, m.DataValue);
                
                //n.datas = 

                AllDataEntries.Add(n);
            }
            return AllDataEntries;
        }
        public IList<DictionaryTable> GetAllDictionary()
        {
            IList<DictionaryTable> list = null;
            using (DataBaseContext context = new DataBaseContext(DataBaseContext.DBConnectionString))
            {

                IQueryable<DictionaryTable> query = from c in context.dnary select c;
                list = query.ToList();
            }
            return list;
        }
        public List<Dnary> getListAllDictionary()
        {
            IList<DictionaryTable> dt = this.GetAllDictionary();
            List<Dnary> AllDictionary = new List<Dnary>();
            foreach (DictionaryTable m in dt)
            {
                Dnary dn = new Dnary();
                dn.DataKey = m.DataKey;
                dn.DataValue = m.value;
                DateTime date = Convert.ToDateTime(m.dataEntrydate);
                dn.datetimeDataEntry = date;
                dn.activity = m.activity;
                 
                //n.datas = 

                AllDictionary.Add(dn);
            }
            return AllDictionary;
        }
    }
}
