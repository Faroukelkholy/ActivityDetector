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
                
                //n.datas = 

                AllDataEntries.Add(n);
            }
            return AllDataEntries;
        }
    }
}
