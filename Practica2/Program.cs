/*1) El tipo object es un tipo referencia, por lo tanto luego de la sentencia o2 = o1 ambas variables están
apuntando a la misma dirección. ¿Cómo explica entonces que el resultado en la consola no sea “Z Z”?
*/

// object o1 = "A";
// object o2 = o1;
// o2 = "Z";
// Console.WriteLine(o1 + " " + o2);
// aunque se pasen por referencia las cadenas de string son imutables 

// 2) Qué líneas del siguiente código provocan conversiones boxing y unboxing.

// char c1 = 'A';
// string st1 = "A";
// object o1 = c1; // boxing 
// object o2 = st1;// no es boxing porque un string ya es de tipo referencia 
// char c2 = (char)o1; //unboxing 
// string st2 = (string)o2; //no requiere unboxing porque ya es de tipo referencia debido que es un string 


//3) ¿Qué diferencias existen entre las conversiones de tipo implícitas y explícitas?

// es que las implicitas son seguras y automaticas, no requieren sitaxis especial .
// en cambio las explicitas requieren que se casten , pueden ser no seguras y pueden ocacionar perdidas de datos


// 4) Resolver los errores de compilación en el siguiente fragmento de código. Utilizar el operador as
// cuando sea posible.
// object o = "Hola Mundo!";
// string? st = o as string ;
// int i = 12;
// byte b = (byte)i;
// double d = i;
// float f =(float)d;
// o = i;
// i =(int) o + 1 ;


//6) Supongamos que Program.cs sólo tiene las siguientes dos líneas:
// int i;
// Console.WriteLine(i);
// no compila porque se quiere imprimir una variable sin direccion de memoria 


// 8) Investigar acerca de la clase StringBuilder del espacio de nombre System.Text ¿En qué
// circunstancias es preferible utilizar StringBuilder en lugar de utilizar string? Implementar un
// caso de ejemplo en el que el rendimiento sea claramente superior utilizando StringBuilder en lugar
// de string y otro en el que no.
// se requiere usar stringbuilder siempre y cuando necesites hacer varias modificaciones a un string
// por ejemplo dentro de un while o un for 
// using System;
// using System.Text;
// int iterations = 10000;

// // Usando StringBuilder
// StringBuilder sb = new StringBuilder();
// for (int i = 0; i < iterations; i++)
// {
//     sb.Append("A");
// }
// Console.WriteLine("StringBuilder length: " + sb.Length);

// // Usando string
// string str = "";
// for (int i = 0; i < iterations; i++)
// {
//     str += "A";
// }
// Console.WriteLine("String length: " + str.Length);

// 9) Investigar sobre el tipo DateTime y usarlo para medir el tiempo de ejecución de los algoritmos
// implementados en el ejercicio anterior.

//DateTime 
// es una estructura inmutable, sirve para representar instantes de tiempo 
// expresados como una fecha y hora de un dia 
// la precision es de hasta 100 nanosegundos 

// int length = 1000;
// DateTime inicio= DateTime.Now;
// string palabra = "" ;
// for (int i = 0; i < length; i++)
// {
//     palabra += i;
// }
// DateTime fin = DateTime.Now;
// Console.WriteLine("tiempo de ejecucion es, " + (fin-inicio));