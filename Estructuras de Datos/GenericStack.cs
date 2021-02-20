using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercisiosBasicos.Estructuras_de_Datos
{
    public class GenericStack<T> : IStackStructure<T>
    {
        private T[] array;
        private static int cont = 0;

        public GenericStack() { }

        public GenericStack(int pCantElements)
        {
            array = new T[pCantElements];
            cont = pCantElements - 1;
        }

        public void Pop()
        {
            for (int i = 0; i < array.Count(); i++)
            {
                if (!array[i].Equals(default(T)))
                {
                    array[i] = default(T);
                    break;
                }
            }
        }

        public void Push(T pObject)
        {
            array[cont] = pObject;
            cont--;
        }

        public override string ToString()
        {
            string nString = string.Empty;

            for (int i = 0; i < array.Count(); i++)
            {
                nString += "\n" + i + "=>" + array[i];
            }

            return nString;
        }

    }
}
