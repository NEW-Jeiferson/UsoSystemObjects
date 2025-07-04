using System;
//1

namespace Usosystemobjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Creacion de instancia Persona

            Persona persona = new Persona();
            persona.Nombre = "Petronila";

            //Uso de metodos de System.Object

            Console.WriteLine("ToString(): " + persona.ToString());
            Console.WriteLine("GetType(): " + persona.GetType());
            Console.WriteLine("GetHashCode(): " + persona.GetHashCode());

            //Vamos a comparar con otros objetos

            Persona otraPersona = new Persona();

            Console.WriteLine("Equals(otraPersona): " + persona.Equals(otraPersona));
            Console.ReadLine();

        }

        public class Persona
        {
            public string Nombre { get; set; }

            public override string ToString()
            {
                return $"Persona: {Nombre} ";
            }
        }
    }
}
