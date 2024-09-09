using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseArchitecture
{
    public interface IDbOperations
    {
        // Bunları her database'de yapabilirim
        void Insert();
        void Update();
        void Delete();
        void Read();
    }
}
