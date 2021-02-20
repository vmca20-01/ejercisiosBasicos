using System;
using System.Collections.Generic;
using System.Text;

namespace ejercisiosBasicos
{
    //MIGRAR ESTE CODIGO USANDO LISTAS GENERICAS
    public class CandyMachine
    {
        private Candy[,] listCandies;
        private Candy[] shoppingHistory;
        private const int DEFAULT_CANT_CANDY = 5;
        private const int CANT_COL = 4;
        private const int CANT_ROW = 4;
        private static int contHistorial = 0;

        public CandyMachine()
        {
            this.ListCandies = new Candy[CANT_ROW, CANT_COL];
            this.shoppingHistory = new Candy[CANT_ROW];
        }

        public CandyMachine(int pCantRow, int pCantCol)
        {
            this.ListCandies = new Candy[pCantRow, pCantCol];
            this.shoppingHistory = new Candy[pCantRow];
        }

        public Candy[,] ListCandies { get => listCandies; set => listCandies = value; }

        public bool buyCandy(string pCodCandy)
        {
            bool result = false;
            Candy selectCandy = this.GetCandy(pCodCandy, this.ListCandies);

            if (selectCandy != null)
            {
                if (selectCandy.Cant > 0)
                {
                    selectCandy.Cant -= 1;
                    result = true;
                    this.InsertShoppingHistory(selectCandy);
                }
                else
                {
                    throw new IndexOutOfRangeException("La cantidad digitada debe de ser mayor a cero");
                }
            }
            else
            {
                throw new Exception("El codigo digitado no coincide con ningun producto existente en la maquina");
            }

            return result;
        }

        public bool InsertCandy(Candy pCandy)
        {
            bool result = false;
            int x = 0, y = 0;

            if (this.ValidateCodCandy(pCandy.CodCandy))
            {
                if (pCandy.Price > 0)
                {
                    if (pCandy.Cant > 0)
                    {
                        if (this.GetCandy(pCandy.CodCandy, this.ListCandies) == null)
                        {
                            if (pCandy.Cant == 0)
                            {
                                pCandy.Cant = DEFAULT_CANT_CANDY;
                            }

                            x = Convert.ToInt16(pCandy.CodCandy.Substring(0, 1));
                            y = Convert.ToInt16(pCandy.CodCandy.Substring(1, 1));

                            this.ListCandies[x, y] = pCandy;
                            result = true;
                        }
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("La cantidad digitada debe de ser mayor a cero");
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException("El precio digitado debe de ser mayor a cero");
                }
            }
            else
            {
                throw new FormatException("El codigo debe de tener 2 digitos");
            }

            return result;
        }

        public string ShowShoppingHistory()
        {
            string dataResult = string.Empty;

            if ((this.shoppingHistory != null) && (this.shoppingHistory.Length > 0))
            {
                Candy historyCandy = null;
                double total = 0;

                if (ToolBoxUtility.validateObjectArray(this.shoppingHistory))
                {
                    for (int i = 0; i < this.shoppingHistory.Length; i++)
                    {
                        historyCandy = (Candy)this.shoppingHistory[i];

                        if (historyCandy != null)
                        {
                            dataResult += string.Format("\n{0} {1} subtotal : {2} Cantidad: {3} ", historyCandy.CodCandy, historyCandy.Name, historyCandy.Price, historyCandy.Cant);
                            total += historyCandy.Price;
                        }
                    }

                    dataResult += string.Format("\nTOTAL : {0} ", total);
                }
                else
                {
                    dataResult = "No hay informacion disponible";
                }
            }

            return dataResult;
        }

        public Candy[] InsertShoppingHistory(Candy pCandy)
        {
            if ((this.shoppingHistory != null) && (this.shoppingHistory.Length > 0))
            {
                if (ToolBoxUtility.validateObjectArray(this.shoppingHistory))
                {
                    Candy historyCandy = this.GetCandy(pCandy.CodCandy, this.shoppingHistory);

                    if (historyCandy != null)
                    {
                        historyCandy.Cant += 1;
                        historyCandy.Price += pCandy.Price;
                    }
                    else
                    {
                        InsertDataHistory(pCandy);
                    }
                }
                else
                {
                    InsertDataHistory(pCandy);
                }
            }

            return this.shoppingHistory;

            void InsertDataHistory(Candy dataCandy)
            {
                Candy newHistoryCandy = new Candy();
                newHistoryCandy.CodCandy = dataCandy.CodCandy;
                newHistoryCandy.Name = dataCandy.Name;
                newHistoryCandy.Price = dataCandy.Price;
                newHistoryCandy.Cant = 1;
                this.shoppingHistory[contHistorial] = newHistoryCandy;
                contHistorial++;
            }
        }

        public string ShowCandies(Candy[,] pListCandies)
        {
            string dataResult = string.Empty;

            if ((pListCandies != null) && (pListCandies.Length > 0))
            {
                if (ToolBoxUtility.validateObjectArray(pListCandies))
                {
                    Candy cand = null;

                    for (int i = 0; i < pListCandies.GetLength(0); i++)
                    {
                        for (int j = 0; j < pListCandies.GetLength(1); j++)
                        {
                            cand = (Candy)pListCandies[i, j];

                            if (cand != null)
                            {
                                dataResult += string.Format("\n{0} {1} Precio : {2} Cantidad: {3} ", cand.CodCandy, cand.Name, cand.Price, cand.Cant);
                            }
                        }
                    }
                }
                else
                {
                    dataResult = "Actualmente no hay informacion para mostrar";
                }
            }
            else
            {
                dataResult = "Actualmente no hay informacion para mostrar";
            }

            return dataResult;
        }

        public bool Login(string pPassword)
        {
            if (pPassword == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Candy GetCandy(string pCod, Candy[,] pListCandies)
        {
            Candy foundData = null;

            if ((pListCandies != null) && (pListCandies.Length > 0))
            {
                if (ToolBoxUtility.isNotEmpty(pListCandies))
                {
                    foreach (Candy cand in pListCandies)
                    {
                        if (cand != null)
                        {
                            if (cand.CodCandy == pCod)
                            {
                                foundData = cand;
                                break;
                            }
                        }
                    }
                }
            }
            return foundData;
        }

        public Candy GetCandy(string pCod, Candy[] pListCandies)
        {
            Candy foundData = null;

            if ((pListCandies != null) && (pListCandies.Length > 0))
            {
                if (!ToolBoxUtility.isNotEmpty(pListCandies))
                {
                    foreach (Candy cand in pListCandies)
                    {
                        if (cand != null)
                        {
                            if (cand.CodCandy == pCod)
                            {
                                foundData = cand;
                                break;
                            }
                        }
                    }
                }
            }

            return foundData;
        }

        public bool ValidateCodCandy(string pCod)
        {
            if (pCod.Length == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
