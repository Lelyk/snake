using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figura
    {
        protected List<Point> pList; //что бы пЛист была видна у наследников

        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Drow();
            }               
        }
    }
}
