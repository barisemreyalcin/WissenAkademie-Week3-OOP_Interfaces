using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelInterface
{
    // interface'ler sealed'ın tam tersi, bu kez instance alamıyorum ve başka bir sınıf türetmek zorundayım
     interface IPerson // Modifier yazmazsam public gibi davranır
    {
        // burada kod bloğu olmaz
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Department { get; set; }
        double Salary { get; set; }
        string GetInfo();

    }
}
