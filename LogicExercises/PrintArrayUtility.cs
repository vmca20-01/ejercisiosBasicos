using System;

namespace ejercisiosBasicos
{
    public static class PrintArrayUtility
    {
        public static int[] RandomNumbers(int pNumElementos)
        {
            int[] arrayNum, arrayNumPrim = new int[] { 2, 3, 5, 7, 11 };
            Boolean flag = false;
            int numRam = 0, divider = 0;
            double quotient = 0;
            Random rand = new Random();
            arrayNum = new int[pNumElementos];

            for (int i = 0; i <= arrayNum.Length - 1; i++)
            {
                flag = false;
                numRam = rand.Next(2, 100);

                for (int j = 0; j <= arrayNumPrim.Length - 1; j++)
                {
                    divider = arrayNumPrim[j];

                    quotient = (numRam % divider);

                    if ((quotient != 0))
                    {
                        if ((quotient < divider))
                        {
                            flag = true;
                        }
                    }
                    else if (quotient == 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag == true)
                {
                    arrayNum[i] = numRam;
                }
                else if (flag == false)
                {
                    i--;
                }
            }

            return arrayNum;
        }

        public static string PrintPhrase(string pFrase)
        {
            char[] arrayCaracteres;
            string data = string.Empty;

            if (!string.IsNullOrEmpty(pFrase))
            {
                arrayCaracteres = new char[pFrase.Length];

                for (int i = 0; i <= arrayCaracteres.Length - 1; i++)
                {
                    arrayCaracteres[i] = pFrase[i];

                    data += string.Format("\nPosicion {0} Elmento => {1}", i, arrayCaracteres[i]);
                }
            }
            else
            {
                data = "Es obligatorio digitar una frase";
            }
            return data;
        }

        public static int[] FindMultipleElements(int[] pArray, int pMultiple)
        {
            int cont = 0;
            int[] ArrayNumb = null;

            for (int i = 0; i < pArray.Length; i++)
            {
                if (pArray[i] % pMultiple == 0)
                {
                    cont++;
                }
            }

            ArrayNumb = new int[cont];

            int j = 0;
            int k = 0;

            while (k < pArray.Length)
            {
                if (pArray[k] % pMultiple == 0)
                {
                    ArrayNumb[j] = pArray[k];
                    j++;
                }

                k++;
            }

            return ArrayNumb;
        }

        public static int GetMaxValueArray(int[] pArray)
        {
            int maxVal = 0;

            for (int i = 0; i < pArray.Length; i++)
            {
                if (maxVal <= pArray[i])
                {
                    maxVal = pArray[i];
                }
            }

            return maxVal;
        }

        public static int GetMinValueArray(int[] pArray)
        {
            int minVal = pArray[0];

            for (int i = 1; i < pArray.Length; i++)
            {
                if (minVal >= pArray[i])
                {
                    minVal = pArray[i];
                }
            }

            return minVal;
        }

        public static int RollDice()
        {
            Random rnd = new Random();

            return rnd.Next(1, 6);
        }

        public static int[,] sumTriangInfSup(int[,] pMatriz)
        {
            int[,] sumMatriz = pMatriz;

            for (int i = 0; i < pMatriz.GetLength(1); i++)
            {
                for (int j = 1; j <= pMatriz.GetLength(0) - 1; j++)
                {
                    sumMatriz[j, i] = sumMatriz[j, i] + sumMatriz[i, j];

                    for (int x = 0; x <= i; x++)
                    {
                        sumMatriz[x, i] = 0;
                    }
                }
            }

            return sumMatriz;
        }

        public static int[,] showMatrizTranspuesta(int[,] pMatriz)
        {
            int[,] matrizTranspuesta = new int[pMatriz.GetLength(1), pMatriz.GetLength(0)];

            for (int i = 0; i < matrizTranspuesta.GetLength(0); i++)
            {
                for (int j = 0; j < matrizTranspuesta.GetLength(1); j++)
                {
                    matrizTranspuesta[i, j] = pMatriz[j, i];
                }
            }
            return matrizTranspuesta;
        }

        public static int[,] rowSumMatriz(int[,] pMatriz)
        {
            int firstElementRow = 0, sumRow = 0, minValueRow = 0, resultValues = 2;

            int[,] rowValResults = new int[pMatriz.GetLength(0), resultValues];//SAVES THE ROW'S RESULTS

            for (int i = 0; i < pMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < pMatriz.GetLength(1); j++)
                {
                    sumRow += pMatriz[i, j];

                    if (j == 0)
                    {
                        if (i == firstElementRow)
                        {
                            minValueRow = pMatriz[i, j];
                        }
                    }
                    if (minValueRow >= pMatriz[i, j])
                    {
                        minValueRow = pMatriz[i, j];
                    }
                }

                rowValResults[i, resultValues - 1] = minValueRow;
                rowValResults[i, resultValues - 2] = sumRow;
                sumRow = 0;
                firstElementRow++;
            }

            return rowValResults;
        }

