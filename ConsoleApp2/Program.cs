using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //el try y catch lo usamos ya que si el usuario teclea un valor distinto al int nos marcara un error
            //de esta manera si pasa, no se cerrara el programa y nos pedira los datos nuevamente
            
            
            /*LOS ARRAYS LOS ESTAMOS DEJANDO  ESTATICOS YA QUE EL USUARIO SOLO INDICARA LAS PELICULAS QUE DESEA
             EL NO VA A INGRESAR LOS PRECIOS Y PELICULAS, ES POR ELLO QUE SE ESTAN MANEJANDO ESTATICAMENTE.
             PENSABAMOS UTILIZAR UN DICTIONARY QUE ES EL EQUIVALENTE AL HASHMAP EN JAVA PERO NECESITAMOS ANALIZAR LOS METODOS DE ESTE
             YA QUE AUN NO ESTAMO FAMILIARIZADOS DEL TODO CON EL DICTIONARY*/
            
            
            try
            {
                //Se usaran 2 arrays, uno almacena las peliculas y en el otro el precio de cada pelicula, siguiendo ese orden
                string[] peliculas = new string[5]
                    {"MI5", "KUNFU PANDA", "FURY", "PASION Y GLORIA", "CONTRA LA IMPOSIBLE"};
                int[] precios = new int[5] {250, 150, 180, 300, 350};
                //este array sera de apoyo para guardar los indeces de pelicula que el usuario seleccion       
                int[] indices = new int[3];
                //array de auxiliar para guardar los precios de las peliculas que seleccionemos
                int[] costo = new int[3];
                //variable auxiliar que se usara en un ciclo
                int auxiliar = 0;
                Console.WriteLine("Listado de las peliculas en Existencia");
                //este for recorre ambos array (peliulas y costos) 
                for (int i = 0; i < 5; i++)
                {
                    //se imprime la pelicula en el indice de iteracion con el precio que esta almacenado en el mismo indice.
                    Console.WriteLine((i + 1) + " " + peliculas[i] + " -- $" + precios[i]);
                }
                //ciclo para pedirle al usuario las 3 peliculas que desea
                for (int j = 0; j <= 2; j++)
                {
                    //se pide el numero de la pelicula indicando la iteracion + 1 ya que recordemos la iteracion comienza en cero 
                    Console.WriteLine("\nIndique las pelicula No: " + (j + 1));
                    //guardamos cada numero de la pelicula en la posicion que este el recorrido
                    indices[j] = int.Parse(Console.ReadLine());
                }
                //ciclo para guardar en un array el precio de cada una de las peliculas seleccionadas.
                for (int k = 0; k <= 2; k++)
                {
                    //esta variable auxiliar nos ayuda a guardar temporalmente el precio  de la pelicula que fueron seleccionadas 
                    int aux = indices[k];
                    /*nuestro array de costos va a guardar en el indice segun la iteracion
                     el precio que esta almacenado en el array de precios en la posicion que se pidio en el bucle anterior pero recordemos que 
                     si el usuario indico la pelicula numero 1, en el array la posicion 1 es el indice 0
                     por eso a $aux le restamos uno*/
                    costo[k] = precios[(aux - 1)];
                    //por ultimo aca hacemos la suma de los precios de las peliculas que fueron solicitadas
                    //vamos a guardar en cada iteracion el valor que haya en la variable $auxiliar y se le sumara el precion que este guardado en el array costos
                    //que se esta ejecutando en la parte superior
                    auxiliar += costo[k];
                }
                /*como las instrucciones piden que solo cobremos el total de las peliculas mas baratas
                 entonces debemos restar de ese total el precio mas alto que este almacenado en el array de costos
                 por eso a la variable auxiliar que es la que guarda la sumatoria de todos los precios le restamos el valor maximo del array
                 atraves de un metodo que recorre el array y retorna el valor mas grande, es decir la pelicula mas cara, dejando las mas baratas*/
                auxiliar = (auxiliar - costo.Max());
                //por ultimo solo imprimos el resultado de la operacion anterior dejandonos los precios menores unicamente
                Console.WriteLine("El total a pagar es de: " + auxiliar);
            }
            //esta seccion es la encargada de cachar los errores y en lugar de terminar el programa y marcar un error nos muestra el mensaje de su interior 
            //y repite el try las veces que sean necesarias es decir que no se cometa un error
            catch (Exception ex)
            {
                //cuando surja cualquier error se mos muestra el mensaje y se repite el try
                Console.WriteLine("Introdujo un caracter invalido");
            }
            //fin del programa.
        }
    }
}
