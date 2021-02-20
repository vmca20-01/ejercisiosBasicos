using System;

namespace ejercisiosBasicos
{
    public static class GenericArrayUtility<T>
    {
        public static T[] FindNumLastNumber(T pLastDigit, T[] pArray)
        {
            T[] arrayElementsFound = null;
            int cont = 0;
            string numberDigit = string.Empty;

            for (int i = 0; i < pArray.Length; i++)
            {
                numberDigit = pArray[i].ToString();

                if (numberDigit.Substring(numberDigit.Length - 1) == pLastDigit.ToString())
                {
                    cont++;
                }
            }

            if (cont > 0)
            {
                arrayElementsFound = new T[cont];
                cont = 0;

                for (int i = 0; i < pArray.Length; i++)
                {
                    numberDigit = pArray[i].ToString();

                    if (numberDigit.Substring(numberDigit.Length - 1) == pLastDigit.ToString())
                    {
                        arrayElementsFound[cont] = pArray[i];
                        cont++;
                    }
                }
            }
            return arrayElementsFound;
        }

        public static bool findRepeatElement(T[,] pMatrix, T pElement)
        {
            bool findElement = false;

            for (int ik = 0; ik < pMatrix.GetLength(0); ik++)
            {
                for (int jk = 0; jk < pMatrix.GetLength(1); jk++)
                {
                    if (pMatrix[ik, jk].Equals(pElement))
                    {
                        findElement = true;
                        break;
                    }
                }

                if (findElement)
                {
                    break;
                }
            }

            return findElement;
        }

        public static bool CompareArrays(T[] pArray1, T[] pArray2)
        {
            bool equalArray = true;

            if (pArray1.Length == pArray2.Length)
            {
                for (int i = 0; i <= pArray1.Length - 1; i++)
                {
                    if (!pArray1[i].Equals(pArray2[i]))
                    {
                        equalArray = false;
                        break;
                    }
                }
            }
            else
            {
                equalArray = false;
            }

            return equalArray;
        }

        public static T[] InvertArray(T[] pArrayNum)
        {
            T[] arrayNumInvert = new T[pArrayNum.Length];
            int cont = 0;

            for (int i = pArrayNum.Length - 1; i >= 0; i--)
            {
                arrayNumInvert[cont] = pArrayNum[i];
                cont++;
            }

            return arrayNumInvert;
        }
    }
}
