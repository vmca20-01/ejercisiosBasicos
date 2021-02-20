using System;

namespace ejercisiosBasicos
{
    public static class FillArrayUtility
    {
        public static void FillArray(string[] pArray)
        {
            string inputElemento = string.Empty;

            for (int i = 0; i <= pArray.Length - 1; i++)
            {
                Console.WriteLine("Digite la posicion {0} del arreglo", i);
                inputElemento = Console.ReadLine();
                pArray[i] = inputElemento;
            }
        }

        public static int[] FillArray(int pNumA1, int pNumA2, int ArrayLenght = 0, bool random = false, EnumResultNumber pFilterNumber = EnumResultNumber.All)
        {
            int[] mArray = null;
            int ramNumb = 0, i = 0;

            if (pNumA1 < pNumA2)
            {
                if (random)
                {
                    if (ArrayLenght > 0)
                    {
                        Random ram = new Random();

                        mArray = new int[ArrayLenght];

                        while (i < mArray.Length)
                        {
                            ramNumb = ram.Next(pNumA1, pNumA2);

                            if (ToolBoxUtility.OddNumbsFilter(ramNumb, pFilterNumber))
                            {
                                mArray[i] = ramNumb;
                                i++;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Se necesita la longitud del array");
                    }
                }
                else
                {
                    i = pNumA1;
                    int cantElement = 0;

                    while (i <= pNumA2)
                    {
                        if (ToolBoxUtility.OddNumbsFilter(i, pFilterNumber))
                        {
                            cantElement++;
                        }

                        i++;
                    }

                    mArray = new int[cantElement];

                    i = 0;

                    while (pNumA1 <= pNumA2)
                    {
                        if (ToolBoxUtility.OddNumbsFilter(pNumA1, pFilterNumber))
                        {
                            mArray[i] = pNumA1;
                            i++;
                        }
                        pNumA1++;
                    }
                }
            }
            else if (pNumA1 > pNumA2)
            {
                mArray = new int[pNumA1];

                i = 0;

                while (pNumA1 > pNumA2)
                {
                    if (ToolBoxUtility.OddNumbsFilter(pNumA1, pFilterNumber))
                    {
                        mArray[i] = pNumA1;
                        pNumA1 -= 1;
                        i++;
                    }
                }
            }

            return mArray;
        }

        public static int SumArray(int[] pArray)
        {
            int sum = 0;

            for (int i = 0; i < pArray.Length; i++)
            {
                sum += pArray[i];
            }

            return sum;
        }

        public static int[] CreateArrayByUser(int pLenght = 0)
        {
            if (pLenght == 0)
            {
                //Console.WriteLine("Digite la longitud del array");
                pLenght = Convert.ToInt16(Console.ReadLine());
            }

            int[] NewArray = new int[pLenght];
            int valArray = 0;

            for (int i = 0; i < NewArray.Length; i++)
            {
                //Console.WriteLine("Digite el numero para la posicion {0}", i);
                valArray = Convert.ToInt16(Console.ReadLine());
                NewArray[i] = valArray;
            }

            return NewArray;
        }

        public static int[,] CreateMatrizByUser(int pRow = 0, int pCol = 0, bool pRandow = false, int pStart = 0, int pEnd = 0, bool pRepeat = true)
        {
            int[,] matrix = null;
            int k = 0;
            Random rnd = new Random();

            if (pRow == 0)
            {
                Console.WriteLine("Digite el numero de filas");
                pRow = Convert.ToInt16(Console.ReadLine());
            }

            if (pCol == 0)
            {
                Console.WriteLine("Digite el numero de filas");
                pRow = Convert.ToInt16(Console.ReadLine());
            }

            matrix = new int[pRow, pCol];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (!pRandow)
                    {
                        Console.WriteLine("Digite un numero para la fila {0} y columna {1} ", i, j);

                        k = Convert.ToInt16(Console.ReadLine());
                    }
                    else
                    {
                        k = rnd.Next(pStart, pEnd);
                    }

                    if (!pRepeat)
                    {
                        if (!GenericArrayUtility<int>.findRepeatElement(matrix, k))
                        {
                            matrix[i, j] = k;
                        }
                        else
                        {
                            i = 0;
                            j = 0;
                        }
                    }
                    else
                    {
                        matrix[i, j] = k;
                    }
                }
            }

            return matrix;
        }

        //MODIFICAR ESTE METODO
        public static int[,] fillDinaMatriz(int pRow, int pCol)
        {
            int[,] matriz = null;
            int val = 0;
            bool checkVal = false;

            if ((pRow > 0) && (pRow < 10))
            {
                if ((pCol > 0) && (pCol < 10))
                {
                    matriz = new int[pRow, pCol];

                    for (int i = 0; i < pRow; i++)
                    {
                        for (int j = 0; j < pCol; j++)
                        {
                            do
                            {
                                Console.WriteLine();
                                Console.WriteLine("Digite el valor de la fila {0} y de la columna {1}", i, j);

                                checkVal = ToolBoxUtility.ValidateIntegerField(Console.ReadLine(), out val);

                                if (checkVal)
                                {
                                    matriz[i, j] = val;
                                    Program.ShowMatrizNums(matriz);
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("El valor debe de ser de tipo entero");
                                }
                            } while (!checkVal);

                        }
                    }
                }
                else
                {
                    Console.WriteLine("El numero de columnas debe de ser positivo y menor a 10");
                }
            }
            else
            {
                Console.WriteLine("El numero de filas debe de ser positivo y menor a 10");
            }

            return matriz;
        }

    }
}
