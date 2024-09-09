using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseArchitecture
{
    public class MsSqlOperations : IDbOperations
    {
        public void Delete()
        {
            Console.WriteLine("MSSQL Server ==> Delete Operation");
        }

        public void Insert()
        {
            Console.WriteLine("MSSQL Server ==> Insert Operation");
        }

        public void Read()
        {
            Console.WriteLine("MSSQL Server ==> Read Operation");
        }

        public void Update()
        {
            Console.WriteLine("MSSQL Server ==> Update Operation");
        }
    }
}
