using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseArchitecture
{
    public class DbOperationsManager : IDbOperations
    {
        // Dependency Injection - Factory Pattern
        private IDbOperations _dbOperations;
        // Class seviyesinde değişken tanımlayıp data taşımak amaç. Hangi database ile çalışacağım bilgisini kullanmak amaç.
        // Normalde interface'lerde access modifier kullanmıyorum. Ama burada interface'i inheritance olarak değil değişken olarak kullanıyorum. Bu sebeple gidip Interface dosyamda public yaptım.

        public DbOperationsManager(IDbOperations dbOperations) // Constructor
        {
            _dbOperations = dbOperations;
        }

        public void Delete()
        {
            _dbOperations.Delete();
        }

        public void Insert()
        {
            _dbOperations.Insert();
        }

        public void Read()
        {
            _dbOperations.Read();
        }

        public void Update()
        {
            _dbOperations.Update();
        }
    }
}
