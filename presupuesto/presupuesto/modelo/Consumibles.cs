using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presupuesto.modelo
{
    internal class Consumibles
    {
        private string nom;
        private int cant;
        private double precio; 

        private Presuppuesto presuppuesto;

        public Consumibles(string nom, int cant)
        {
            this.nom = nom;
            this.cant = cant;

            switch (this.nom) 
            {
                case "Aceite":
                    this.precio = 12.50 * this.cant; 
                    break;
                case "Filtro":
                    this.precio = 18 * this.cant; 
                    break;
                case "Pastillas":
                    this.precio = 45 * this.cant; 
                    break;
                case "Neumatico":
                    this.precio = 85 * this.cant; 
                    break;
            }

        }

        public string Nom { get => nom; set => nom = value; }
        public int Cant { get => cant; set => cant = value; }
        public double Precio { get => precio; set => precio = value; }
        internal Presuppuesto Presuppuesto { get => presuppuesto; set => presuppuesto = value; }
    }
}
