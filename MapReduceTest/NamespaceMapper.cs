using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MapReduceTest
{
    //Mapper
    public class NamespaceMapper : MapperBase
    {
        //Override the map method. 
        public override void Map(string inputLine, MapperContext context)
        {
            //Extract the namespace declarations in the Csharp files 
            var reg = new Regex(@"(using)\s[A-za-z0-9_\.]*\;");
            var matches = reg.Matches(inputLine); foreach (Match match in matches)
            {
                //Just emit the namespaces. 
                context.EmitKeyValue(match.Value, "1");
            }
        }
    }

    //See more at: http://www.amazedsaint.com/2013/03/taming-big-data-with-c-using-hadoop-on.html#sthash.m8JpapQl.dpuf
}
