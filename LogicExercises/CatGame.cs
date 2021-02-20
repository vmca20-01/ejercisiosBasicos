using System;
using System.Collections.Generic;
using System.Text;

namespace ejercisiosBasicos
{
    public class CatGame
    {
        private const int CONT_SUCCES = 3;
        private const int CONT_MAX_ATTEMPS = 9;

        public CatGame() { }

        public char[,] ResetMatriz()
        {
            char[,] pMatriz = { { '#', '#', '#' }, { '#', '#', '#' }, { '#', '#', '#' } };

            return pMatriz;
        }

        public bool MarkMatriz(char marca, string pPosition, char[,] pMatrizA)
        {
            int x = 0, y = 0;
            bool answer = false;

            if (pPosition.Length == 2)
            {
                x = Convert.ToInt16(pPosition.Substring(0, 1));
                y = Convert.ToInt16(pPosition.Substring(1, 1));

                if ((x <= pMatrizA.GetLength(0)) && (y <= pMatrizA.GetLength(1)))
                {
                    if ((pMatrizA[x, y] == 'O') || (pMatrizA[x, y] == 'X'))
                    {
                        throw new Exception("La posicion digitada ya ha sido seleccionada");
                    }
                    else if ((!marca.Equals('X')) && (!marca.Equals('O')))
                    {
                        throw new ArgumentException("Solo puede digitar el caracter 'X' o 'O'");
                    }
                    else
                    {
                        pMatrizA[x, y] = marca;
                        answer = true;
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException("La posicion digitada es inexistente");
                }
            }
            else
            {
                throw new ArgumentException("La posicion digitada no es valida");
            }
            return answer;
        }

        public bool CheckGame(char[,] pMatrizA, out EnumResultGame pResult)
        {
            bool GameEnded = false;
            int succesCountVerticalP1 = 0, succesCountHorizontalP1 = 0, succesCountDiagP1 = 0, succesCountDiagIP1 = 0,
                succesCountVerticalP2 = 0, succesCountHorizontalP2 = 0, succesCountDiagP2 = 0,
                succesCountDiagIP2 = 0, posInv = 0, contTotal = 0;
            char positTempVertical = ' ', positTempHorizotal = ' ', positTempDiagonal = ' ', positTempDiaglI = ' ';

            pResult = EnumResultGame.Neutral;

            for (int i = 0; i < pMatrizA.GetLength(0); i++)
            {
                posInv = pMatrizA.GetLength(1);

                if (!GameEnded)
                {
                    if (contTotal != CONT_MAX_ATTEMPS)
                    {
                        succesCountVerticalP1 = 0;
                        succesCountHorizontalP1 = 0;
                        succesCountDiagP1 = 0;
                        succesCountDiagIP1 = 0;

                        succesCountVerticalP2 = 0;
                        succesCountHorizontalP2 = 0;
                        succesCountDiagP2 = 0;
                        succesCountDiagIP2 = 0;

                        for (int j = 0; j < pMatrizA.GetLength(1); j++)
                        {
                            posInv -= 1;

                            positTempVertical = pMatrizA[i, j];

                            positTempHorizotal = pMatrizA[j, i];

                            positTempDiagonal = pMatrizA[j, j];

                            positTempDiaglI = pMatrizA[posInv, j];


                            if ((positTempVertical == 'X'))
                            {
                                succesCountVerticalP1++;
                            }
                            if ((positTempHorizotal == 'X'))
                            {
                                succesCountHorizontalP1++;
                            }
                            if ((positTempDiagonal == 'X'))
                            {
                                succesCountDiagP1++;
                            }
                            if ((positTempDiaglI == 'X'))
                            {
                                succesCountDiagIP1++;
                            }

                            if ((positTempVertical == 'O'))
                            {
                                succesCountVerticalP2++;
                            }
                            if ((positTempHorizotal == 'O'))
                            {
                                succesCountHorizontalP2++;
                            }
                            if ((positTempDiagonal == 'O'))
                            {
                                succesCountDiagP2++;
                            }
                            if ((positTempDiaglI == 'O'))
                            {
                                succesCountDiagIP2++;
                            }

                            if (succesCountVerticalP1 == CONT_SUCCES)
                            {
                                GameEnded = true;
                                pResult = EnumResultGame.Player1Wins;
                            }
                            if (succesCountHorizontalP1 == CONT_SUCCES)
                            {
                                GameEnded = true;
                                pResult = EnumResultGame.Player1Wins;
                            }

                            if (succesCountDiagP1 == CONT_SUCCES)
                            {
                                GameEnded = true;
                                pResult = EnumResultGame.Player1Wins;
                                break;
                            }

                            if (succesCountDiagIP1 == CONT_SUCCES)
                            {
                                GameEnded = true;
                                pResult = EnumResultGame.Player1Wins;
                                break;
                            }

                            if (succesCountVerticalP2 == CONT_SUCCES)
                            {
                                GameEnded = true;
                                pResult = EnumResultGame.Player2Wins;
                                break;
                            }

                            if (succesCountHorizontalP2 == CONT_SUCCES)
                            {
                                GameEnded = true;
                                pResult = EnumResultGame.Player2Wins;
                                break;
                            }

                            if (succesCountDiagP2 == CONT_SUCCES)
                            {
                                GameEnded = true;
                                pResult = EnumResultGame.Player2Wins;
                                break;
                            }

                            if (succesCountDiagIP2 == CONT_SUCCES)
                            {
                                GameEnded = true;
                                pResult = EnumResultGame.Player2Wins;
                                break;
                            }

                            if (pMatrizA[i, j] != '#')
                            {
                                contTotal++;
                            }

                            if (contTotal == CONT_MAX_ATTEMPS)
                            {
                                GameEnded = true;
                                pResult = EnumResultGame.ImpossibleGame;
                                break;
                            }
                        }
                    }
                }
            }

            return GameEnded;
        }

        public void SelectPlayer(string pJugador, char pMark, out bool pEndGame, char[,] pMatriz)
        {
            EnumResultGame result = EnumResultGame.ImpossibleGame;
            Console.WriteLine();
            Console.WriteLine(pJugador);
            //Console.WriteLine("Digite la posicion que quiere marcar :");

            while (!MarkMatriz(pMark, Console.ReadLine(), pMatriz))
            {
                //Console.WriteLine();
                //Console.WriteLine("Vuelva a intentarlo,digite la posicion que quiere marcar :");
            }
            pEndGame = CheckGame(pMatriz, out result);
            Console.WriteLine();
            Program.ShowMatrizChar(pMatriz);
            Console.WriteLine();

            if (pEndGame)
            {
                if (result != EnumResultGame.ImpossibleGame)
                {
                    //Console.WriteLine("El juego ha terminado,el {0} ha ganado!!", pJugador);
                }
                else if (result == EnumResultGame.ImpossibleGame)
                {
                    //Console.WriteLine("Es imposible continuar con el juego");
                }
            }
        }
    }
}
