using System;
using System.Collections.Generic;
using System.Text;

namespace Secao4Ex1
{
    class Matematica
    {
        public static int Exponenciacao(int num1, int num2)
        {
            int result = num1;

            if (num2 == 0)
            {
                result = 1;
            }

            for (int i = 1; i < num2; i++)
            {
                result *= num1;
            }

            return result;
        }
    }
}
