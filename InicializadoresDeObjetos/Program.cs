using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicializadoresDeObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");
            //Inizializadores de objetos y colecciones , un inicializador de objetos es una sintaxis especial que nos permite asignar valores a cualquier campo de una manera mas clara sin tener que acudir a un constructor.

            /*Clase / estructura objeto = new Clase / Estructura
                
                {
                    campo1 = valor1,
                    campo2 = valor2,
                    campo3 = valor3

                };*/
            //instanciamos y usamos un inicializador de objetos
            Persona persona1 = new Persona
            {
                Nombre = "LARRYSALSA",
                Apellido = "timba",
                Edad = 45
            };
            Console.WriteLine(persona1.ToString());

        }
       
    }
    struct Persona
    {
        //Campos
       string nombre;
         string apellido;
         int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }



        //Invalidamos al metodo ToString
        public override string ToString()
        {
            string mensaje = $"Nombre: {Nombre}\nApellido: {Apellido}\nEdad: {Edad}";
            return mensaje;
        }

    }
}
