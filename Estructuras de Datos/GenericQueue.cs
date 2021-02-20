using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercisiosBasicos.Estructuras_de_Datos
{
    public class GenericQueue<T> : IQueueStructure<T>
    {
        private T[] array;
        private static int cont = 0;

        public GenericQueue() { }

        public GenericQueue(int pCantElements)
        {
            array = new T[pCantElements];
            cont = 0;
        }

        public void Enqueue(T pObject)
        {
            array[cont] = pObject;
            cont++;
        }

        public void Dequeue()
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