        public static int[,] colSumMatriz(int[,] pMatriz)
        {
            int firstElementCol = 0, sumCol = 0, maxValueCol = 0, resultValues = 2;

            int[,] colValResults = new int[pMatriz.GetLength(1), resultValues];//SAVES THE COLUMN'S RESULTS

            for (int i = 0; i < pMatriz.GetLength(1); i++)
            {
                for (int j = 0; j < pMatriz.GetLength(0); j++)
                {
                    sumCol += pMatriz[j, i];

                    if (maxValueCol <= pMatriz[j, i])
                    {
                        maxValueCol = pMatriz[j, i];
                    }
                }
                colValResults[i, resultValues - 1] = maxValueCol;
                colValResults[i, resultValues - 2] = sumCol;
                sumCol = 0;
                maxValueCol = 0;
                firstElementCol++;
            }

            return colValResults;
        }

        public static int maxValueMatriz(int[,] pMatriz, out int pRowFound, out int pColFound)
        {
            int maxValueGlobal = 0;
            pRowFound = 0;
            pColFound = 0;

            for (int i = 0; i < pMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < pMatriz.GetLength(1); j++)
                {
                    if (pMatriz[i, j] >= maxValueGlobal)
                    {
                        maxValueGlobal = pMatriz[i, j];
                        pRowFound = i;
                        pColFound = j;
                    }
                }
            }
            return maxValueGlobal;
        }

        public static int[,] showMatrizSum(int[,] pMatriz1, int[,] pMatriz2)
        {
            int[,] matrizSum = new int[pMatriz1.GetLength(0), pMatriz1.GetLength(1)];

            for (int i = 0; i < matrizSum.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSum.GetLength(1); j++)
                {
                    matrizSum[i, j] = pMatriz1[i, j] + pMatriz2[i, j];
                }
            }

            return matrizSum;
        }

        public static int sumRow(int[,] pMatriz, int pRow)
        {
            int sumRow = 0;

            if (pRow < (pMatriz.GetLength(1)))
            {
                for (int i = 0; i < pMatriz.GetLength(1); i++)
                {
                    sumRow += pMatriz[pRow, i];
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("La fila digitada no existe,debe seleccionar una fila existente!!");
            }

            return sumRow;
        }

        public static int sumCol(int[,] pMatriz, int pColum)
        {
            int sumCol = 0;

            if (pColum < (pMatriz.GetLength(0)))
            {
                for (int j = 0; j < pMatriz.GetLength(0); j++)
                {
                    sumCol += pMatriz[j, pColum];
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("La fila digitada no existe,debe seleccionar una columna existente!!");
            }

            return sumCol;
        }

        //#METODOS PARA SUMAR LA DIAGONAL INVERSA DE UNA MATRIZ
        //VERSION A
        public static int sumDiagonalInversaA(int[,] pMatriz)
        {
            int sumDiagonalInversa = 0, k = pMatriz.GetLength(0) - 1;

            for (int i = 0; i < pMatriz.GetLength(0); i++)
            {
                for (int j = pMatriz.GetLength(1); j >= 0; j--)
                {
                    if (k == j)
                    {
                        sumDiagonalInversa += pMatriz[i, j];
                    }
                }
                k--;
            }

            return sumDiagonalInversa;
        }

        //VERSION B
        public static int sumDiagonalInversaB(int[,] pMatriz)
        {
            int sumDiagonalInversa = 0, j = 0;

            for (int i = pMatriz.GetLength(0) - 1; i >= 0; i--)
            {
                sumDiagonalInversa += pMatriz[i, j++];
            }

            return sumDiagonalInversa;
        }

        //VERSION C
        public static int sumDiagonalInversaC(int[,] pMatriz)
        {
            int sumDiagonalInversa = 0, i = 0;

            for (int j = pMatriz.GetLength(1) - 1; j >= 0; j--)
            {
                pMatriz[i++, j] = 1;
            }

            return sumDiagonalInversa;
        }

        //VERSION D(SIN CICLO FOR)
        public static int sumDiagonalInversaD(int[,] pMatriz)
        {
            int sumDiagonalInversa = 0, j = pMatriz.GetLength(1) - 1, i = 0;

            while (j >= 0)
            {
                sumDiagonalInversa += pMatriz[i++, j--];
            }
            return sumDiagonalInversa;
        }

        public static int sumDiagonal(int[,] pMatriz)
        {
            int sumDiagonal = 0;

            for (int i = 0; i < pMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < pMatriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sumDiagonal += pMatriz[i, j];
                    }
                }
            }
            return sumDiagonal;
        }
        //#METODOS PARA SUMAR LA DIAGONAL INVERSA DE UNA MATRIZ

        //MOVE TO A GENERIC CLASS
        public static double matrizAverage(int[,] pMatriz)
        {
            int cantElements = pMatriz.GetLength(0) * pMatriz.GetLength(1), sumElements = 0;
            double average = 0;

            for (int i = 0; i < pMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < pMatriz.GetLength(1); j++)
                {
                    sumElements += pMatriz[i, j];
                }
            }

            average = (sumElements / cantElements);

            return average;
        }
    }
}
