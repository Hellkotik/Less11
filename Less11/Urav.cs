using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less11
{
    struct Urav
    {
        double k;
        double b;

        public Urav(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root() 
        {
            double x = b / k;
            if (k == 0 && b == 0)
            {
                return "Корней бесконечно много";
            }
            else if (k == 0 && b != 0)
            { return "Корней нет"; }
            else { return $"Корень х={x}"; }


        }

     


    }
}
