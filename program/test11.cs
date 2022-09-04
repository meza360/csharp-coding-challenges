using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program
{
    public static class test11
    {
        /*
        Pregunta 3
Tienes un arreglo (llamado myArray) con 10 elementos (enteros en el rango de 1 a 9). Escribe un programa que imprima el número que tiene más ocurrencias seguidas en el arreglo y también imprimir la cantidad de veces que aparece en la secuencia.

El código que llena el arreglo ya está escrito, pero puedes editarlo para probar con otros valores. Con el botón de refrescar puedes recuperar el valor original que será utilizado para evaluar la pregunta como correcta o incorrecta durante la ejecución.

Su programa escrito en C# debe analizar el arreglo de izquierda a derecha para que en caso de que dos números cumplan la condición, el que aparece por primera vez de izquierda a derecha será el que se imprima. La salida de los datos para el arreglo en el ejemplo (1,2,2,5,4,6,7,8,8,8) sería la siguiente:
Longest: 3
Number: 8

En el ejemplo, la secuencia más larga la tiene el número 8 con una secuencia de tres ochos seguidos. Tenga en cuenta que el código que escriba debe imprimir los resultados exactamente como se muestra con el fin de que la pregunta sea considerada válida.

El código para declarar y poblar myArray ya está ahí, puede editarlo para probar con otros valores y puede hacer clic en el botón de actualizar junto a él para volver al valor original que se utilizará para validar su código durante la prueba.

Nota: Asumir que esta escribiendo el codigo dentro de una clase, por lo que no debe declarar la clase en si, solo el metodo public static void main para ejecutar su código.
        */
        public static void solution(int[] numbers)
        {
            int arrLenght = numbers.Length;
            int[,] sorted = new int[arrLenght, 2];
            var count = 0;
            var current = 0;
            int max = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                //prevents null or empty spaces
                sorted[j, 0] = 0;
                sorted[j, 1] = 0;
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                current = numbers[j];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if(current == numbers[i]) count++;
                }
                sorted[j,0] = current;
                sorted[j,1] = count;
                count = 0;
            }

            count = 0;
            for (int i = 0; i < arrLenght; i++)
            {
                if(sorted[i,1] > count)
                {
                    count = sorted[i,1];
                    max = sorted[i,0];
                }
            }
            Console.WriteLine($"Longest: {count}");
            Console.WriteLine($"Number: {max}");
        }
    }
}