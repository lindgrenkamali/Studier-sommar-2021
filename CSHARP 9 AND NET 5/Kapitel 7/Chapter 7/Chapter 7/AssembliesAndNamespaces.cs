using DialectSoftware.Collections;
using DialectSoftware.Collections.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter_7
{
    class AssembliesAndNamespaces
    {
        public static void Main()
        {
            var doc = new XDocument();
            Types();
            AxisAndMatris();
        }

        public static void AxisAndMatris()
        {
            var x = new Axis("x", 0, 13, 1);
            var y = new Axis("y", 0, 2, 1);

            var matrix = new Matrix<long>(new[] { x, y });

            for (int i = 0; i < matrix.Axes[0].Points.Length; i++)
            {
                matrix.Axes[0].Points[i].Label = "x" + i.ToString();
            }

            for (int i = 0; i < matrix.Axes[1].Points.Length; i++)
            {
                matrix.Axes[1].Points[i].Label = "y" + i.ToString();
            }

            foreach (long[] k in matrix)
            {
                matrix[k] = k[0] + k[1];
            }

            foreach (long[] k in matrix)
            {
                Console.WriteLine($"{matrix.Axes[0].Points[k[0]].Label}, {matrix.Axes[1].Points[k[1]].Label} ({k[0]}, {k[1]}) = {matrix[k]}");
            }

        }

        public static void Types()
        {
            string s1 = "Hello";
            String s2 = "World";
            Console.WriteLine($"{s1} {s2}");
        }


    }
}
