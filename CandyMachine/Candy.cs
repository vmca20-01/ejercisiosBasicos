using System;
using System.Collections.Generic;
using System.Text;

namespace ejercisiosBasicos
{
    public class Candy
    {
        private string codCandy;
        private string name;
        private double price;
        private int cant;

        public Candy() { }

        public Candy(string pCodCandy, string pName, double pPrice, int pCant)
        {
            this.CodCandy = pCodCandy;
            this.Name = pName;
            this.Price = pPrice;
            this.Cant = pCant;
        }

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Cant { get => cant; set => cant = value; }
        public string CodCandy { get => codCandy; set => codCandy = value; }

        public string disponibilidad()
        {
            if (this.Cant > 0)
            {
                return "Disponible";
            }
            else
            {
                return "No Dispnible";
            }
        }
    }

}
