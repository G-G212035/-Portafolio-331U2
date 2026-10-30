using System;
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Unidad 1: Estructuras de control 2
            Unidad 2: Funciones II
            Sesion 12: Instruccion while 30/Sep/2026

            // Sintaxis: while 

            inicializacion;
            while(expresion)
                {
                    Bloque de instrucciones
                    Iterador;
                }

                Iterar = repetir (Osea, el iterador en este caso va a ser la instruccion que me permite continuar o terminar el ciclo, y su funcion es llegar hasta la "funcion bandera")
                Sintaxis = el orden en el codigo en el que deben de tener los elementos
             */
    
            // Ejemplo 1: Ciclo ascendente (rango: 1-3)
            // m: variable de control
            int m = 1; //Inicializacion (Nuestra variable de control sera "m")
            while(m <= 3) // Expresion
            {
                // Bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1; // Iterador
            }

            // Ejercitacion
            //1. Definir un ciclo para imprimir tu nombre 5 veces
            // Nota. para la expresion utiliar el operador <

            // a. Ciclo Asdendente
            int n = 1;
            while(n < 6)
            {
                Console.WriteLine("Gonzalo J.");
                n += 1;
            }


            // b. Ciclo descendente
            int b = 3;
            while(b >= 1)
            {
                Console.WriteLine($"d: {b}");
                b -= 1; // Iterador
            }


            // c. Incrementos
            // Secuencia: 3 6 9 12 15 18
            int c = 3;
            while(c <= 18)
            {
                Console.WriteLine($"Secuencia: {c}");
                c += 3;

            }
            // d. Decrementos
            // Ejercitacion.
            // 1. Definir un ciclo para imprimir "331" 8 veces.
            // Nota: Para la solucion, define un ciclo descendente con decrementos de 2 unidades.
            int d = 16;
            while(d > 0)
            {
                Console.WriteLine($"331");
                d -= 2;
            }

            // Actividad 1: Ciclo Infinito
            // 1. Definir un ciclo infinito ascendente.
            // 2. Definir un ciclo infinito descendente.
            // Nota: Para la solucion, utiliza el operador de diferencia.
            int e = 1;
            while(e != 0 == true)
            {
                Console.WriteLine($"e: {e}");
                e += 1;
            }

            int f = -1;
            while(f != 0 == true)
            {
                
                f -= 1;
            }
        }
    }
}
