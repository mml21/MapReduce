using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapReduceTest
{
    //Our Namespace counter job 
    public class NamespaceCounterJob : HadoopJob<NamespaceMapper, NamespaceReducer>
    {
        public override HadoopJobConfiguration Configure(ExecutorContext context)
        {
            var config = new HadoopJobConfiguration(); 
            config.InputPath = "input/CodeFiles"; 
            config.OutputFolder = "output/CodeFiles"; 
            return config;
        }
    }

    // See more at: http://www.amazedsaint.com/2013/03/taming-big-data-with-c-using-hadoop-on.html#sthash.m8JpapQl.dpuf
}
