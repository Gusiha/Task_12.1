using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12._1
{
    struct MyStruct
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MyStruct()
        {
            Random random1 = new Random();
            X = random1.Next(-10, 10);
            Y = random1.Next(-10, 10);
        }

    }

    struct MyStruct2
    {
        public int X { get; set; }
        public double Y { get; set; }

        public MyStruct2()
        {
            Random random1 = new Random();
            X = random1.Next(-10, 10);
            Y = random1.Next(-10, 10);
        }

    }

    struct MyStruct3
    {
        public double X { get; set; }
        public int Y { get; set; }

        public MyStruct3()
        {
            Random random1 = new Random();
            X = random1.Next(-10, 10);
            Y = random1.Next(-10, 10);
        }

    }


}
