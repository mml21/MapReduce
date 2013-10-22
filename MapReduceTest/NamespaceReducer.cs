using Microsoft.Hadoop.MapReduce;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MapReduceTest
{
    //Reducer 
    public class NamespaceReducer : ReducerCombinerBase
    {
        //Accepts each key and count the occurrances 
        public override void Reduce(string key, IEnumerable<string> values, ReducerCombinerContext context)
        {
            //Write back 
            context.EmitKeyValue(key, values.Count().ToString());
        }
    }
    // See more at: http://www.amazedsaint.com/2013/03/taming-big-data-with-c-using-hadoop-on.html#sthash.m8JpapQl.dpuf
}
