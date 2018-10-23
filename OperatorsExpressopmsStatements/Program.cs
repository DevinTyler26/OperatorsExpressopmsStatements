using System;

namespace OperatorsExpressopmsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, b;

            x = 3;
            y = 2;
            a = 1;
            b = 0;

            x = 3 + 4;

            x = 3 - 4;

            x = (x + y) * (a - b);

            if ((x > y) && (a > b))
            {

            }

            if ((x > y) || (a > b))
            {

            }

            string message = (x == 1) ? "car" : "boat";
        }
    }
}
