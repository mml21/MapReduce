using Microsoft.Hadoop.Hive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapReduceTest
{
    //Our concrete hive connection 
    public class SampleHiveConnection : HiveConnection
    {
        public SampleHiveConnection(Uri hostName, string port) :
            base(hostName, port, null, null) { }

        public SampleHiveConnection(Uri hostName, string port, string username, string password)
            : base(hostName, port, username, password) { }

        public HiveTable DeviceInfoTable
        {
            get { return this.GetTable<DeviceInfo>("hivesampletable"); }
        }
    }

    //A typed row. Property names based on field names hivesampletable 
    public class DeviceInfo : HiveRow
    {
        public string DevicePlatform { get; set; }
        public string DeviceMake { get; set; }
        public int ClientId { get; set; }
    }
    // See more at: http://www.amazedsaint.com/2013/02/a-quick-introduction-to-hadoop-hive-on.html#sthash.cmKBYyPD.dpuf
}
