using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapReduceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var hadoop = Hadoop.Connect();
            var result = hadoop.MapReduceJob.ExecuteJob<NamespaceCounterJob>();
            // See more at: http://www.amazedsaint.com/2013/03/taming-big-data-with-c-using-hadoop-on.html#sthash.m8JpapQl.dpuf
        }

        private void RunHiveQuery()
        {
            //Create a hive connection 
            //I've my cluster in https://www.hadooponazure.com 
            var hive = new SampleHiveConnection(new Uri("saintcluster.cloudapp.net"), "", "", "");
            // Make sure you goto the dashboard and turn on the ODBC port 
            var res = from d in hive.DeviceInfoTable where d.ClientId < 100 select d;
            // Dump it to the console if you like 
            var list = res.ToList(); 
            // See more at: http://www.amazedsaint.com/2013/02/a-quick-introduction-to-hadoop-hive-on.html#sthash.cmKBYyPD.dpuf
        }
    }
}
