using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Type PastryType = typeof(Pastry);
            Type CandyType = typeof(Candy);
            Reflector.ShowClassInfo(PastryType);
            Reflector.ShowMethods(PastryType);
            Reflector.ShowFieldsAndProperties(PastryType);
            Reflector.ShowInterfaces(PastryType);
            Reflector.ShowMethodsWithParameter(PastryType, "str");
            Reflector.RunMethodWithParamsFromFile(CandyType, "ForLab12");
        }
    }
}
