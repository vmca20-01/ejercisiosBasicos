using System;

namespace ejercisiosBasicos
{
    public static class SortArrayUtility
    {
        public static int[] QuickSort(int[] pArray)
        {
            int tempI = 0, tempJ = 0, pivot = 0, elementPivot = 0, i = 0, j = 0;
            double p = 0;
            bool applyExI = false, applyExJ = false;

            j = pArray.Length - 1;

            p = ((pArray.Length - 1) / 2);

            pivot = (int)Math.Round(p);

            elementPivot = pArray[pivot];


            int temp1 = 0;
            int temp2 = 0;

            for (int x = 1; x <= pArray.Length - 1; x++)
            {
                temp1 = pArray[x - 1];

                temp2 = pArray[x];


                if (pArray[x - 1] > pArray[x])
                {
                    for (i = x; i <= j; i++)//SE RECORREN AMBOS EXTREMOS,HASTA COLISIONAR EN LA POSICION PIVOT
                    {
                        if (!(pArray[i - 1] < elementPivot))
                        {
                            tempI = pArray[i - 1];
                            applyExI = true;
                            i--;
                        }
                        else
                        {
                            applyExI = false;
                        }

                        if (j >= pivot)
                        {
                            if (!(pArray[j] > elementPivot))
                            {
                                tempJ = pArray[j];
                                applyExJ = true;
                            }
                            else
                            {
                                applyExJ = false;
                                j--;
                            }
                        }

                        if ((applyExI == true) && (applyExJ == true))
                        {
                            pArray[j] = tempI;
                            pArray[i] = tempJ;
                        }
                    }

                    x--;//REINICIO EL PRIMER CICLO

                    p = (pivot / 2);

                    pivot = (int)Math.Round(p);

                    elementPivot = pArray[pivot];
                }
            }

            return pArray;
        }

        public static double SumValArray(int[] pArray)
        {
            double sum = 0;

            for (int i = 0; i <= pArray.Length - 1; i++)
            {
                sum += pArray[i];
            }

            return sum;
        }
    }
}
