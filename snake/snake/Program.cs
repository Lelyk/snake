using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отрисовка точек
            Point p2 = new Point(4, 5, '#');
            p2.Drow(); 
            
            //Линии
            HorizontalLine lline = new HorizontalLine(0, 118, 0, '+');
            HorizontalLine rline = new HorizontalLine(0, 118, 29, '+');
            VerticalLine tline = new VerticalLine(0, 0, 29, '+');
            VerticalLine bline = new VerticalLine(118, 0, 29, '+');

            lline.Drow();
            rline.Drow();
            tline.Drow();
            bline.Drow();
            
            Console.ReadKey();
        }
    }
}
