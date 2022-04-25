using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIFA.clases
{
    internal class LaRifa
    {


        public int alealtorio(int no1, int no2)
        {
            Random random = new Random();
            return random.Next(1,9);

          
        }


        public void sorteo(string[] participantes, int  premio )
        {

            for (int i = 1; i <= premio; i++)
            {



                int final = alealtorio(0, participantes.Length);

                

               
                Console.WriteLine($"Sorteo {i} Ganador = {final}");
                Console.WriteLine($"El ganador es {participantes[final]}\n");

            }



        }

    }

}
