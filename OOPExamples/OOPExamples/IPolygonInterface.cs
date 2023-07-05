using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
   public interface IPolygon
    {

        // method without body
        void calculateArea();
    }

    class Rectangle : IPolygon
    {

        // implementation of methods inside interface
        public void calculateArea(int l, int b)
        {

            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }

        public void calculateArea()
        {
            throw new NotImplementedException();
        }
    }

}
