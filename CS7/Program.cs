using System;
using System.Security.Cryptography;
namespace CS7
{
    class Program
    {
        static void Main(string [] args)
        {
            // Sesion 15. Funciones    Oct/15/2026
            /* 
            Funcion: Es un bloque de instrucciones para realizar una tarea especifica, que se ejecuta
            unicamente, cuando es invocado.

            Sintaxis    (para definir una funcion)
            Definiciones: tipo_dato_devuelto, se refiere a que dato es el que se entrega (ej. int, bool, string)     
            identificador_funcion, el nombre que se le otorga a la funcion
            Parametros: variables 
            Argumentos: Es el valor del parametro (ej. Console.WriteLine("Hola"), el "Hola" en este caso sera nuestro argumento)

            tipo_dato_devuelto identificador_funcion (parametros) 
            {
                Bloque de instrucciones
            }

            Nota 1: Los parametros se definen con el tipo de dato.
            Nota 2: Los parametros van separados por comas.

            Sintaxis: Invocacion funcion
            identificador_funcion(argumentos);

            */
            // Ejemplo 1: Funcion vacia sin parametros
            // Definicion:
            void Saludar()
            {
                string salon = "Exactas 331";
                Console.WriteLine($"Hola, {salon}!");
            }
            // Invocacion
            Saludar();
            // Ejercitacion:
            // 1. Definir e invocar una funcion sin parametros para imprimir: Nombre, clave y salon.
            void datos()
            {
                string datos = "Nombre: Gonzalo J., Clave: 17, Salon: 331";
                Console.WriteLine($"Datos: {datos}");
            }
            datos();
            // Ejercico 2. Definir e invocar una funcion para desplegar el horario de hoy.
            void horario()
            {
                string c1 = "Calculo";
                string c2 = "FH";
                string c3 = "Programacion";
                string c4 = "Psicologia";
                string c5 = "Idiomas";
                string c6 = "Dibujo Tecnico";
                string r = "Recreo";
                Console.WriteLine($"Las clases del dia son: \n {c1} \n 7:00-7:50\n {c2} \n 7:50-8:40\n {c3} \n 8:40-9:30\n {r} \n 9:30-9:50\n {c4} \n 9:50-10:40\n {c5} \n 10:40-11:30\n {r} \n 11:30-11:50\n {c6} \n 11:50-1:30");

            }
            horario();

            // Sesion 16: Funcion con parametros
            // return: Palabra reservada para terminar una funcion y devolver una expresion
            // Ejemplo 1: Doble
            // Definicion de la funcion
            int CalcularDoble(int numero)
            {
                int resultado = 2 * numero;
                return resultado;
            }
            // Invocacion
            int devolucion;
            devolucion = CalcularDoble(9);
            Console.WriteLine($"Devolucion: {devolucion}");
            // Ejercitacion:
            // 1. Definir e invocar una funcion que devuelva la evaluacion de la siguiente expresion: f(x) = 4x - 7/5
            double funcionfx(double numero2)
            {
                double resultado = (4 * numero2) - (7 / 5D); 
                return resultado;
            }
            double devolucion2;
            devolucion2 = funcionfx(1);
            Console.WriteLine($"Evaluacion: {devolucion2}");

        }
    }
}
