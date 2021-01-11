using System;
using System.Collections.Generic;
using System.Text;

namespace c
{
    class Floristeria
    {
        public string nameFlorist { get; set; }
        public string trees { get; set; }
        public string heightTress { get; set; }

        public string flowersColour { get; set; }

        public string decoration { get; set; }

        public string typeMat { get; set; }
        public string priceTrees { get; set; }

        public string priceFlowers { get; set; }

        public Floristeria()
        {

        }


            public static List<Floristeria>  nFStock= new List<Floristeria>
           {
               new Floristeria { nameFlorist = "Floristeria Summer" , trees= "Manzano-5, Naranjo-4, , Olivo-3, Pino-7", heightTress="15, 20, 75, 40" ,  flowersColour= "Amapolas-Blancas, Rosas-Rojas, Rosas-Blancas, Margaritas-Amarillas" ,
                    typeMat ="Madera, Plástico", priceTrees="30, 35, 15, 20", priceFlowers= "40, 20, 30, 15"} };
    }



}


