using System;

namespace PruebaSerie
{
    class PruebaSerie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binvenido a la clase Serie, \n" + "Por favor ingrese los datos siguientes para completar la informacion de la serie: \n");
            int temporadas;
            string titulo;
            string genero;
            string creador;

            int opcionConstructor = 0;
            

            Console.WriteLine(" Podrias insertar el titulo: \n");
            titulo = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine(" Podrias insertar el genero: \n");
            genero = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine(" Podrias insertar las temporadas: \n");
            temporadas = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine(" Podrias insertar el creador: \n");
            creador = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Este apartado es para escoger un constructor que muestre los datos que pusiste, \n" + "Por favor, escoge alguna de nuestros 3 constructores: \n" +
        "1)   Constructor #1 \n" +
              "Descrpcion: mostrara todo los datos insertados anteriormente excepto la entrega \n" +

        "2)   Constructor #2 \n" +
              "Descrpcion: mostrara los datos titulo y creador que insertastes, todo lo demas datos se generaran por defecto \n");
            Console.WriteLine("\n" +

          "3)   Constructor #3 \n" +
                "Descripcion: mostrara todo los datos por defecto excepto entregar \n");


            do
            {

                Console.WriteLine("Opcion a escoger: \n");

                opcionConstructor = int.Parse(Console.ReadLine());

                Console.WriteLine("Opcion escogida \n" + opcionConstructor + "\n");
                Console.WriteLine("Error, por favor introduzca un numero que coincide con las opciones mostradas: \n" +

                 "1) Constructor #1 \n" +
              "Descrpcion: mostrara todo los datos insertados anteriormente excepto la entrega \n" +

          "2) Constructor #2 \n" +
              "Descrpcion: mostrara los datos titulo y creador que insertastes, todo lo demas datos se generaran por defecto \n");
                Console.WriteLine("\n" +

          "3) Constructor #3 \n" +
                    "Descripcion: mostrara todo los datos por defecto excepto entregar \n");
            } while (opcionConstructor != 1 && opcionConstructor != 2 && opcionConstructor != 3);
         
            switch (opcionConstructor)
                    {
                        case 1:
                            Console.WriteLine("Opcion escogida: \n" + opcionConstructor + ") Constructor #1: \n");
                            Serie Serie1 = new Serie();
                            Serie1.setTitulo(titulo);
                            Serie1.setGenero(genero);
                            Serie1.setTemporadas(temporadas);
                            Serie1.setCreador(creador);

                            Console.WriteLine(Serie1.MuestraMensaje());

                            break;
                        case 2:
                            Console.WriteLine("Opcion escogida: \n" + opcionConstructor + ") Constructor #2: \n");
                            Serie Serie2 = new Serie(titulo, creador);
                            Serie2.setTitulo("");
                            Serie2.setCreador("");
                            Console.WriteLine(Serie2.MuestraMensaje1());

                            break;
                        case 3:
                            Console.WriteLine("Opcion escogida: \n" + opcionConstructor + ") Constructor #3: \n");
                            Serie Serie3 = new Serie();
                            Console.WriteLine("Serie 3");
                            Console.WriteLine(Serie3.MuestraMensaje2());
                            break;
                    }
                }


        

    }
}


            

           
        



   
