using System;
using ExerciciPairFloristeria.clases;
using System.Collections.Generic;


namespace ExerciciPairFloristeria
{
    class Program
    {
        static void Main(string[] args)
        {


            string nameFlorist;
            List<Floristeria> nF = new List<Floristeria>();
            ConsoleKeyInfo op;
            string dec;


            do
            {
                Console.WriteLine("*********************");
                Console.WriteLine("**********************");
                Console.WriteLine("Bienvenido a Floristeria");
                Console.WriteLine("Opciones:" +
                      "\n A.-Crear Floristeria" +
                      "\n B.-Añadir Arbol " +
                      "\n C.-Añadir Flor  " +
                      "\n D.-Añadir Decoración" +
                      "\n E.-Ver Stock" +
                      "\n G.-Salir: Pulsa la tecla ESC"
                       );


                op = Console.ReadKey(true);

                switch (op.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine();
                        Console.WriteLine("Escribe el nombre de la Floristeria");
                        nameFlorist = Console.ReadLine();
                        nF.Add(new Floristeria() { nameFlorist = nameFlorist });

                        break;

                    case ConsoleKey.B:
                        Console.WriteLine();
                        Console.WriteLine("Nombre del árbol:");
                        string nameTreeF = Console.ReadLine();
                        Console.WriteLine("Altura del árbol:");
                        double hTress = Convert.ToDouble(Console.ReadLine());
                        string hT = hTress.ToString();
                        Console.WriteLine("Precio del árbol:");
                        string priceTreeF = Console.ReadLine();

                        nF.Add(new Floristeria() { trees = nameTreeF, heightTress = hT, priceTrees = priceTreeF });

                        Console.WriteLine("El count es: " + nF.Count); //Con esta instrucción averiguamos cuantos elementos tiene Floristeria

                        break;

                    case ConsoleKey.C:
                        Console.WriteLine();
                        Console.WriteLine("Nombre de la Flor:");
                        string nFlowerC = Console.ReadLine();
                        Console.WriteLine("Precio de la Flor: ");
                        double pFlow = Convert.ToDouble(Console.ReadLine());
                        string pF = pFlow.ToString();
                        nF.Add(new Floristeria() { flowersColour = nFlowerC, priceFlowers = pF });
                        Console.WriteLine("El count con flor es: " + nF.Count);
                        break;

                    case ConsoleKey.D:
                        Console.WriteLine();

                        do
                        {
                            Console.WriteLine(" Decoraciones disponibles: Madera y Plastico");

                            dec = Console.ReadLine();

                        } while ((dec != "Madera") && (dec != "Plastico"));

                        nF.Add(new Floristeria() { decoration = dec });
                        Console.WriteLine("El count con flor es: " + nF.Count);
                        Console.WriteLine();
                        break;

                    case ConsoleKey.E:
                        Console.WriteLine("El stock es:");
                        if (nF.Count != 0) // con está instrucción controlamos si se ha creado una nueva floristeria, sino se ha creado mostrará solo el stock actual

                        {
                            Console.WriteLine("Floristeria: " + nF[0].nameFlorist);
                            foreach (Floristeria n in nF)
                            {
                                Console.WriteLine(n.trees + " " + n.heightTress + " " + n.priceTrees + " " + n.flowersColour + " " + n.priceFlowers + " " + n.decoration);
                            }
                        }
                        Stock stock = new Stock();
                        stock.ImpTot(); //Método de la clase Stock que mostrará el stock antes de crear ninguna floristeria nueva 


                        break;


                    default:

                        Console.WriteLine();
                        Console.WriteLine("Opción no valida");
                        Console.WriteLine();
                        break;

                    case ConsoleKey.Escape:
                        break;

                }

                } while (op.Key != ConsoleKey.Escape) ; //condición que cierra el switch case

            }
            }
    }

    


        
        

    
