using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_Demo
{
    //INHERITANCE DEMO 
    public class Toilet_Paper : Product
    {

        public Toilet_Paper() : base()
        {
            name = "Toilet_Paper";
            price = 200;
            quantity = 3;
        }

        public override bool IsAvailable()
        {
            return false;
        }
    }
}
 