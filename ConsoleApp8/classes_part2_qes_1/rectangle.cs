using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class rectangle : Irectangile
    {
     

        
        public double Area {
            get; set;
            
        }


        public string shapeinfo()
        {
            return $"i am arectangle with area {Area}";
        }
    }
}
