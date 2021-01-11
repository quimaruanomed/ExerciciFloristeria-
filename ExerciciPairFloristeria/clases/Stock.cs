using System;
using System.Collections.Generic;
using System.Text;
using ExerciciPairFloristeria.clases;

namespace ExerciciPairFloristeria.clases
{
    class Stock : Floristeria
    {
       
        
        public void ImpTot()
        {

            foreach (Floristeria n in nFStock)  // Método que imprimirá el stock actual
            {

                Console.WriteLine(n.nameFlorist +" " + n.trees + " " + n.heightTress + " " + n.priceTrees + " " + n.flowersColour + " " + n.priceFlowers + " " + n.decoration);



            }
        }
           

        }
        }

       


    

