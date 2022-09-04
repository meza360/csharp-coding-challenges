using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program
{
    public static class test9
    {
        /*
        Pregunta 1
Tienes un arreglo (llamado myArray) con 5 elementos (enteros en el rango de 1 a 100). Escribe un programa en C# que imprima el número más alto del arreglo (Si se repite, solo imprimir una vez). El programa solo debe imprimir el número, sin ningún texto.

El código que llena el arreglo ya está escrito, pero puedes editarlo para probar con otros valores. Con el botón de refrescar puedes recuperar el valor original que será utilizado para evaluar la pregunta como correcta o incorrecta durante la ejecución.

Nota: Asumir que esta escribiendo el codigo dentro de una clase, por lo que no debe declarar la clase en si, solo el metodo public static void main para ejecutar su código.
        */

        public static int solution()
        {
            int[] myArray = {13,2,4,35,1};
            int max = 0;
            foreach (var item in myArray)
            {
                if(item > max) max = item;
            }
            return max;

        }
    }
}