using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program
{
    public static class test10
    {
        /*
        Pregunta 2
Escribir un programa en C# que recorra un arreglo y genere un histograma en base a los números de este. El arreglo se llama myArray y contiene 10 elementos que corresponden a números enteros del 1 al 5. Un histograma representa que tanto un elemento aparece en un conjunto de datos (Debe mostrar la frecuencia para todos los números del 1 al 5, incluso si no están presentes en el arreglo). Por ejemplo, para el arreglo: myArray:=(1,2,1,3,3,1,2,1,5,1) el histograma se vería así:

1: *****
2: **
3: **
4:
5: *

El código para declarar y poblar myArray ya está ahí, puede editarlo para probar con otros valores y puede hacer clic en el botón de actualizar junto a él para volver al valor original que se utilizará para validar su código durante la prueba. Asegúrese de que los resultados se impriman exactamente como aparecen aquí, ya que incluso un espacio faltante o sobrante puede marcar la pregunta como incorrecta (Notar espacio entre los ":" y el primer asterisco).

Nota: Asumir que esta escribiendo el codigo dentro de una clase, por lo que no debe declarar la clase en si, solo el metodo public static void main para ejecutar su código.
        */
        public static void solution(int[] numbers)
        {
            int n = numbers.Length;

            bool[] exists = new bool[n];
            for (int i = 1; i <= 5; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (exists[j] == true)
                        continue;
                    if (numbers[j] == i)
                    {
                        exists[j] = true;
                        count++;
                    }
                }
                Console.Write(i + ": ");
                for (int k = 0; k < count; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();

            }
        }
    }
}