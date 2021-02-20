using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercisiosBasicos
{

    public class Estudiante : Persona
    {
        private int contAsignaturas = 0;
        private Asignatura[] listAsignaturas = new Asignatura[2];

        public Estudiante(int pIdentificacion, string pNombre, string pPrimerApellido, string pSegundoApellido, Sexo pSexo) : base(pIdentificacion, pNombre, pPrimerApellido, pSegundoApellido, pSexo)
        {

        }

        public Asignatura[] ListAsignaturas { get => listAsignaturas; set => listAsignaturas = value; }

        public bool AddAsignatura(Asignatura pAsignatura)
        {
            if (ListAsignaturas.Length > contAsignaturas)
            {
                ListAsignaturas[contAsignaturas] = pAsignatura;
                contAsignaturas++;
                return true;
                //Console.WriteLine("Asignatura agregada correctamente");
            }
            return false;
            //else
            //{
            //Console.WriteLine("La lista llego a su limite,ya no puede agregar mas asginaturas para {0} ", this.getNombreCompleto());
            //}
        }

        public Asignatura[] ListAsignaturasbyPersona(double pNota)
        {
            int lenghtArray = CreateLenghtArray(pNota);
            Asignatura[] foundDataList = new Asignatura[lenghtArray];
            int cont = 0;

            foreach (Asignatura asign in this.ListAsignaturas)
            {
                if (asign != null)
                {
                    if (asign.NotaAsignatura == pNota)
                    {
                        foundDataList[cont] = asign;
                        cont++;
                    }
                }
            }

            return foundDataList;

            int CreateLenghtArray(double pNotaBuscar)
            {
                int lenght = 0;

                foreach (Asignatura asign in this.ListAsignaturas)
                {
                    if (asign != null)
                    {
                        if (asign.NotaAsignatura == pNotaBuscar)
                        {
                            lenght++;
                        }
                    }
                }

                return lenght;
            }
        }


        //DEPURAR ESTE METODO POR MEDIO DE LA HERENCIA
        public override string getPersonalInformation()
        {
            string personalInformation = base.getPersonalInformation();

            if ((this.ListAsignaturas != null) && (this.ListAsignaturas.Length > 0))
            {
                //Console.WriteLine();
                //Console.WriteLine("-----------------------------");

                foreach (Asignatura asign in this.ListAsignaturas)
                {
                    if (asign != null)
                    {
                        personalInformation += string.Format("\nAsignatura : {0} Nota : {1} Estado : {2}", asign.NombreAsignatura, asign.NotaAsignatura, asign.estadoAsignatura());
                    }
                }
                //Console.WriteLine("-----------------------------");
            }
            else
            {
                personalInformation = "---No hay asignaturas registradas---";
            }

            return personalInformation;
        }

        public double GetAverageNote()
        {
            double averageValue = 0;

            if (this.ListAsignaturas.Length > 0)
            {
                foreach (Asignatura asign in this.ListAsignaturas)
                {
                    averageValue += asign.NotaAsignatura;
                }

                averageValue = averageValue / this.ListAsignaturas.Length;
            }

            return averageValue;
        }

    }
}
