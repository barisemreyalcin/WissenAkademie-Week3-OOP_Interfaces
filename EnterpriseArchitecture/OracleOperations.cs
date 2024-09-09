using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseArchitecture
{
    public class OracleOperations : IDbOperations
    {
        public void Delete()
        {
            Console.WriteLine("Oracle Server ==> Delete Operation");
        }

        public void Insert()
        {
            Console.WriteLine("Oracle Server ==> Insert Operation");
        }

        public void Read()
        {
            Console.WriteLine("Oracle Server ==> Read Operation");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Server ==> Update Operation");
        }
    }
}
