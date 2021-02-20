using System;
using System.Collections.Generic;
using System.Text;

namespace ejercisiosBasicos
{
    //APLICAR HERENCIA PARA ESTE EJERICIO
    public class Persona
    {
        private int identificacion;
        private string nombre, primerApellido, segundoApellido;
        private Sexo sexo;

        public Persona() { }

        public Persona(string pNombre, string pPrimerApellido) {

            this.Nombre = pNombre;
            this.PrimerApellido = pPrimerApellido;         
        }

        public Persona(int pIdentificacion, string pNombre, string pPrimerApellido, string pSegundoApellido, Sexo pSexo)
        {
            this.Identificacion = pIdentificacion;
            this.Nombre = pNombre;
            this.PrimerApellido = pPrimerApellido;
            this.SegundoApellido = pSegundoApellido;
            this.Sexo = pSexo;
        }

        public int Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Sexo Sexo { get => sexo; set => sexo = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }

        //DEPURAR ESTE METODO POR MEDIO DE LA HERENCIA
        public virtual string getPersonalInformation()
        {
            string personalInformation = string.Empty;
            personalInformation += string.Format("DNI : {0} ", this.identificacion);
            personalInformation += string.Format("DNI (Letras) : {0} ", this.getDNI_letters());
            personalInformation += string.Format("Nombre Completo : {0} ", getNombreCompleto());
            personalInformation += string.Format("Sexo : {0} ", this.Sexo);

            return personalInformation;
        }

        public string getNombreCompleto()
        {
            return this.Nombre + " " + this.PrimerApellido + " " + this.SegundoApellido;
        }

        protected string getDNI_letters()
        {
            string[] dniVocab = new string[] { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            int divisor = 23, resultado = 0;
            string resultDNI = "No Disponible";

            if ((this.Identificacion.ToString().Length == 8))
            {
                resultado = this.Identificacion % divisor;

                if (resultado <= dniVocab.Length)
                {
                    resultDNI = dniVocab[resultado];
                }
            }

            return resultDNI;
        }
    }
}
