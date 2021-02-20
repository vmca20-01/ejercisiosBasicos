using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercisiosBasicos
{
    public class Empleado : Persona
    {
        private StatusLaboral statusLaboral;
        private double? salary;

        public Empleado(int pIdentificacion, string pNombre, string pPrimerApellido, string pSegundoApellido, Sexo pSexo, StatusLaboral pStatusLaboral = StatusLaboral.No_trabaja) : base(pIdentificacion, pNombre, pPrimerApellido, pSegundoApellido, pSexo)
        {
            this.StatusLaboral = pStatusLaboral;
        }

        public StatusLaboral StatusLaboral { get => statusLaboral; set => statusLaboral = value; }

        public double? Salary
        {
            get
            {
                return GetSalary((double?)this.salary);
            }
            set
            {
                this.salary = value;
            }
        }

        private double? GetSalary(double? pSalary)
        {
            this.salary = null;

            if (this.StatusLaboral == StatusLaboral.Si_trabaja)
            {
                if ((pSalary >= 600) && (pSalary <= 2000))
                {
                    this.salary = pSalary;
                }
            }
            else if (this.StatusLaboral == StatusLaboral.No_trabaja)
            {
                this.salary = 0;
            }

            return this.salary;
        }

        public override string getPersonalInformation()
        {
            string personalInformation = base.getPersonalInformation();

            if (this.StatusLaboral == StatusLaboral.Si_trabaja)
            {
                personalInformation += string.Format("Status Laboral : {0}", "Trabaja");
                personalInformation += string.Format("Sueldo : {0}", this.Salary);
            }
            else
            {
                personalInformation += string.Format("Status Laboral : {0}", "No Trabaja");
            }

            return personalInformation;
        }

    }
}
