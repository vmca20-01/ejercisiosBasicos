using System;

namespace ejercisiosBasicos
{
    public class ListPersona
    {
        private static Persona[] listPersonas;
        private static int cont = 0;

        public ListPersona(int pCantPersona)
        {
            listPersonas = new Persona[pCantPersona];
        }

        public Persona[] getListPersona()
        {
            return listPersonas;
        }

        public bool AddPersona(Persona pPersona)
        {
            if ((listPersonas != null) && (listPersonas.Length > cont))
            {
                listPersonas[cont] = pPersona;
                cont++;
                return true;
            }

            return false;
        }

        public Persona FindPersona(int pIdentificacion)
        {
            Persona foundData = null;

            if ((listPersonas != null) && (listPersonas.Length > 0))
            {
                foreach (Persona pers in listPersonas)
                {
                    if (pers != null)
                    {
                        if (pers.Identificacion == pIdentificacion)
                        {
                            foundData = pers;

                            break;
                        }
                    }
                }
            }

            return foundData;
        }

    }
}
