using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercisiosBasicos.Herencia
{
    public class Operator : Persona
    {
        private ArrayList monthlySalaries = new ArrayList();
        private double salary = 0;

        public Operator(int pIdentificacion, string pNombre, string pPrimerApellido, string pSegundoApellido, Sexo pSexo, ArrayList pMonthlySalaries) : base(pIdentificacion, pNombre, pPrimerApellido, pSegundoApellido, pSexo)
        {
            this.MonthlySalaries = pMonthlySalaries;
            ListDynamicPersona.addPersona(this);
        }

        public Operator(string pNombre, string pPrimerApellido) : base(pNombre, pPrimerApellido)
        {
            ListDynamicPersona.addPersona(this);
        }

        public ArrayList MonthlySalaries
        {
            get
            {
                return monthlySalaries;
            }

            set
            {
                monthlySalaries = value;
            }
        }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                {
                    salary = value;
                    this.MonthlySalaries.Add(salary);
                }
                else
                {
                    throw new Exception("El salario debe ser mayor a cero");
                }
            }
        }

        public double getSumSalaries()
        {
            double totalSalaries = 0;

            if ((this.MonthlySalaries != null) && (this.MonthlySalaries.Count > 0))
            {
                foreach (double salary in this.MonthlySalaries)
                {
                    totalSalaries += salary;
                }
            }

            return totalSalaries;
        }

    }
}
