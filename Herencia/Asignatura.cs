using System;

namespace ejercisiosBasicos
{
    public class Asignatura
    {
        private string nombreAsignatura;
        private double notaAsignatura;
        private Estudiante estudiante;

        public Asignatura() { }

        public Asignatura(string pNombreAsignatura, double pNotaAsignatura)
        {
            this.NombreAsignatura = pNombreAsignatura;
            this.NotaAsignatura = pNotaAsignatura;
        }

        public string NombreAsignatura { get => nombreAsignatura; set => nombreAsignatura = value; }
        public double NotaAsignatura { get => notaAsignatura; set => notaAsignatura = value; }
        public Estudiante Estudiante { get => estudiante; set => estudiante = value; }

        public string estadoAsignatura()
        {
            string status = string.Empty;

            if ((this.NotaAsignatura >= 0) && (this.NotaAsignatura <= 4.99))
            {
                status = "Suspenso";
            }
            else if ((this.NotaAsignatura >= 5) && (this.NotaAsignatura <= 6.99))
            {
                status = "Bien";
            }
            else if ((this.NotaAsignatura >= 7) && (this.NotaAsignatura <= 8.99))
            {
                status = "Notable";
            }
            else if ((this.NotaAsignatura >= 9) && (this.NotaAsignatura <= 10))
            {
                status = "Sobresaliente";
            }
            else
            {
                status = "Sin especificar";
            }

            return status;
        }

        public string listarAsignaturas(Asignatura[] pListaAsignatura)
        {
            string data = string.Empty;

            if (pListaAsignatura.Length > 0)
            {
                foreach (Asignatura asign in pListaAsignatura)
                {
                    if (asign != null)
                    {
                        if (asign.Estudiante != null)
                        {
                            data += string.Format("\nEstudiante : {0} Asignatura : {1} Nota {2} ", asign.Estudiante.getNombreCompleto(), asign.NombreAsignatura, asign.NotaAsignatura);
                        }
                    }
                }
            }

            return data;
        }
    }
}
