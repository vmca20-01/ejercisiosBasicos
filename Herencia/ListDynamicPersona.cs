using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercisiosBasicos.Herencia
{
    public static class ListDynamicPersona
    {
        private static ArrayList listPersona = new ArrayList();

        public static void addPersona(Persona pPersona)
        {
            listPersona.Add(pPersona);
        }

        public static Operator getMaxSumSalaryOperator()
        {
            Operator operatorWithMaxSalary = null;
            double maxSalary = 0;

            if ((listPersona != null) && (listPersona.Count > 0))
            {
                foreach (Operator nOperator in listPersona)
                {
                    if (nOperator.getSumSalaries() > maxSalary)
                    {
                        operatorWithMaxSalary = nOperator;
                    }
                }
            }

            return operatorWithMaxSalary;
        }

        public static string getStadisticInform()
        {
            string hilera = string.Empty;

            if ((listPersona != null) && (listPersona.Count > 0))
            {
                Operator nOperator = getMaxSumSalaryOperator();

                hilera = "----Estadistica de Sueldos----";
                hilera += "\nTotal de sueldos pagados por Operario";

                foreach (Operator pOperator in listPersona)
                {
                    hilera += "\n" + (pOperator.Nombre + " " + pOperator.PrimerApellido + " " + pOperator.SegundoApellido) + " --- " + pOperator.getSumSalaries();
                }

                if (nOperator != null)
                {
                    hilera += string.Format("\nEl operario con mayor sueldo es {0} que tiene un sueldo de {1}", nOperator.Nombre + " " + nOperator.PrimerApellido + " " + nOperator.SegundoApellido, nOperator.getSumSalaries());
                }
            }

            return hilera;
        }

    }
}
