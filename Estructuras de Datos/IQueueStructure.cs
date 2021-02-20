namespace ejercisiosBasicos.Estructuras_de_Datos
{
    interface IQueueStructure<T>
    {
        void Enqueue(T pObject);

        void Dequeue();
    }
}