using System;
using System.Collections.Generic;
using System.Text;

namespace ejercisiosBasicos
{
    public static class TraslateNumbToWord
    {
        private static string[] Unidades = new string[] { "Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once", "Doce", "Trece", "Catorce", "Quince" },
                                Decenas = new string[] { null, "Dieci", "Veinti", "Treinta", "Cuarenta", "Cincuenta", "Sesenta", "Setenta", "Ochenta", "Noventa" },
                                Centenas = new string[] { null, "Cien", "Docientos", "Trecientos", "Cuatrocientos", "Quinientos", "Seicientos", "Setecientos", "Ochocientos", "Novecientos" };

        private static string Mil = "Mil",
                              NumeroLetras = string.Empty,
                              FormatNumTemp = string.Empty,
                              NumOriginal = string.Empty;

        private static bool ContTraslation = true;

        private static int numResid = 0;


        public static string Traslate(int pNum)
        {
            NumeroLetras = string.Empty;
            numResid = pNum;
            ContTraslation = true;

            if ((numResid >= 0) && (numResid <= 10000))
            {
                do
                {
                    switch (numResid.ToString().Length)
                    {
                        case 1:
                            NumeroLetras += numResid.GetUnit();
                            break;
                        case 2:
                            NumeroLetras += numResid.GetTen();
                            break;
                        case 3:
                            NumeroLetras += numResid.GetHundred();
                            break;
                        case 4:
                        case 5:
                            NumeroLetras += numResid.GetThousand();
                            break;
                    }
                } while (ContTraslation);

                FormatNumTemp = NumeroLetras.ToUpper();

                NumeroLetras = FormatNumTemp.Substring(0, 1).ToString() + NumeroLetras.ToLower().Substring(1, FormatNumTemp.Length - 1);
            }
            else
            {
                throw new ArgumentOutOfRangeException("El numero esta fuera del rango de traduccion");
            }
            return NumeroLetras;
        }

        public static string GetUnit(this int pNum)
        {
            string num = string.Empty;

            if (pNum.ToString().Length == 1)
            {
                ContTraslation = false;
                num = Unidades[pNum];
            }
            else
            {
                throw new Exception("La cantidad de digitos debe ser de 1");
            }

            return num;
        }

        public static string GetTen(this int pNum)
        {
            string tempDecenas = string.Empty;

            if (pNum.ToString().Length <= 2)
            {
                if (pNum <= 15)
                {
                    ContTraslation = false;
                    return Unidades[pNum];
                }
                else if ((pNum >= 16))
                {
                    tempDecenas = Decenas[Convert.ToUInt16(pNum.ToString().Substring(0, 1))];

                    int primDig = Convert.ToUInt16(pNum.ToString().Substring(0, 1));

                    numResid = Convert.ToUInt16(pNum.ToString().Substring(1, 1));

                    ContTraslation = true;

                    if (primDig >= 2)
                    {
                        if ((tempDecenas == "Veinti") && (numResid == 0))
                        {
                            ContTraslation = false;

                            tempDecenas = "Veinte";
                        }
                        else if ((primDig >= 3) && (numResid != 0))
                        {
                            tempDecenas = tempDecenas + " y ";
                        }
                        else if (numResid == 0)
                        {
                            ContTraslation = false;
                        }
                    }
                }
            }
            else
            {
                throw new Exception("La cantidad de digitos debe ser de 1 a 2");
            }

            return tempDecenas;
        }

        public static string GetHundred(this int pNum)
        {
            string tempCentenas = string.Empty;

            if (pNum.ToString().Length == 3)
            {
                tempCentenas = Centenas[Convert.ToUInt16(pNum.ToString().Substring(0, 1))];

                if ((Convert.ToUInt16(pNum.ToString().Substring(1, 2)) > 0) && Centenas[Convert.ToUInt16(pNum.ToString().Substring(0, 1))].ToLower() == "cien")
                {
                    tempCentenas += "to ";
                }

                numResid = Convert.ToUInt16(pNum.ToString().Substring(1, 2));

                if (numResid == 0)
                {
                    ContTraslation = false;
                }
            }
            else
            {
                throw new Exception("La cantidad de digitos debe ser de 3");
            }

            return tempCentenas;
        }

        public static string GetThousand(this int pNum)
        {
            string tempThousand = string.Empty;
            int primNum = 0;

            if (pNum.ToString().Length <= 5)
            {
                primNum = (pNum < 10000) ? Convert.ToUInt16(pNum.ToString().Substring(0, 1)) : Convert.ToUInt16(pNum.ToString().Substring(0, 2));

                numResid = Convert.ToUInt16(pNum.ToString().Substring(1, 3));

                if (numResid == 0)
                {
                    ContTraslation = false;
                }
            }
            else
            {
                throw new Exception("La cantidad de digitos debe ser de 4");
            }

            return tempThousand = (primNum == 1) ? Mil : Unidades[primNum] + Mil;
        }
    }
}