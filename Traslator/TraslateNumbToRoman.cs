using System;

namespace ejercisiosBasicos
{
    public static class TraslateNumbToRoman
    {
        private static string[] Abecedario = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" },
                                Unidades = new string[] { null, "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" },
                                Decenas = new string[] { null, "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" },
                                Centenas = new string[] { null, "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" },
                                Miles = new string[] { null, "M", "MM", "MMM", "MMMM", "MMMMMM" };

        private static int numResid = 0;
        private static bool contTraslation = true;

        public static string FindPositionABCArray(int pArrayPosition)
        {
            string frase = string.Empty;

            if (pArrayPosition != -1)
            {
                if (pArrayPosition <= (Abecedario.Length - 1))
                {
                    frase = Abecedario[pArrayPosition];
                }
            }

            return frase;
        }

        public static string Traslate(int num)
        {
            string printNum = string.Empty;
            contTraslation = true;
            numResid = num;

            if (ToolBoxUtility.ValidatePositiveNum(numResid))
            {
                do
                {
                    switch (numResid.ToString().Length)
                    {
                        case 1:

                            printNum += numResid.GetUnitRoman();

                            break;
                        case 2:

                            printNum += numResid.GetTenRoman();

                            break;

                        case 3:

                            printNum += numResid.GetHundredRoman();

                            break;

                        case 4:

                            printNum += numResid.GetThousandRoman();

                            break;
                    }

                } while (contTraslation);
            }
            else
            {
                throw new Exception("El numero debe de ser positivo");
            }

            return printNum;
        }

        private static string GetUnitRoman(this int pNum)
        {
            string num = string.Empty;

            if (pNum.ToString().Length == 1)
            {
                contTraslation = false;
                num = Unidades[pNum];
            }
            else
            {
                throw new Exception("La cantidad de digitos debe ser de 1");
            }

            return num;
        }

        private static string GetTenRoman(this int pNum)
        {
            int num = 0;

            if (pNum.ToString().Length == 2)
            {
                num = Convert.ToInt16(pNum.ToString().Substring(0, 1));

                if (pNum.ToString().Substring(1, 1) != "0")
                {
                    numResid = Convert.ToInt16(pNum.ToString().Substring(1, 1));
                }
                else
                {
                    contTraslation = false;
                }
            }
            else
            {
                throw new Exception("La cantidad de digitos debe ser de 2");
            }

            return Decenas[num];
        }

        private static string GetHundredRoman(this int pNum)
        {
            int num = 0;

            if (pNum.ToString().Length == 3)
            {
                num = Convert.ToInt16(pNum.ToString().Substring(0, 1));

                if (pNum.ToString().Substring(1, 2) != "00")
                {
                    numResid = Convert.ToInt16(pNum.ToString().Substring(1, 2));
                }
                else
                {
                    contTraslation = false;
                }
            }
            else
            {
                throw new Exception("La cantidad de digitos debe ser de 3");
            }

            return Centenas[num];
        }

        private static string GetThousandRoman(this int pNum)
        {
            int num = 0;

            if (pNum.ToString().Length <= 5)
            {
                num = Convert.ToInt16(pNum.ToString().Substring(0, 1));

                if (pNum.ToString().Substring(1, 3) != "000")
                {
                    numResid = Convert.ToInt16(pNum.ToString().Substring(1, 3));
                }
                else
                {
                    contTraslation = false;
                }
            }
            else
            {
                throw new Exception("La cantidad de digitos debe ser de 4");
            }

            return Miles[num];
        }
    }
}




