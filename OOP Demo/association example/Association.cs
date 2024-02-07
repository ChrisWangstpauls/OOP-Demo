using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo
{
    public class Association
    {
        public void doSomething(Product obj)
        {
            obj.GetName();
            obj.price = 0;
        }        
    }
}
