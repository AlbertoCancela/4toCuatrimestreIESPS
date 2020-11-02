using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorDiferencia
{
    class Program
    {

        static void MayorDif(int []arreglo, int [] Diferencia)
        {
            int MayorDif=0;

            for (int i=0;i<=3; i++)
            {
                Diferencia[i] = arreglo[i] - arreglo[i + 1];
                if(arreglo[i+1]>arreglo[i])
                {
                    Diferencia[i] *= -1;
                }
                Console.WriteLine(Diferencia[i]);

                if (Diferencia[i] > MayorDif)
                {
                    MayorDif = Diferencia[i];
                }
            }
            Console.WriteLine("El número mayor es: "+MayorDif);

        }
        static void Main(string[] args)
        {

            int[] arreglo = { 9, 4, 22, 6, 19 };
            int[] Diferencia = new int[4];
            MayorDif(arreglo, Diferencia);
            
            Console.Read();
        }
    }
}
