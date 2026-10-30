using System;
namespace CS6
{
    class Program
    {
        static void Main(string []args)
        {
            // Sesion 13: Iteradores            Oct/8/2026
            // 1. Ciclo for
            /*
            for(inicializacion; expresion; iterador)
            {
                // Bloque de instrucciones
            }
            */
            // Ejemplo: Secuencia 35-41
            for (int platano= 35; platano <= 41; platano ++)
            {
                Console.WriteLine($"m: {platano}");
            }
            // Sesion 14, Ciclo for             Oct/14/2026

            // En C#, puedes hacer un "Salto de linea" adentro de tu codigo para poder organizar este mismo
            // Este se hace con el simbolo      \n
            // Ejemplo:
            string ab = "Hola";
            string ba = "Crayola";
            Console.WriteLine($"{ab}\n{ba}");
            // En consola, la variable "Hola" se imprime en la primera linea, y la variable "Crayola" en la siguiente, dandonos a ver que 
            // Esta cumple la instruccion poniendo las 2 lineas en el codigo: dejando ver en consola:
            // Hola
            // Crayola

            //1. Definir un ciclo for para la siguiente secuencia: -33, -34, -35 , -36, -37 , -38, -39
            // (Ciclo editado para imprimir en ascendente con variable negativa)
            for (int c = -33; c >= -39; c -= 1)
            {
                Console.WriteLine($"C positivo: {c * -1}");
            }
            Console.WriteLine("Ciclo 2: Acendente");
            for (int a = 9; a <= 15; a++)
            {
               if (a == 13 == false)
               Console.WriteLine($"a: {a}");
            }
            // Incluir las instrucciones para omitir el 13

            // Ejercicio de examen 2:
            // Un libro tiene un titulo distinto por cada 88 paginas, teniendo el 1ro en la pagina 1, el libro tiene 539 paginas
            int titulo = 1;
            int sig_titulo = 1;
            for (int pagina = 1; pagina <= 539; pagina ++)
            {
                if (pagina >= sig_titulo)
                {
                Console.WriteLine($"Titulo {titulo} en la pagina {sig_titulo}");
                titulo ++;
                sig_titulo += 88;   
                }
                
            }
        }
    }
}
