using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PacktLibrary.Shared
{
    public static class Squarer
    {
        public static double Square<T>(T input) where T: IConvertible
        {
            //konvertera med den nuvarande kulturen
            double d = input.ToDouble(Thread.CurrentThread.CurrentCulture);

            return d * d;
        }
    }
}
