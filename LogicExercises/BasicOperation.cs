using System;
using System.Collections.Generic;
using System.Text;

namespace ejercisiosBasicos
{
    public static class BasicOperation
    {
        public static double BasicOperationNum(double pNum1, double pNum2, EnumBasicOperation pOperation)
        {
            double result = 0;

            switch (pOperation)
            {
                case EnumBasicOperation.Sum:

                    result = pNum1 + pNum2;
                    break;

                case EnumBasicOperation.Subtraction:

                    result = pNum1 - pNum2;
                    break;

                case EnumBasicOperation.Multiplication:

                    result = pNum1 * pNum2;
                    break;

                case EnumBasicOperation.Division:

                    result = pNum1 / pNum2;
                    break;
            }

            return result;
        }

        public static int GetFactorial(int pNum)
        {
            int fact = 1;

            for (int i = 1; i <= pNum; i++)
            {
                fact *= i;
            }

            return fact;
        }

    }
}

