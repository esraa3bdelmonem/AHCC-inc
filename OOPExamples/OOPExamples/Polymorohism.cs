using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    //Static or Compile Time Polymorphism

    public class TestData
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
