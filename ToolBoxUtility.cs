using System;

namespace ejercisiosBasicos
{
    public static class ToolBoxUtility
    {
        public static bool ValidateIntegerField(string pValue, out int pValOut)
        {
            bool validate = false;

            if (int.TryParse(pValue, out pValOut))
            {
                validate = true;
            }

            return validate;
        }

        public static bool ValidateIntegerField(string pValue)
        {
            bool validate = false;

            if (int.TryParse(pValue, out int result))
            {
                validate = true;
            }

            return validate;
        }

        public static bool ValidateDouble(string pValue)
        {
            bool validate = false;

            if (double.TryParse(pValue, out double result))
            {
                validate = true;
            }

            return validate;
        }

        public static bool ValidatePositiveNum(int pNum)
        {
            bool valid = false;

            if (pNum >= 0)
            {
                valid = true;
            }
            else if (pNum < 0)
            {
                valid = false;
            }

            return valid;
        }

        public static bool OddNumbsFilter(int pNumber, EnumResultNumber pSubFilterNumber = EnumResultNumber.All)
        {
            bool result = false;

            switch (pSubFilterNumber)
            {
                case EnumResultNumber.Even:

                    if (pNumber % 2 == 0)
                    {
                        result = true;
                    }
                    break;

                case EnumResultNumber.Odd:

                    if (pNumber % 2 != 0)
                    {
                        result = true;
                    }
                    break;

                case EnumResultNumber.All:

                    result = true;

                    break;

                case EnumResultNumber.Prime:

                    result = PrimeNumbFilter(pNumber, pSubFilterNumber);

                    break;
            }

            return result;
        }

        public static bool PrimeNumbFilter(int pNumber, EnumResultNumber pSubFilterNumber)
        {
            bool result = false;

            switch (pSubFilterNumber)
            {
                case EnumResultNumber.Prime:

                    if ((pNumber % pNumber == 0) && (pNumber % 1 == 0))
                    {
                        result = true;
                    }

                    break;
            }

            return result;
        }

        public static int CountLetter(string pFrase, char pLetraBuscar)
        {
            string letra = string.Empty;
            int cont = 0;

            if (!string.IsNullOrEmpty(pFrase))
            {
                if (!string.IsNullOrEmpty(pLetraBuscar.ToString()))
                {
                    for (int i = 0; i <= pFrase.Length - 1; i++)
                    {
                        letra = pFrase.Substring(i, 1).ToString();

                        if (letra.ToUpper() == pLetraBuscar.ToString().ToUpper())
                        {
                            cont++;
                        }
                    }
                }
            }

            return cont;
        }

        public static int CountSentence(string pSentence)
        {
            string answer = string.Empty;
            int cont = 0;

            do
            {
                if (!string.IsNullOrEmpty(pSentence))
                {
                    cont += 1;
                }
                else
                {
                    //Console.WriteLine("No puede introducir espacios en blanco");
                }

                Console.WriteLine("Desea digitar otra frase?(S/N)");
                answer = Console.ReadLine();

                if ((answer.ToUpper() != "S") && (answer.ToUpper() != "N"))
                {
                    //Console.WriteLine();
                    //Console.WriteLine("Las opciones posibles son : S o N");
                    //answer = Console.ReadLine();
                }
                else if (answer.ToUpper() == "S")
                {
                    //Console.WriteLine("Digite otra frase : ");
                    //pSentence = Console.ReadLine();
                }

            } while (answer.ToUpper() == "S");

            return cont;
        }

        public static string PrintColString(string pFrase)
        {
            string concatenacion = string.Empty;

            for (int i = 1; i <= 5; i++)
            {
                concatenacion += String.Format("{0,-10}", pFrase) + string.Empty;
            }
            return concatenacion;
        }


        public static string ContinueLabel(UserContinues pContinueOption)
        {
            string label = string.Empty;

            switch (pContinueOption)
            {
                case UserContinues.SystemCont:

                    label = "Desea seguir con la ejecusion del programa ?(Y/N)";

                    break;

                case UserContinues.InsertCont:

                    label = "Desea crear un nuevo registro ?(Y/N)";

                    break;

                case UserContinues.ShoppingCont:

                    label = "Desea continuar comprando ?(Y/N)";

                    break;

                case UserContinues.ShowInfoCont:

                    label = "Desea volver a consultar la informacion ?(Y/N)";

                    break;
            }

            return label;
        }

        public static string StringMenu(int pCantOpciones)
        {
            string StringMenu = string.Empty;

            for (int i = 1; i <= pCantOpciones; i++)
            {
                StringMenu += string.Format("\n Ejercisio #{0}", i);
            }

            return StringMenu;
        }

        public static bool validateObjectArray(object[] pArrayElements)
        {
            foreach (object instance in pArrayElements)
            {
                if (instance != null)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool validateObjectArray(object[,] pArrayElements)
        {
            foreach (object instance in pArrayElements)
            {
                if (instance != null)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ValidateCharOption(string pOption, char[] pListValidOptions)
        {
            if (!char.TryParse(pOption, out char validOption))
            {
                return false;
            }

            return true;
        }

        public static bool isCapicua(int pNum)
        {
            string numInvert = string.Empty;
            bool capicua = false;

            if (pNum.ToString().Length >= 2)
            {
                for (int i = pNum.ToString().Length - 1; i >= 0; i--)
                {
                    numInvert += pNum.ToString()[i];
                }

                if (numInvert.ToString() == pNum.ToString())
                {
                    capicua = true;
                }
            }
            else
            {
                throw new Exception("El numero debe de tener mas de 2 digitos");
            }

            return capicua;
        }

        public static bool isNotEmpty(Object[] pArray)
        {
            bool isEmpty = true;

            for (int i = 0; i < pArray.Length; i++)
            {
                if (pArray[i] != null)
                {
                    isEmpty = false;

                    break;
                }
            }

            return isEmpty;
        }

        public static bool isNotEmpty(Object[,] pArray)
        {
            bool isEmpty = false;

            for (int i = 0; i < pArray.GetLength(0); i++)
            {
                for (int j = 0; j < pArray.GetLength(0); j++)
                {
                    if (pArray[i, j] != null)
                    {
                        isEmpty = true;

                        break;
                    }
                }
            }

            return isEmpty;
        }
    }
}
