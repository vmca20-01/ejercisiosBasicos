using ejercisiosBasicos.Estructuras_de_Datos;
using ejercisiosBasicos.Herencia;
using System;
using System.IO;
using System.Linq;

namespace ejercisiosBasicos
{
    class Program
    {
        //NOTA IMPORTANTE:VOLVER A PROGRAMAR LOS EJERCISIOS MAS DESAFIANTES

        private const int CANT_EXERCISES = 62;
        private static int[] TempArrayNumbs = null;
        private static int[,] TempMatrixNumbs = null;
        private static int Option = 0,
                           SelecOption = 0,
                           Cont = 0,
                           SumNumPares = 0,
                           SumNumImpares = 0,
                           SumTotal = 0,
                           numb = 0,
                           opcion = 0,
                           row = 0,
                           col = 0;

        private static string inputVal_1 = string.Empty,
                              inputVal_2 = string.Empty,
                              CantElements = string.Empty,
                              showData = string.Empty;

        private static Random ram = new Random();

        private static void Main(string[] args)
        {
            string StringHilera = ToolBoxUtility.StringMenu(CANT_EXERCISES);

            do
            {
                Console.WriteLine("------------SELECCIONE UNA DE LAS OPCIONES A EJECUTAR------------");
                Console.WriteLine(StringHilera);

                if (ToolBoxUtility.ValidateIntegerField(Console.ReadLine(), out SelecOption))
                {
                    switch (SelecOption)
                    {
                        case 1:

                            try
                            {
                                do
                                {
                                    ShowArray(FillArrayUtility.FillArray(1, 100));

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 2:
                            try
                            {
                                do
                                {
                                    ShowArray(FillArrayUtility.FillArray(100, 0));

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 3:

                            try
                            {
                                do
                                {
                                    ShowArray(FillArrayUtility.FillArray(0, 100, 100, false, EnumResultNumber.Even));

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 4:

                            try
                            {
                                do
                                {
                                    TempArrayNumbs = FillArrayUtility.FillArray(0, 100, 100);

                                    Console.WriteLine("La suma es {0}", FillArrayUtility.SumArray(TempArrayNumbs));

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 5:

                            try
                            {
                                do
                                {
                                    TempArrayNumbs = FillArrayUtility.FillArray(1, 100, 100, false, EnumResultNumber.Odd);

                                    ShowArray(TempArrayNumbs);

                                    Console.WriteLine();

                                    Console.WriteLine("Existe una cantidad de {0} elementos impares", TempArrayNumbs.Count());

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 6:

                            try
                            {
                                do
                                {
                                    Console.WriteLine("Digite el primer numero");
                                    inputVal_1 = Console.ReadLine();

                                    if (ToolBoxUtility.ValidateIntegerField(inputVal_1))
                                    {
                                        Console.WriteLine("Digite el segundo numero");
                                        inputVal_2 = Console.ReadLine();

                                        if (ToolBoxUtility.ValidateIntegerField(inputVal_2))
                                        {
                                            ShowArray(FillArrayUtility.FillArray(Convert.ToInt16(inputVal_1), Convert.ToInt16(inputVal_2)));
                                        }
                                        else
                                        {
                                            Console.WriteLine("El numero debe de ser de tipo numerico entero");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero debe de ser de tipo numerico entero");
                                    }
                                } while (ContProgram());

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 7:

                            try
                            {
                                do
                                {
                                    Cont = 0;

                                    Console.WriteLine("Digite una frase");
                                    Cont = ToolBoxUtility.CountSentence(Console.ReadLine());

                                    Console.WriteLine("\n La cantidad de frases digitadas fue de : {0}", Cont);

                                } while (ContProgram());

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 8:

                            try
                            {
                                do
                                {
                                    Console.WriteLine("Digite un numero");
                                    inputVal_1 = Console.ReadLine();

                                    if (ToolBoxUtility.ValidateIntegerField(inputVal_1))
                                    {
                                        if (ToolBoxUtility.ValidatePositiveNum(Convert.ToInt16(inputVal_1)))
                                        {
                                            Console.WriteLine("El numero es positivo");
                                        }
                                        else
                                        {
                                            Console.WriteLine("El numero es negativo");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero debe de ser de tipo numerico entero");
                                    }

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 9:

                            try
                            {
                                do
                                {
                                    Console.WriteLine("Digite un numero");
                                    inputVal_1 = Console.ReadLine();

                                    if (ToolBoxUtility.ValidateIntegerField(inputVal_1))
                                    {
                                        if (ToolBoxUtility.OddNumbsFilter(Convert.ToInt16(inputVal_1), EnumResultNumber.Even))
                                        {
                                            Console.WriteLine("El numero es Par");
                                        }
                                        else
                                        {
                                            Console.WriteLine("El numero es Impar");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero debe de ser de tipo numerico entero");
                                    }

                                } while (ContProgram());

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 10:

                            int multiple = 0;

                            try
                            {
                                do
                                {
                                    multiple = 0;

                                    Console.WriteLine("Digite el numero hasta donde se debe terminar la iteracion");
                                    inputVal_2 = Console.ReadLine();

                                    if (ToolBoxUtility.ValidateIntegerField(inputVal_2))
                                    {
                                        Console.WriteLine("Digite el multiplo");

                                        if (ToolBoxUtility.ValidateIntegerField(Console.ReadLine(), out multiple))
                                        {
                                            TempArrayNumbs = FillArrayUtility.FillArray(1, Convert.ToInt16(inputVal_2));

                                            ShowMultipleArray(TempArrayNumbs, multiple);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("El primer numero debe de ser de tipo numerico entero");
                                    }

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 11:

                            try
                            {
                                do
                                {
                                    TempArrayNumbs = FillArrayUtility.FillArray(1, 100, 100, false, EnumResultNumber.Even);
                                    SumNumPares = FillArrayUtility.SumArray(TempArrayNumbs);
                                    Console.WriteLine("La cantidad de numeros pares es {0} y su suma es {1}", TempArrayNumbs.Count(), SumNumPares);

                                    TempArrayNumbs = FillArrayUtility.FillArray(1, 100, 100, false, EnumResultNumber.Odd);
                                    SumNumImpares = FillArrayUtility.SumArray(TempArrayNumbs);
                                    Console.WriteLine("La cantidad de numeros pares es {0} y su suma es {1}", TempArrayNumbs.Count(), SumNumImpares);

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 12:

                            try
                            {
                                TempArrayNumbs = FillArrayUtility.FillArray(1, 100, 100, false, EnumResultNumber.All);

                                int[] arrayMultip2 = PrintArrayUtility.FindMultipleElements(TempArrayNumbs, 2);
                                int[] arrayMultip3 = PrintArrayUtility.FindMultipleElements(TempArrayNumbs, 3);

                                Console.WriteLine("\n {0} son multiplos de 2 ", arrayMultip2.Count());
                                Console.WriteLine("\n {0} son multiplos de 3 ", arrayMultip3.Count());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;

                        case 13:

                            try
                            {
                                float minVal = 0, maxVal = 0;

                                do
                                {
                                    TempArrayNumbs = FillArrayUtility.CreateArrayByUser(5);

                                    minVal = PrintArrayUtility.GetMinValueArray(TempArrayNumbs);

                                    maxVal = PrintArrayUtility.GetMaxValueArray(TempArrayNumbs);

                                    Console.WriteLine("El valor minimo dentro del array es de {0} y el maximo valor es {1}", minVal, maxVal);

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 14:

                            try
                            {
                                TempArrayNumbs = FillArrayUtility.FillArray(1, 10, 10, false, EnumResultNumber.All);

                                for (int i = 0; i < 10; i++)
                                {
                                    ShowArray(TempArrayNumbs);
                                    Console.WriteLine();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;

                        case 15:

                            try
                            {
                                int sumMultiplos = 0;

                                do
                                {
                                    TempArrayNumbs = FillArrayUtility.FillArray(1, 40, 40, false, EnumResultNumber.All);

                                    TempArrayNumbs = PrintArrayUtility.FindMultipleElements(TempArrayNumbs, 2);

                                    ShowArray(TempArrayNumbs);

                                    Cont = TempArrayNumbs.Count();

                                    sumMultiplos = FillArrayUtility.SumArray(TempArrayNumbs);

                                    Console.WriteLine("\n Hay {0} multiplos del numero 2", Cont);
                                    Console.WriteLine("\n La suma de los multiplos de 2 es {0}", sumMultiplos);

                                } while (ContProgram());

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 16:

                            try
                            {
                                Cont = 0;

                                do
                                {
                                    Console.WriteLine("Digite una frase");
                                    inputVal_1 = Console.ReadLine();

                                    if (inputVal_1 != string.Empty)
                                    {
                                        Console.WriteLine("Digite la la letra que desea buscar en la frase anteriormente digitada");
                                        inputVal_2 = Console.ReadLine();

                                        if (inputVal_2 != string.Empty)
                                        {
                                            if (inputVal_2.Length <= 1)
                                            {
                                                Cont = ToolBoxUtility.CountLetter(inputVal_1, Convert.ToChar(inputVal_2));
                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Solo puede digitar una letra a la vez");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Debe de digitar una letra");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Debe de digitar un frase");
                                    }

                                    Console.WriteLine("La letra {0} aparece un total de {1} veces ", Cont, inputVal_2);

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 17:

                            try
                            {
                                do
                                {
                                    TempArrayNumbs = FillArrayUtility.FillArray(1, 1000, 1000, false, EnumResultNumber.Even);
                                    SumNumPares = FillArrayUtility.SumArray(TempArrayNumbs);
                                    Console.WriteLine("La cantidad de numeros pares es {0} y su suma es {1}", TempArrayNumbs.Count(), SumNumPares);

                                    TempArrayNumbs = FillArrayUtility.FillArray(1, 1000, 1000, false, EnumResultNumber.Odd);
                                    SumNumImpares = FillArrayUtility.SumArray(TempArrayNumbs);
                                    Console.WriteLine("La cantidad de numeros pares es {0} y su suma es {1}", TempArrayNumbs.Count(), SumNumImpares);

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 18:

                            try
                            {
                                do
                                {
                                    Console.WriteLine("Digite una frase");
                                    inputVal_1 = Console.ReadLine();
                                    showData = ToolBoxUtility.PrintColString(inputVal_1);

                                    Console.WriteLine(showData);

                                } while (ContProgram());

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 19:

                            try
                            {
                                string romanNum = string.Empty;

                                do
                                {
                                    Console.WriteLine("Introduzca un numero de 1 a 5000");

                                    if (ToolBoxUtility.ValidateIntegerField(Console.ReadLine(), out numb))
                                    {
                                        romanNum = TraslateNumbToRoman.Traslate(numb);

                                        Console.WriteLine("El numero {0} traducido a romano es {1}", numb, romanNum);
                                    }
                                    else
                                    {
                                        Console.WriteLine("El valor debe de ser de tipo numerico");
                                    }

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 20:

                            try
                            {
                                do
                                {
                                    for (int j = 0; j <= 10; j++)
                                    {
                                        ShowMultipleArray(1, 10, j);
                                        Console.WriteLine();
                                    }
                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 21:

                            try
                            {
                                int sumDados = 0, cont = 0, contPartidas = 0;

                                do
                                {
                                    for (int i = 1; i <= 100; i++)
                                    {
                                        sumDados = PrintArrayUtility.RollDice() + PrintArrayUtility.RollDice();

                                        if (sumDados == 10)
                                        {
                                            cont++;
                                        }
                                        contPartidas++;
                                    }
                                    Console.WriteLine("SIMULACRO DE DADOS :");
                                    Console.WriteLine("Los 2 dados suman 10 una cantidad de {0} veces la cantidad de partidas fue de {1}", cont, contPartidas);

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 22:

                            try
                            {
                                double operacion = 0;
                                string[] opciones = new string[] { null, "Suma", "Resta", "Multiplicacion", "Division" };

                                do
                                {
                                    Console.WriteLine("Seleccione la operacion que desea realizar :");
                                    Console.WriteLine("1.Suma");
                                    Console.WriteLine("2.Resta");
                                    Console.WriteLine("3.Multiplicacion");
                                    Console.WriteLine("4.Division");
                                    Console.WriteLine("5.Salir");

                                    if (int.TryParse(Console.ReadLine(), out opcion))
                                    {
                                        if ((opcion > 0) && (opcion < 5))
                                        {
                                            Console.WriteLine("Digite el primer numero");

                                            inputVal_1 = Console.ReadLine();

                                            if (ToolBoxUtility.ValidateIntegerField(inputVal_1))
                                            {
                                                Console.WriteLine("Digite el segundo numero");

                                                inputVal_2 = Console.ReadLine();

                                                if (ToolBoxUtility.ValidateIntegerField(inputVal_2))
                                                {
                                                    operacion = BasicOperation.BasicOperationNum(Convert.ToInt16(inputVal_1), Convert.ToInt16(inputVal_2), (EnumBasicOperation)opcion);

                                                    Console.WriteLine("El resultado de la {0} es {1}", opciones[opcion], operacion);

                                                }
                                                else
                                                {
                                                    Console.WriteLine("El valor debe debe de ser de tipo numerico");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("El valor debe debe de ser de tipo numerico");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("La opcion debe de estar entre 1 y 5");
                                    }
                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 23:
                            //Un numero es primo solo si es divisible por si mismo y por uno
                            int num = 0, fact = 0;

                            try
                            {
                                do
                                {
                                    Console.WriteLine("Introduzca un numero entero positivo");

                                    if (int.TryParse(Console.ReadLine(), out num))
                                    {
                                        if (num > 0)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("El numero es {0}", (ToolBoxUtility.PrimeNumbFilter(num, EnumResultNumber.Prime)) ? "primo" : "no es primo");
                                            Console.WriteLine();
                                            Console.WriteLine("La tabla de multiplicar es:");

                                            ShowMultipleArray(1, 10, num);

                                            fact = BasicOperation.GetFactorial(num);
                                            Console.WriteLine();
                                            Console.WriteLine("El factorial del numero {0} es {1}", num, fact);

                                        }
                                        else
                                        {
                                            Console.WriteLine("El numero debe de ser positivo y mayor a cero");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("El valor debe de ser numerico y entero");
                                    }
                                } while (ContProgram());

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;

                        case 24: //#25/26/27/40/41

                            try
                            {
                                ListPersona toolPersona = new ListPersona(5);
                                Asignatura toolAsignatura = new Asignatura();
                                Asignatura[] listAsignatura = null;

                                Estudiante student1 = new Estudiante(4355454, "Charlie", "Brown", "Davidson", Sexo.Hombre);

                                Asignatura asign1 = new Asignatura("Matematica", 7);
                                asign1.Estudiante = student1;

                                Asignatura asign2 = new Asignatura("Ingles", 9);
                                asign2.Estudiante = student1;

                                student1.AddAsignatura(asign1);
                                student1.AddAsignatura(asign2);

                                Estudiante student2 = new Estudiante(123456, "Alex", "Kid", "Richardson", Sexo.Hombre);
                                Estudiante student3 = new Estudiante(8789, "Lucy", "Lawles", "Jeferson", Sexo.Mujer);

                                Asignatura asign3 = new Asignatura("Ciencias", 7);
                                asign3.Estudiante = student3;

                                Asignatura asign4 = new Asignatura("Estudios Sociales", 5);
                                asign4.Estudiante = student3;

                                Asignatura asign5 = new Asignatura("Educacion Fisica", 3);
                                asign5.Estudiante = student3;

                                student3.AddAsignatura(asign3);
                                student3.AddAsignatura(asign4);
                                student3.AddAsignatura(asign5);

                                Persona person1 = new Persona(4356676, "Charton", "Heston", "Henderson", Sexo.Hombre);

                                Estudiante student4 = new Estudiante(70588387, "Clint", "Eastwood", "Griffin", Sexo.Hombre);

                                Asignatura asign6 = new Asignatura("Programacion", 7.5);
                                asign6.Estudiante = student4;

                                student4.AddAsignatura(asign6);

                                toolPersona.AddPersona(student1);
                                toolPersona.AddPersona(student2);
                                toolPersona.AddPersona(student3);
                                toolPersona.AddPersona(student4);
                                toolPersona.AddPersona(person1);

                                Persona[] listPersona = toolPersona.getListPersona();

                                if ((listPersona != null) && (listPersona.Length > 0))
                                {
                                    if (!ToolBoxUtility.isNotEmpty(listPersona))
                                    {
                                        foreach (Persona nPersona in listPersona)
                                        {
                                            if (nPersona != null)
                                            {
                                                nPersona.getPersonalInformation();
                                                Console.WriteLine();
                                            }
                                        }

                                        do
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Seleccione la opcion deseada");
                                            Console.WriteLine();
                                            Console.WriteLine("1.Nota Promedio");
                                            Console.WriteLine("2.Ver Lista de Notas del estudiante");
                                            Console.WriteLine("3.Buscar una Nota");

                                            if ((int.TryParse(Console.ReadLine(), out opcion)) && ((opcion > 0) && (opcion <= 3)))
                                            {
                                                switch (opcion)
                                                {
                                                    case 1:

                                                        Console.WriteLine("Digite el numero de identificacion del usuario a buscar");

                                                        try
                                                        {
                                                            Persona nPersona = toolPersona.FindPersona(Convert.ToInt16(Console.ReadLine()));

                                                            if (nPersona != null)
                                                            {
                                                                Console.WriteLine("El promedio del estudiante {0} es {1} ", nPersona.Nombre, ((Estudiante)nPersona).GetAverageNote());
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("El estudiante no ha sido encontrado");
                                                            }
                                                        }
                                                        catch (OverflowException ex)
                                                        {
                                                            Console.WriteLine();
                                                            Console.WriteLine("El valor digitado ha sobre-pasado el maximo permitido,intente digitar un valor mas pequeño");
                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            Console.WriteLine();
                                                            Console.WriteLine("Ha ocurrido un error (ERROR NO ESPECIFICADO) :");
                                                            Console.WriteLine(ex.ToString());
                                                        }

                                                        break;

                                                    case 2:

                                                        Console.WriteLine("Digite el numero de identificacion del usuario a buscar");
                                                        Persona rPersona = toolPersona.FindPersona(Convert.ToInt16(Console.ReadLine()));

                                                        if (rPersona != null)
                                                        {
                                                            Console.WriteLine("Lista de Materias de {0}", rPersona.getNombreCompleto());
                                                            Console.WriteLine();
                                                            toolAsignatura.listarAsignaturas(((Estudiante)rPersona).ListAsignaturas);
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("{0} no tiene materias asignadas", rPersona.getNombreCompleto());
                                                        }

                                                        break;

                                                    case 3:

                                                        double notaBuscar = 0;

                                                        Console.WriteLine("Digite la nota a buscar");

                                                        if (double.TryParse(Console.ReadLine(), out notaBuscar))
                                                        {
                                                            foreach (Persona person in toolPersona.getListPersona())
                                                            {
                                                                if (person is Estudiante)
                                                                {

                                                                    listAsignatura = ((Estudiante)person).ListAsignaturasbyPersona(notaBuscar);
                                                                    toolAsignatura.listarAsignaturas(listAsignatura);
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("La nota a buscar debe de ser de tipo numerico");
                                                        }

                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("La opcion debe de estar entre 1 y 3");
                                            }
                                        } while (ContProgram());
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("No se puede visualizar informacion");
                                        Console.WriteLine("Actualmente no existen registros de estudiantes !!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("No se puede visualizar informacion");
                                    Console.WriteLine("Las estructuras no han sido inicializadas");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;

                        case 25:

                            try
                            {
                                do
                                {
                                    TempMatrixNumbs = FillArrayUtility.CreateMatrizByUser(4, 5, true, 1, 100);

                                    ShowMatrizNums(TempMatrixNumbs);

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;

                        case 26:

                            try
                            {
                                do
                                {
                                    for (int k = 1; k < 4; k++)
                                    {
                                        TempMatrixNumbs = FillArrayUtility.CreateMatrizByUser(4, 5);

                                        ShowMatrizNums(TempMatrixNumbs);
                                    }
                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;

                        case 27:

                            try
                            {
                                string rutaArchivo = @"C:\Users\Victor Manuel\Desktop\HARD TOPICS.txt";
                                string[] formats = new string[1] { ".txt" };

                                if (File.Exists(rutaArchivo))
                                {
                                    if (FileManager.FileValidationFormat(rutaArchivo, formats))
                                    {
                                        string text = System.IO.File.ReadAllText(rutaArchivo);

                                        Console.WriteLine("Contenido del archivo : \n {0}", text);
                                        Console.WriteLine("\n");
                                        Console.WriteLine("La cantidad de caracteres es de {0}", text.Length);
                                    }
                                    else
                                    {
                                        Console.WriteLine("La extension del archivo debe de ser de tipo .txt");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("El archivo no existe");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }
                            break;

                        case 28:

                            try
                            {
                                string traduct = string.Empty;

                                do
                                {
                                    Console.WriteLine("Digite el numero que desea traducir");
                                    inputVal_1 = Console.ReadLine();

                                    if (ToolBoxUtility.ValidateIntegerField(inputVal_1))
                                    {
                                        if (ToolBoxUtility.ValidateIntegerField(inputVal_1, out numb))
                                        {
                                            traduct = TraslateNumbToWord.Traslate(numb);

                                            Console.WriteLine("El numero {0} traducido a letras es {1}", inputVal_1, traduct);
                                        }
                                    }

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;

                        case 29:

                            try
                            {
                                do
                                {
                                    TempArrayNumbs = FillArrayUtility.FillArray(1, 10, 10);

                                    ShowArray(TempArrayNumbs);

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;

                        case 30:

                            try
                            {
                                do
                                {
                                    Console.WriteLine("Indique la cantidad de elementos del array");
                                    CantElements = Console.ReadLine();

                                    if (ToolBoxUtility.ValidateIntegerField(CantElements))
                                    {
                                        Console.WriteLine("Digite el primer numero,debe de estar entre 0 y 9");
                                        inputVal_1 = Console.ReadLine();

                                        if (ToolBoxUtility.ValidateIntegerField(inputVal_1))
                                        {
                                            Console.WriteLine("Digite el segundo numero,debe de estar entre {0} y 9", inputVal_1);
                                            inputVal_2 = Console.ReadLine();

                                            if (ToolBoxUtility.ValidateIntegerField(inputVal_2))
                                            {
                                                TempArrayNumbs = FillArrayUtility.FillArray(Convert.ToInt16(inputVal_1), Convert.ToInt16(inputVal_2), Convert.ToInt16(CantElements), true, EnumResultNumber.All);

                                                if (TempArrayNumbs != null)
                                                {
                                                    ShowArray(TempArrayNumbs);
                                                    SumTotal = FillArrayUtility.SumArray(TempArrayNumbs);
                                                    Console.WriteLine();
                                                    Console.WriteLine("La suma de los valores del arreglo es {0}", SumTotal);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("El numero debe de ser de tipo numerico entero");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("El valor debe de ser de tipo numerico entero");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("La cantidad de elementos debe de ser de tipo numerico y entero");
                                    }
                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;
                        case 31:

                            try
                            {
                                int maxValueArray = 0;

                                do
                                {
                                    Console.WriteLine("Indique la cantidad de elementos del array");
                                    CantElements = Console.ReadLine();

                                    if (ToolBoxUtility.ValidateIntegerField(CantElements))
                                    {
                                        TempArrayNumbs = FillArrayUtility.FillArray(1, 100, Convert.ToInt16(CantElements), random: true, pFilterNumber: EnumResultNumber.Prime);
                                        maxValueArray = PrintArrayUtility.GetMaxValueArray(TempArrayNumbs);
                                        Console.WriteLine();
                                        ShowArray(TempArrayNumbs);

                                        Console.WriteLine("El maximo valor del arreglo es {0} ", maxValueArray);
                                    }
                                    else
                                    {
                                        Console.WriteLine("El valor debe de ser tipo numerico entero");
                                    }

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;
                        case 32:

                            try
                            {
                                double sumValueArray = 0, averageValueArray = 0;

                                do
                                {
                                    TempArrayNumbs = FillArrayUtility.FillArray(1, 100, 100, pFilterNumber: EnumResultNumber.All);
                                    Console.WriteLine();
                                    ShowArray(TempArrayNumbs);
                                    sumValueArray = FillArrayUtility.SumArray(TempArrayNumbs);
                                    averageValueArray = sumValueArray / TempArrayNumbs.Length;
                                    Console.WriteLine();
                                    Console.WriteLine("La suma del arreglo es {0}", sumValueArray);
                                    Console.WriteLine();
                                    Console.WriteLine("El promedio del arreglo es {0} ", averageValueArray);

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;
                        case 33:

                            try
                            {
                                int posicion = 0;
                                string letter = string.Empty;

                                do
                                {
                                    do
                                    {
                                        Console.WriteLine("Digite un numero entero positivo");
                                        inputVal_1 = Console.ReadLine();

                                        if (ToolBoxUtility.ValidateIntegerField(inputVal_1))
                                        {
                                            letter += TraslateNumbToRoman.FindPositionABCArray(Convert.ToInt16(inputVal_1));
                                            Console.WriteLine();

                                            if (letter != string.Empty)
                                            {
                                                Console.WriteLine("El numero {0} equivale a {1} en el abecedario", inputVal_1, letter);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Error,Inserte otro numero");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("El valor digitado debe de ser de tipo numerico");
                                        }

                                    } while (posicion != -1);

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;
                        case 34:

                            try
                            {
                                do
                                {
                                    Console.WriteLine("Digite una frase");
                                    showData = PrintArrayUtility.PrintPhrase(Console.ReadLine());
                                    Console.WriteLine(showData);

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;
                        case 35:

                            try
                            {
                                do
                                {
                                    Console.WriteLine("Digite la longitud del array");
                                    CantElements = Console.ReadLine();

                                    if (ToolBoxUtility.ValidateIntegerField(CantElements))
                                    {
                                        Console.WriteLine("Digite el numero en el cual terminan los numeros que quiere mostrar");

                                        inputVal_1 = Console.ReadLine();

                                        if (ToolBoxUtility.ValidateIntegerField(inputVal_1))
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("ARREGLO ORIGINAL");
                                            Console.WriteLine();

                                            TempArrayNumbs = FillArrayUtility.FillArray(1, 300, Convert.ToInt16(CantElements), pFilterNumber: EnumResultNumber.All);
                                            Console.WriteLine();
                                            ShowArray(TempArrayNumbs);

                                            TempArrayNumbs = GenericArrayUtility<int>.FindNumLastNumber(Convert.ToInt16(inputVal_1), TempArrayNumbs);

                                            if (TempArrayNumbs != null)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("ARREGLO DE NUMEROS TERMINADOS EN {0}", inputVal_1);
                                                Console.WriteLine();

                                                ShowArray(TempArrayNumbs);
                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("No hay numeros que terminen con el digito {0}", inputVal_1);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("El valor digitado debe de ser de tipo entero");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("El valor debe de ser de tipo numerico entero");
                                    }
                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;
                        case 36:

                            Console.WriteLine("ESTE EJERCISIO HA SIDO FUCIONADO CON EL EJERCISIO #25");

                            break;
                        case 37:
                            Console.WriteLine("ESTE EJERCISIO HA SIDO FUCIONADO CON EL EJERCISIO #25");

                            break;
                        case 38:

                            try
                            {
                                do
                                {
                                    Console.WriteLine("Digite un numero");
                                    inputVal_1 = Console.ReadLine();

                                    Console.WriteLine(string.Empty);

                                    if (ToolBoxUtility.ValidateIntegerField(inputVal_1))
                                    {
                                        if (ToolBoxUtility.isCapicua(Convert.ToInt16(inputVal_1)))
                                        {

                                            Console.WriteLine("El numero {0} es Capicua", inputVal_1);
                                        }
                                        else
                                        {
                                            Console.WriteLine("El numero {0} no es Capicua", inputVal_1);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero debe de ser de tipo entero");
                                    }

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;
                        case 39:

                            try
                            {
                                int[] arrayNum = new int[] { 1, 2, 3, 4, 5 };

                                int[] arrayNumInvert = GenericArrayUtility<int>.InvertArray(arrayNum);

                                do
                                {
                                    ShowArray(arrayNum);
                                    Console.WriteLine(showData);
                                    Console.WriteLine();
                                    ShowArray(arrayNumInvert);

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ha ocurrido un error " + ex.ToString());
                            }

                            break;
                        case 40:

                            try
                            {
                                string[] array1 = new string[5];
                                string[] array2 = new string[5];

                                do
                                {
                                    Console.WriteLine("Digite los datos del primer array");
                                    Console.WriteLine(string.Empty);
                                    FillArrayUtility.FillArray(array1);
                                    Console.WriteLine("Digite los datos del segundo array");
                                    Console.WriteLine(string.Empty);
                                    FillArrayUtility.FillArray(array2);

                                    if (GenericArrayUtility<string>.CompareArrays(array1, array2))
                                    {
                                        Console.WriteLine("Los 2 arreglos son iguales");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Los 2 arreglos son diferentes");
                                    }

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;

                        case 41:

                            //METODO QUICK SORT(ES EL METODO DE ORDENAMIENTO MAS RAPIDO JAMAS CREADO!!!)
                            //OJO ES DE ESPECIAL IMPORTANCIA SELECCIONAR CORRECTAMENTE EL PIVOTE!!!
                            //ESTE ES EL METODO MAS EFECTIVO PARA ELEMENTOS DESORDENADOS

                            //int[] tempArray = new int[] { 9, 1, 7, 4, 6, 0, 2, 3, 5, 8 };

                            //int[] tempArray = new int[] { 5, 1, 3, 4, 2, 0 };

                            //int[] tempArray = new int[] { 7, 9, 8 };

                            //int[] tempArray = new int[] { 7, 8, 14, 12, 2, 1, 3, 21 };

                            //int[] tempArray = new int[] { 7, 8, 14, 12 };

                            //int[] tempArray = new int[] { 2, 1, 3, 21 };

                            //tempArray = SortArrayUtility.quickSort(tempArray);

                            //PrintArrayUtility.MostrarArreglo(tempArray);

                            //Console.ReadLine();
                            break;
                        case 47:
                            //FALTA CREAR ESTE EJERCISIO

                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 48:

                            try
                            {
                                do
                                {
                                    TempMatrixNumbs = FillArrayUtility.CreateMatrizByUser(3, 3, true, 1, 10, false);
                                    Console.WriteLine();
                                    ShowMatrizNums(TempMatrixNumbs);

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;
                        case 49:

                            try
                            {
                                int numColumns = 0;

                                do
                                {
                                    Console.WriteLine("Digite la cantidad de columnas de una matriz de 5 filas");

                                    if (int.TryParse(Console.ReadLine(), out numColumns))
                                    {
                                        TempMatrixNumbs = FillArrayUtility.CreateMatrizByUser(5, numColumns, true, 0, 10);
                                        ShowMatrizNums(TempMatrixNumbs);
                                    }
                                    else
                                    {
                                        Console.WriteLine("El valor debe de ser de tipo numerico");
                                    }
                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;
                        case 50:

                            try
                            {
                                int numRow = 0, numCol = 0;
                                int[,] matrizA = null, matrizB = null;

                                do
                                {
                                    Console.WriteLine("Digite el numero de filas de la matriz");

                                    if (int.TryParse(Console.ReadLine(), out numRow))
                                    {
                                        Console.WriteLine("Digite el numero de columnas de la matriz");

                                        if (int.TryParse(Console.ReadLine(), out numCol))
                                        {
                                            Console.WriteLine("Creacion de la primera matriz");
                                            Console.WriteLine();

                                            matrizA = FillArrayUtility.CreateMatrizByUser(numRow, numCol);
                                            ShowMatrizNums(matrizA);

                                            Console.WriteLine("Creacion de la segunda matriz");
                                            Console.WriteLine();

                                            matrizB = FillArrayUtility.CreateMatrizByUser(numRow, numCol);
                                            ShowMatrizNums(matrizB);

                                            Console.WriteLine("Suma de las 2 primeras matrices");
                                            Console.WriteLine();

                                            TempMatrixNumbs = PrintArrayUtility.showMatrizSum(matrizA, matrizB);
                                            ShowMatrizNums(TempMatrixNumbs);

                                        }
                                        else
                                        {
                                            Console.WriteLine("El valor debe de ser de tipo numerico entero");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("El valor debe de ser de tipo numerico entero");
                                    }

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;
                        case 51:

                            bool fillFlag = false;
                            double sumData = 0;

                            try
                            {
                                do
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("----Opciones del sistema----" +
                                                      "\n1.Rellenar Matriz" +
                                                      "\n2.Suma de una fila" +
                                                      "\n3.Suma de una columna" +
                                                      "\n4.Sumar diagonal principal" +
                                                      "\n5.Sumar diagonal inversa" +
                                                      "\n6.La media de todos los valores" +
                                                      "\n7.Salir del sistema");

                                    if (int.TryParse(Console.ReadLine(), out opcion))
                                    {
                                        switch (opcion)
                                        {
                                            case 1:

                                                TempMatrixNumbs = FillArrayUtility.CreateMatrizByUser(4, 4);
                                                ShowMatrizNums(TempMatrixNumbs);
                                                fillFlag = true;

                                                break;

                                            case 2:

                                                if (fillFlag)
                                                {
                                                    Console.WriteLine("Digite el numero de fila que desea sumar");

                                                    if (int.TryParse(Console.ReadLine(), out row))
                                                    {
                                                        sumData = PrintArrayUtility.sumRow(TempMatrixNumbs, row);
                                                        Console.WriteLine();
                                                        ShowMatrizNums(TempMatrixNumbs);

                                                        Console.WriteLine("La suma de la fila {0} es {1}", sumData, row);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("El valor debe de ser de tipo numerico y entero");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Debe de llenar la matriz,antes de acceder a esta opcion!!");
                                                }

                                                break;

                                            case 3:

                                                if (fillFlag)
                                                {
                                                    Console.WriteLine("Digite el numero de columna que desea sumar");

                                                    if (int.TryParse(Console.ReadLine(), out col))
                                                    {
                                                        sumData = PrintArrayUtility.sumCol(TempMatrixNumbs, col);
                                                        Console.WriteLine();
                                                        ShowMatrizNums(TempMatrixNumbs);

                                                        Console.WriteLine("La suma de la fila {0} es {1}", sumData, col);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("El valor debe de ser de tipo numerico y entero");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Debe de llenar la matriz,antes de acceder a esta opcion!!");
                                                }

                                                break;

                                            case 4:

                                                if (fillFlag)
                                                {
                                                    sumData = PrintArrayUtility.sumDiagonal(TempMatrixNumbs);
                                                    Console.WriteLine();
                                                    ShowMatrizNums(TempMatrixNumbs);

                                                    Console.WriteLine("La suma de la diagonal es {0}", sumData);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Debe de llenar la matriz,antes de acceder a esta opcion!!");
                                                }

                                                break;

                                            case 5:

                                                if (fillFlag)
                                                {
                                                    sumData = PrintArrayUtility.sumDiagonalInversaA(TempMatrixNumbs);
                                                    //PrintArrayUtility.sumDiagonalInversaB(TempMatrixNumbs);
                                                    //PrintArrayUtility.sumDiagonalInversaC(TempMatrixNumbs);
                                                    //PrintArrayUtility.sumDiagonalInversaD(TempMatrixNumbs);
                                                    Console.WriteLine();
                                                    ShowMatrizNums(TempMatrixNumbs);

                                                    Console.WriteLine("La suma de la diagonal inversa es {0}", sumData);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Debe de llenar la matriz,antes de acceder a esta opcion!!");
                                                }

                                                break;
                                            case 6:

                                                if (fillFlag)
                                                {
                                                    double average = PrintArrayUtility.matrizAverage(TempMatrixNumbs);
                                                    Console.WriteLine();
                                                    ShowMatrizNums(TempMatrixNumbs);

                                                    Console.WriteLine("El promedio es {0}", average);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Debe de llenar la matriz,antes de acceder a esta opcion!!");
                                                }
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("La opcion no es valida,debe de seleccionar una opcion de 1 a 6");
                                    }
                                } while (ContProgram());

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;
                        case 52:

                            try
                            {
                                do
                                {
                                    TempMatrixNumbs = FillArrayUtility.CreateMatrizByUser(3, 3, true, 1, 10, false);
                                    Console.WriteLine();
                                    ShowMatrizNums(TempMatrixNumbs);

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;
                        case 53:

                            int subOpcion = 0;
                            double sumRow = 0, sumCol = 0;

                            try
                            {
                                TempMatrixNumbs = FillArrayUtility.CreateMatrizByUser(3, 3, true, 1, 11, true);
                                ShowMatrizNums(TempMatrixNumbs);

                                do
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Seleccione alguna de la siguientes opciones :" +
                                                      "\n1.Suma de Fila" +
                                                      "\n2.Suma de Columna" +
                                                      "\n3.Salir");

                                    opcion = Convert.ToInt16(Console.ReadLine());

                                    if (opcion != 3)
                                    {

                                        Console.WriteLine();
                                        Console.WriteLine("Seleccione el tipo de suma" +
                                                          "\n1.Aleatoria" +
                                                          "\n2.Prederteminada");

                                        subOpcion = Convert.ToInt16(Console.ReadLine());

                                        switch (opcion)
                                        {
                                            case 1:

                                                switch (subOpcion)
                                                {
                                                    case 1:

                                                        Console.WriteLine("Suma aleatoria de fila");
                                                        row = ram.Next(0, TempMatrixNumbs.GetLength(0));
                                                        sumRow = PrintArrayUtility.sumRow(TempMatrixNumbs, row);

                                                        Console.WriteLine(string.Format("El resultado de la suma de la fila {0} es {1}", row, sumRow));

                                                        break;

                                                    case 2:

                                                        Console.WriteLine("Suma prederteminada de fila");
                                                        Console.WriteLine();
                                                        Console.WriteLine("Digite la fila que desea sumar");

                                                        if (int.TryParse(Console.ReadLine(), out row))
                                                        {
                                                            sumRow = PrintArrayUtility.sumRow(TempMatrixNumbs, row);

                                                            Console.WriteLine(string.Format("El resultado de la suma de la fila {0} es {1}", row, sumRow));
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("El valor debe de ser de tipo numerico");
                                                        }

                                                        break;
                                                }

                                                break;

                                            case 2:

                                                switch (subOpcion)
                                                {
                                                    case 1:

                                                        Console.WriteLine("Suma aleatoria de columna");
                                                        col = ram.Next(0, TempMatrixNumbs.GetLength(1));
                                                        sumCol = PrintArrayUtility.sumCol(TempMatrixNumbs, col);

                                                        Console.WriteLine("El resultado de la suma de la columna {0} es {1}", col, sumCol);

                                                        break;

                                                    case 2:

                                                        Console.WriteLine("Suma prederteminada de columna");
                                                        Console.WriteLine();
                                                        Console.WriteLine("Digite la columna que desea sumar");

                                                        if (int.TryParse(Console.ReadLine(), out col))
                                                        {
                                                            sumCol = PrintArrayUtility.sumCol(TempMatrixNumbs, col);

                                                            Console.WriteLine("El resultado de la suma de la columna {0} es {1}", col, sumCol);
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("El valor debe de ser de tipo numerico");
                                                        }
                                                        Console.WriteLine();
                                                        break;
                                                }

                                                break;
                                        }
                                    }
                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            break;
                        case 54:

                            CandyMachine myCandyMachine = new CandyMachine();

                            //--------INSERTS DEFAULT--------

                            Candy candy_1 = new Candy();
                            candy_1.CodCandy = "00";
                            candy_1.Name = "Kit-Kat";
                            candy_1.Price = 100;
                            candy_1.Cant = 3;

                            Candy candy_2 = new Candy();
                            candy_2.CodCandy = "01";
                            candy_2.Name = "Snickers";
                            candy_2.Price = 300;
                            candy_2.Cant = 2;

                            Candy candy_3 = new Candy();
                            candy_3.CodCandy = "02";
                            candy_3.Name = "Galleta Yipi";
                            candy_3.Price = 50;
                            candy_3.Cant = 10;

                            Candy candy_4 = new Candy();
                            candy_4.CodCandy = "03";
                            candy_4.Name = "Chocolate Milka";
                            candy_4.Price = 800;
                            candy_4.Cant = 3;

                            Candy candy_5 = new Candy();
                            candy_5.CodCandy = "10";
                            candy_5.Name = "Chocolate Tutto";
                            candy_5.Price = 250;
                            candy_5.Cant = 5;

                            Candy candy_6 = new Candy();
                            candy_6.CodCandy = "11";
                            candy_6.Name = "Gomitas de osito";
                            candy_6.Price = 300;
                            candy_6.Cant = 10;

                            Candy candy_7 = new Candy();
                            candy_7.CodCandy = "12";
                            candy_7.Name = "Baston de caramelo";
                            candy_7.Price = 150;
                            candy_7.Cant = 34;

                            Candy candy_8 = new Candy();
                            candy_8.CodCandy = "13";
                            candy_8.Name = "Mentas";
                            candy_8.Price = 100;
                            candy_8.Cant = 3;

                            Candy candy_9 = new Candy();
                            candy_9.CodCandy = "20";
                            candy_9.Name = "Brownie";
                            candy_9.Price = 400;
                            candy_9.Cant = 3;

                            Candy candy_10 = new Candy();
                            candy_10.CodCandy = "21";
                            candy_10.Name = "Bombones";
                            candy_10.Price = 800;
                            candy_10.Cant = 14;

                            try
                            {
                                if (myCandyMachine.InsertCandy(candy_1))
                                {
                                    Console.WriteLine("Registro agregado");
                                }
                                else
                                {
                                    Console.WriteLine("Sin Registrar");
                                }

                                if (myCandyMachine.InsertCandy(candy_2))
                                {
                                    Console.WriteLine("Registro agregado");
                                }
                                else
                                {
                                    Console.WriteLine("Sin Registrar");
                                }

                                if (myCandyMachine.InsertCandy(candy_3))
                                {
                                    Console.WriteLine("Registro agregado");
                                }
                                else
                                {
                                    Console.WriteLine("Sin Registrar");
                                }

                                if (myCandyMachine.InsertCandy(candy_4))
                                {
                                    Console.WriteLine("Registro agregado");
                                }
                                else
                                {
                                    Console.WriteLine("Sin Registrar");
                                }

                                if (myCandyMachine.InsertCandy(candy_5))
                                {
                                    Console.WriteLine("Registro agregado");
                                }
                                else
                                {
                                    Console.WriteLine("Sin Registrar");
                                }

                                if (myCandyMachine.InsertCandy(candy_6))
                                {
                                    Console.WriteLine("Registro agregado");
                                }
                                else
                                {
                                    Console.WriteLine("Sin Registrar");
                                }

                                if (myCandyMachine.InsertCandy(candy_7))
                                {
                                    Console.WriteLine("Registro agregado");
                                }
                                else
                                {
                                    Console.WriteLine("Sin Registrar");
                                }

                                if (myCandyMachine.InsertCandy(candy_8))
                                {
                                    Console.WriteLine("Registro agregado");
                                }
                                else
                                {
                                    Console.WriteLine("Sin Registrar");
                                }

                                if (myCandyMachine.InsertCandy(candy_9))
                                {
                                    Console.WriteLine("Registro agregado");
                                }
                                else
                                {
                                    Console.WriteLine("Sin Registrar");
                                }

                                if (myCandyMachine.InsertCandy(candy_10))
                                {
                                    Console.WriteLine("Registro agregado");
                                }
                                else
                                {
                                    Console.WriteLine("Sin Registrar");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                Console.WriteLine();
                            }

                            //--------INSERTS DEFAULT--------

                            try
                            {
                                string opcionMaquina = string.Empty;

                                do
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("MAQUINA EXPENDEDORA DE DULCES" +
                                                      "\n" +
                                                      "\n1.Pedir golosina" +
                                                      "\n2.Mostrar golosinas" +
                                                      "\n3.Rellenar golosinas" +
                                                      "\n4.Historial de ventas");

                                    opcionMaquina = Console.ReadLine();

                                    if (ToolBoxUtility.ValidateIntegerField(opcionMaquina))
                                    {
                                        switch (Convert.ToInt16(opcionMaquina))
                                        {
                                            case 1:

                                                try
                                                {
                                                    do
                                                    {
                                                        myCandyMachine.ShowCandies(myCandyMachine.ListCandies);
                                                        Console.WriteLine();
                                                        Console.WriteLine("Digite el codigo de la golosina que quiere seleccionar :");

                                                        if (myCandyMachine.buyCandy(Console.ReadLine()))
                                                        {
                                                            Console.WriteLine();
                                                            showData = myCandyMachine.ShowCandies(myCandyMachine.ListCandies);

                                                            Console.WriteLine("-------------LISTA DE DULCES---------------------");
                                                            Console.WriteLine(showData);
                                                            Console.WriteLine("-------------------------------------------------");
                                                        }

                                                    } while (ContProgram(UserContinues.ShoppingCont));

                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                                    Console.WriteLine();
                                                }

                                                break;

                                            case 2:

                                                try
                                                {
                                                    do
                                                    {
                                                        Console.WriteLine();
                                                        showData = myCandyMachine.ShowCandies(myCandyMachine.ListCandies);

                                                        Console.WriteLine("-------------LISTA DE DULCES---------------------");
                                                        Console.WriteLine(showData);
                                                        Console.WriteLine("-------------------------------------------------");

                                                    } while (ContProgram(UserContinues.ShowInfoCont));

                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                                    Console.WriteLine();
                                                }

                                                break;

                                            case 3:

                                                string codCandy = string.Empty;
                                                Candy mCandy = null;

                                                try
                                                {
                                                    do
                                                    {
                                                        Console.WriteLine("Digite la clave secreta");
                                                        Console.WriteLine();

                                                        if (myCandyMachine.Login(Console.ReadLine()))
                                                        {
                                                            Console.WriteLine("Bienvenido al registro de dulces");
                                                            Console.WriteLine();
                                                            Console.WriteLine("Digite la posicion del dulce");

                                                            codCandy = Console.ReadLine();

                                                            if (myCandyMachine.ValidateCodCandy(codCandy))
                                                            {

                                                                mCandy = myCandyMachine.GetCandy(codCandy, myCandyMachine.ListCandies);

                                                                if (mCandy == null)
                                                                {
                                                                    mCandy = new Candy();
                                                                    mCandy.CodCandy = codCandy;

                                                                    Console.WriteLine("Digite el nombre del producto :");
                                                                    mCandy.Name = Console.ReadLine();

                                                                    if (mCandy.Name != string.Empty)
                                                                    {
                                                                        Console.WriteLine("Digite el precio del producto");
                                                                        inputVal_1 = Console.ReadLine();

                                                                        if (ToolBoxUtility.ValidateDouble(inputVal_1))
                                                                        {
                                                                            mCandy.Price = Convert.ToDouble(inputVal_1);

                                                                            Console.WriteLine("Digite la cantidad de producto");
                                                                            inputVal_1 = Console.ReadLine();

                                                                            if (ToolBoxUtility.ValidateIntegerField(inputVal_1))
                                                                            {
                                                                                mCandy.Cant = Convert.ToInt16(inputVal_1);

                                                                                if (myCandyMachine.InsertCandy(mCandy))
                                                                                {
                                                                                    Console.WriteLine("El producto ha sido registrado correctamente");
                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine("Ha ocurrido un error en el registro de la informacion");
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("El valor debe ser de tipo numerico entero");
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("El valor debe de ser de tipo numerico");
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("Debe de digitar un nombre para el producto");
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("La posicion esta ocupada por {0}", mCandy.Name);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("El digitado no es valido");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("No tiene acceso a esta opcion");
                                                        }

                                                    } while (ContProgram(UserContinues.InsertCont));

                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine("Un error ha ocurrido");
                                                    Console.WriteLine();
                                                }

                                                break;

                                            case 4:

                                                try
                                                {
                                                    showData = myCandyMachine.ShowShoppingHistory();

                                                    Console.WriteLine("-------------HISTORIAL DE VENTAS---------------");
                                                    Console.WriteLine();
                                                    Console.WriteLine(showData);
                                                    Console.WriteLine();
                                                    Console.WriteLine("-----------------------------------------------");
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine("Ha ocurrido un error : {0} ", ex.ToString());
                                                    Console.WriteLine();
                                                }
                                                break;
                                        }
                                    }

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Un error ha ocurrido");
                                Console.WriteLine();
                            }

                            break;
                        case 55:
                            //NOTA:CREAR UNA VERSION GRAFICA PARA ESTE EJERCISIO
                            try
                            {
                                CatGame catGame = new CatGame();
                                char[,] matriz = catGame.ResetMatriz();
                                bool endGame = false, contSys = true;
                                string currentPlayer = string.Empty, contin = string.Empty;

                                do
                                {
                                    while (!endGame)
                                    {
                                        if (!endGame)
                                        {
                                            currentPlayer = "JUGADOR 1";
                                            catGame.SelectPlayer(currentPlayer, 'X', out endGame, matriz);
                                        }

                                        if (!endGame)
                                        {
                                            currentPlayer = "JUGADOR 2";
                                            catGame.SelectPlayer(currentPlayer, 'O', out endGame, matriz);
                                        }

                                        if (endGame)
                                        {
                                            contSys = ContProgram();

                                            if (contSys)
                                            {
                                                endGame = false;
                                                matriz = catGame.ResetMatriz();
                                            }
                                            else
                                            {
                                                endGame = true;
                                            }
                                        }
                                    }
                                } while (contSys);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Un error ha ocurrido");
                                Console.WriteLine();
                            }

                            break;
                        case 56:

                            try
                            {
                                int[,] matriz1 = null, matriz2 = null, sumMatriz = null;

                                do
                                {
                                    Console.WriteLine();

                                    matriz1 = FillArrayUtility.CreateMatrizByUser(2, 3, true, 1, 9);
                                    ShowMatrizNums(matriz1);

                                    Console.WriteLine();

                                    matriz2 = FillArrayUtility.CreateMatrizByUser(2, 3, true, 1, 9);
                                    ShowMatrizNums(matriz2);

                                    Console.WriteLine();

                                    sumMatriz = PrintArrayUtility.showMatrizSum(matriz1, matriz2);
                                    ShowMatrizNums(sumMatriz);

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Un error ha ocurrido");
                                Console.WriteLine();
                            }

                            break;
                        case 57:

                            try
                            {
                                ListPersona listEmpleados = new ListPersona(3);

                                Empleado employee1 = new Empleado(206570562, "Victor Manuel", "Carvajal", "Artavia", Sexo.Hombre, StatusLaboral.Si_trabaja);
                                employee1.Salary = 600;
                                listEmpleados.AddPersona(employee1);

                                Empleado employee2 = new Empleado(206570563, "Stacy", "Willians", "Brown", Sexo.Mujer, StatusLaboral.Si_trabaja);
                                employee2.Salary = 900;
                                listEmpleados.AddPersona(employee2);

                                Empleado employee3 = new Empleado(206570564, "Barbara", "Gordon", "Stevenson", Sexo.Mujer, StatusLaboral.No_trabaja);
                                listEmpleados.AddPersona(employee3);

                                Persona[] listEmployees = listEmpleados.getListPersona();

                                if ((listEmployees != null) && (listEmployees.Length > 0))
                                {
                                    if (!ToolBoxUtility.isNotEmpty(listEmployees))
                                    {
                                        foreach (Persona empleado in listEmployees)
                                        {
                                            if (empleado != null)
                                            {
                                                empleado.getPersonalInformation();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay informacion disponible para mostrar");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No hay informacion disponible para mostrar");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Un error ha ocurrido");
                                Console.WriteLine();
                            }

                            break;
                        case 58:
                            Console.WriteLine("ESTE EJERCISIO HA SIDO FUCIONADO CON EL EJERCISIO #60");

                            break;
                        case 59:
                            Console.WriteLine("ESTE EJERCISIO HA SIDO FUCIONADO CON EL EJERCISIO #60");

                            break;
                        case 60: //EJERCISIO #58,59,60

                            try
                            {
                                do
                                {
                                    Console.WriteLine("------SELECCIONE UNA OPCION A EJECUTAR------");
                                    Console.WriteLine("1.Ejercisios basicos sobre Matriz");
                                    Console.WriteLine("2.Matriz Transpuesta");
                                    Console.WriteLine("3.Suma de Triangulo Inferior + Suma de Triangulo Superior");

                                    inputVal_1 = Console.ReadLine();

                                    if (ToolBoxUtility.ValidateIntegerField(inputVal_1))
                                    {
                                        switch (Convert.ToInt16(inputVal_1))
                                        {
                                            case 1:

                                                string option = string.Empty;
                                                char[] listOptions = new char[4] { 'a', 'b', 'c', 'd' };
                                                int[,] rowValResults = null, colValResults = null;
                                                int resultValues = 2;
                                                TempMatrixNumbs = new int[5, 5] { { 5, 7, 8, 9, 10 }, { 1, 6, 4, 5, 6 }, { 2, 3, 9, 2, 3 }, { 4, 5, 6, 4, 1 }, { 7, 8, 9, 3, 10 } };

                                                do
                                                {
                                                    Console.WriteLine("Opciones" +
                                                                      "\n a.Mostrar, para cada fila, la suma de sus valores, y el menor valor almacenado" +
                                                                      "\n b.Mostrar, para cada columna, el promedio de sus valores y el mayor valor" +
                                                                      "\n c.El mayor valor almacenado en toda la Matriz" +
                                                                      "\n d.Cambiar el numero de filas y columnas");

                                                    option = Console.ReadLine();

                                                    if (ToolBoxUtility.ValidateCharOption(option, listOptions))
                                                    {
                                                        switch (Convert.ToChar(option))
                                                        {
                                                            case 'a':

                                                                ShowMatrizNums(TempMatrixNumbs);
                                                                Console.WriteLine();
                                                                Console.WriteLine("La suma de cada fila es la siguiente :");

                                                                rowValResults = PrintArrayUtility.rowSumMatriz(TempMatrixNumbs);

                                                                for (int i = 0; i < rowValResults.GetLength(0); i++)
                                                                {
                                                                    Console.WriteLine("\n ->La suma de la fila {0} es : {1} y el menor valor en la fila es : {2}", i, rowValResults[i, resultValues - 2], rowValResults[i, resultValues - 1]);
                                                                }

                                                                break;

                                                            case 'b':

                                                                ShowMatrizNums(TempMatrixNumbs);
                                                                Console.WriteLine();
                                                                Console.WriteLine("El promedio de cada columna es el siguiente :");

                                                                colValResults = PrintArrayUtility.colSumMatriz(TempMatrixNumbs);

                                                                for (int j = 0; j < colValResults.GetLength(0); j++)
                                                                {
                                                                    Console.WriteLine("\n ->El promedio de la columna {0} es : {1} y el mayor valor de la columna es : {2}", j, colValResults[j, resultValues - 2], colValResults[j, resultValues - 1]);
                                                                }

                                                                break;

                                                            case 'c':

                                                                int rowFound = 0;
                                                                int colFound = 0;
                                                                int maxValueGlobal = PrintArrayUtility.maxValueMatriz(TempMatrixNumbs, out rowFound, out colFound);

                                                                Console.WriteLine("El mayor valor almacenado en toda la Matriz es {0},se encuentra en la fila {1}  y en la columna {2}", maxValueGlobal, rowFound, colFound);

                                                                break;

                                                            case 'd':

                                                                TempMatrixNumbs = requestDataMatriz(TempMatrixNumbs);
                                                                ShowMatrizNums(TempMatrixNumbs);

                                                                break;
                                                        }
                                                    }
                                                    else
                                                    {

                                                        Console.WriteLine("La opcion digitada no es valida");
                                                    }

                                                } while (ContProgram());

                                                break;

                                            case 2:

                                                TempMatrixNumbs = new int[3, 5] { { 4, 7, 1, 3, 5 }, { 2, 0, 6, 9, 7 }, { 3, 1, 2, 6, 4 } };
                                                ShowMatrizNums(TempMatrixNumbs);
                                                Console.WriteLine();
                                                TempMatrixNumbs = PrintArrayUtility.showMatrizTranspuesta(TempMatrixNumbs);
                                                ShowMatrizNums(TempMatrixNumbs);

                                                break;

                                            case 3:

                                                TempMatrixNumbs = new int[5, 5] { { 5, 7, 8, 9, 10 }, { 1, 6, 4, 5, 6 }, { 2, 3, 9, 2, 3 }, { 4, 5, 6, 4, 1 }, { 7, 8, 9, 3, 10 } };
                                                ShowMatrizNums(TempMatrixNumbs);
                                                Console.WriteLine();
                                                PrintArrayUtility.sumTriangInfSup(TempMatrixNumbs);
                                                ShowMatrizNums(TempMatrixNumbs);

                                                break;
                                        }
                                    }

                                } while (ContProgram());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Un error ha ocurrido");
                                Console.WriteLine();
                            }

                            break;

                        case 61:

                            try
                            {
                                GenericStack<int> stack = new GenericStack<int>(4);

                                Console.WriteLine();
                                Console.WriteLine("------PILA----");

                                stack.Push(1);
                                stack.Push(2);
                                stack.Push(3);
                                stack.Push(4);

                                Console.WriteLine(stack.ToString());

                                Console.WriteLine();
                                Console.WriteLine("Remover un elemento de la pila");
                                Console.WriteLine();

                                stack.Pop();

                                Console.WriteLine(stack.ToString());

                                //Console.WriteLine();
                                //Console.WriteLine("Remover otro elemento de la pila");
                                //Console.WriteLine();

                                //stack.Pop();

                                //Console.WriteLine(stack.ToString());

                                Console.WriteLine();
                                Console.WriteLine("--------COLA--------");

                                GenericQueue<int> Queue = new GenericQueue<int>(4);

                                Queue.Enqueue(1);
                                Queue.Enqueue(2);
                                Queue.Enqueue(3);
                                Queue.Enqueue(4);

                                Console.WriteLine(Queue.ToString());

                                Console.WriteLine();
                                Console.WriteLine("Remover un elemento de la cola");
                                Console.WriteLine();

                                Queue.Dequeue();

                                Console.WriteLine(Queue.ToString());

                            }
                            catch (ArgumentOutOfRangeException ex)
                            {

                                Console.WriteLine();
                                Console.WriteLine("La posicion esta fuera de rango");
                                Console.WriteLine(ex);
                                Console.WriteLine();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ha ocurrido un error");
                                Console.WriteLine(ex);
                                Console.WriteLine();
                            }

                            break;
                        case 62:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 63:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 64:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 65:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 66:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 67:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 68:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 69:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 70:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 71:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 72:

                            string operatorName = string.Empty,
                                   operatorLastName = string.Empty,
                                   salaryOperator = string.Empty,
                                   addOperator = "Y";

                            Operator nOperator = null;
                            int o = 1;

                            do
                            {
                                if (o > 1)
                                {
                                    Console.WriteLine("Desea agregar un nuevo operador?(Y/N)");
                                    addOperator = Console.ReadLine();
                                }

                                if (addOperator.ToUpper() == "Y")
                                {
                                    Console.WriteLine("Ingrese el nombre el operario {0}", o);
                                    operatorName = Console.ReadLine();

                                    Console.WriteLine("Ingrese el apellido del operario {0}", o);
                                    operatorLastName = Console.ReadLine();

                                    nOperator = new Operator(operatorName, operatorLastName);

                                    for (int j = 1; j < 4; j++)
                                    {
                                        Console.WriteLine("Ingrese sueldo {0}", j);

                                        salaryOperator = Console.ReadLine();

                                        if (ToolBoxUtility.ValidateDouble(salaryOperator))
                                        {
                                            nOperator.Salary = Convert.ToDouble(salaryOperator);
                                        }
                                        else
                                        {
                                            Console.WriteLine("El valor debe de ser de tipo numerico");
                                        }
                                    }

                                    o++;
                                }

                            } while (addOperator.ToUpper() == "Y");

                            Console.WriteLine();
                            Console.WriteLine(ListDynamicPersona.getStadisticInform());
                            Console.ReadLine();

                            break;
                        case 73:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 74:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 75:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 76:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 77:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 78:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 79:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 80:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 81:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 82:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 83:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 84:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 85:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 86:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 87:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 88:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;
                        case 89:
                            Console.WriteLine("EJERCISIO NO DISPONIBLE");
                            break;

                    }
                }

            } while (Option <= CANT_EXERCISES);
        }

        public static bool ContProgram(UserContinues pContinueOption = UserContinues.SystemCont)
        {
            bool contProgram = true;
            string contYN = string.Empty;

            Console.WriteLine();
            Console.WriteLine("{0}", ToolBoxUtility.ContinueLabel(pContinueOption));
            contYN = Console.ReadLine();

            while ((contYN.ToUpper() != "Y") && (contYN.ToUpper() != "N"))
            {
                Console.WriteLine();
                Console.WriteLine("La opcion no es valida,{0}", ToolBoxUtility.ContinueLabel(pContinueOption));
                contYN = Console.ReadLine();
            }

            if (contYN.ToUpper() == "N")
            {
                contProgram = false;
            }

            return contProgram;
        }

        public static void ShowMultipleArray(int[] pArray, int pMultiple)
        {
            for (int i = pArray[0]; i <= pArray.Length; i++)
            {
                Console.WriteLine(pMultiple + "X" + i + "=" + (pMultiple * i));
            }
        }

        public static void ShowArray(string[] pArray)
        {
            for (int i = 0; i <= pArray.Length - 1; i++)
            {
                Console.WriteLine("Posicion {0} Elmento => {1}", i, pArray[i]);
            }
        }

        public static void ShowArray(int[] pArray)
        {
            for (int i = 0; i <= pArray.Length - 1; i++)
            {
                Console.WriteLine("Posicion {0} Elmento => {1}", i, pArray[i]);
            }
        }

        public static void ShowMatrizChar(char[,] pMatrizA)
        {
            for (int i = 0; i < pMatrizA.GetLength(0); i++)
            {
                for (int j = 0; j < pMatrizA.GetLength(1); j++)
                {
                    Console.Write(pMatrizA[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void ShowMatrizNums(int[,] pMatrizA)
        {
            for (int i = 0; i < pMatrizA.GetLength(0); i++)
            {
                for (int j = 0; j < pMatrizA.GetLength(1); j++)
                {
                    Console.Write("{0}" + pMatrizA[i, j] + "{1}", " ", " ");
                }
                Console.WriteLine();
            }
        }

        public static void ShowMultipleArray(int pStartArray, int pEndArray, int pMultiple)
        {
            for (int i = pStartArray; i <= pEndArray; i++)
            {
                Console.WriteLine(pMultiple + "X" + i + "=" + (pMultiple * i));
            }
        }

        public static int[,] requestDataMatriz(int[,] pMatrix)
        {
            int row = 0, col = 0;
            bool checkRow = false, checkCol = false;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Digite el numero de filas");

                checkRow = ToolBoxUtility.ValidateIntegerField(Console.ReadLine(), out row);

                if (checkRow)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Digite el numero de columnas");

                        checkCol = ToolBoxUtility.ValidateIntegerField(Console.ReadLine(), out col);

                        if (checkCol)
                        {
                            pMatrix = FillArrayUtility.fillDinaMatriz(row, col);
                        }
                        else
                        {
                            Console.WriteLine("El numero de columnas debe de ser de tipo entero");
                        }

                    } while (!checkCol);
                }
                else
                {
                    Console.WriteLine("El numero de filas debe de ser de tipo entero");
                }

            } while (!checkRow);

            return pMatrix;
        }
    }
}
