using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityDetector
{
    class DataEntry
    {
        public static List<DataEntry> dataEntries = new List<DataEntry>();
        public static List<DataEntry> filtredDatas = new List<DataEntry>();
        public static List<DataEntry> dataEntryFromDB = new List<DataEntry>();

        public DateTime dateTime { get; set; }
        public string activity { get; set; }
        public Dictionary<string, Double> datas { get; set; }
        public Dnary dnary = new Dnary();
     
        public int partition = -1;

        //??
        public DataEntry()
        {
            this.dateTime = DateTime.Now;
            this.activity = "N/C";
            this.datas = new Dictionary<string, double>();
        }



        //new ??
        public DataEntry filterOne(List<String> filter)
        {
            DataEntry dE = new DataEntry();
            dE.dateTime = this.dateTime;
            dE.activity = this.activity;
            for (int i = 0; i < filter.Count; i++)
            {
                String key = filter.ElementAt<string>(i);
                dE.datas.Add(key, this.datas[key]);
            }
            return dE ;
        }

        public static int addEntryToList(DataEntry dataEntry)
        {
            dataEntries.Add(dataEntry);
            return dataEntries.Count();
        }

        public  static void saveAll()
        {
            DataBaseAdd add = new DataBaseAdd();

            foreach (DataEntry de in dataEntries)
            {
                add.saveDataEntry(de);
            }
        }

        public  static void loadAll()
        {
            DataBaseFetch fetch = new DataBaseFetch();
            List<DataEntry> dataEntry = fetch.getListAllDataEntries();
        }

        public static void filterAndPreprossDatas(List<String> filter)
        {
            filtredDatas.Clear();
            for (int i = 0; i < dataEntries.Count(); i++)
            {
                DataEntry dE = dataEntries.ElementAt<DataEntry>(i);
                dE = dE.filterOne(filter);
                filtredDatas.Add(dE);
            }
        }

        public static int getFiltedDataRows()
        {
            return filtredDatas.Count();
        }

        //no iteration ??
        public static int getFiltedDataCols()
        {
            if (filtredDatas.Count() > 0)
            {
                DataEntry dE = filtredDatas.ElementAt<DataEntry>(0);
                return dE.datas.Count();
            }
            else
            {
                return 0;
            }
        }

        public double[] getRawDatas()
        {
            double[] rawDatas = new double[datas.Count];
            for (int i = 0; i < datas.Count; i++)
            {
                rawDatas[i] = datas.ElementAt(i).Value;
            }
            return rawDatas;
        }

        public List<Double> EveryValueDictionaryDataEntry()
        {
            List<Double> values = new List<double>();
            values = datas.Values.ToList();
            
            return values;
        }
       public List<String> EveryKeyDictionaryDataEntry()
        {
            List<String> keys = new List<string>();
            keys = datas.Keys.ToList();
            return keys;
        }
    }
}
