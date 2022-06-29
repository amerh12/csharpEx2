using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNaloga3
{
    class Krog
    {
        public double _polmer;
       



        //premer=polmer*2;
        //povrsina = polmer*polmer*pi
        //obseg=2*3.14*premer


        public double Polmer
        {
            get { return _polmer; }
            set { _polmer = value; }
        }


        public double Obseg(double polmer)
        {
            
            double obseg = 2*3.14*(2*polmer);
            return obseg;


        }


    }
}
