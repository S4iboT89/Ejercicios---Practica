using System;

    namespace Ejercicio_parcial1
    {

    class Program
    {

        static void Main(string[] args)

            //Total de socios 835. Socios habilitados para votar 50% = 418 Aproximadamente
        {
            int[] votacion = new int[418];
            int Blanco=0, Lista1=0, Lista2=0, Lista3=0, Nulos=0;

            var seed = Environment.TickCount;
            var rand = new Random(seed);

            var socios = rand.Next(0, 418);

            Console.WriteLine($"Cantidad de socios que asistieron: {socios}");
            Console.Write("\n");

            for (int i = 0; i < 418; i++)
            {
                votacion[i] = 0;
            }


            for (int x = 1; x <= socios; x++)
            {
               
                seed = Environment.TickCount;
                var rand1 = new Random(seed);
                var votos = rand1.Next(0, 5);
                votacion[x] = votos;
                Console.WriteLine($"Votacion {x}={votos}");
                Console.Write("\n");

                if (votacion[x] == 0)
                {
                    Blanco++;
                }
                    if (votacion[x] == 1)
                    {
                        Lista1++;
                    }
                        if (votacion[x] == 2)
                        {
                            Lista2++;
                        }
                            if (votacion[x] == 3)
                            {
                                Lista3++;
                            }

                                if (votacion[x] == 4)
                                {
                                    Nulos++;
                                }
 
            }

            var porcL1 = (float)(Lista1) / (socios - (Nulos + Blanco)) *100;
            var porcL2 = (float)(Lista2) / (socios - (Nulos + Blanco)) *100;
            var porcL3 = (float)(Lista3) / (socios - (Nulos + Blanco)) *100;
            


            Console.WriteLine("\t ***Resultados de la votacion***");
            Console.Write("\n");
            Console.WriteLine($"Lista 1 - Cantidada de votos:{Lista1} - {porcL1:N2} %");
            Console.WriteLine($"Lista 2 - Cantidada de votos:{Lista2} - {porcL2:N2} %");
            Console.WriteLine($"Lista 3 - Cantidada de votos:{Lista3} - {porcL3:N2} %");
            Console.Write("\n");
            Console.WriteLine($"Votos Nulos:{Nulos}");
            Console.WriteLine($"Votos en Blanco:{Blanco}");
            Console.Write("\n");
            Console.WriteLine($"Total de votantes:{socios}");
            Console.Write("\n");

            if (Lista1 > Lista2 && Lista1 > Lista3)
                {
                Console.WriteLine("La lista ganadora es la 1");
                }
            if (Lista2 > Lista1 && Lista2 > Lista3)
                {
                Console.WriteLine("La lista ganadora es la 2");
                }
            if (Lista3 > Lista2 && Lista3 > Lista1)
                {
                Console.WriteLine("La lista ganadora es la 3");
                }
        }

    }
    }