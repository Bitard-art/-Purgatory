using System;

namespace Dz_8_Видео_56
{
    class Program
    {
        // Часть 1
        static void Resize(ref int[] flo, int scr)
        {
            int[] pudge = new int[scr];

            for (int i = 0; i < flo.Length && i < pudge.Length; i++)
            {
                pudge[i] = flo[i];
            }
            flo = pudge;
        }
        static void Main(string[] args)
        {
            int[] Dota = { 5, 1, 4, 6, 22 };


            Program.Resize(ref Dota, 12);


            Console.ReadLine();
        }

        // Часть 2
        static void crah(ref int[] array, int valw, int index)
        {
            int[] nu = new int[array.Length + 1];
            nu[index] = valw;

            for (int i = 0; i < index; i++)
                nu[i] = array[i];

            for (int i = index; i < array.Length; i++)
            {
                nu[i + 1] = array[i];

                array = nu;
            }
        }
      
        
        static void RP(ref int[] array, int valw)
        {
            crah(ref array, valw, 0);
        }
        static void Fp(ref int[] array, int valw, int index)
        {
            crah(ref array, valw, array.Length);
        }



        static void light(string[] args)
        {
            int[] skap = { 1, 9, 15, 8 };
            crah(ref skap, -2, 8);
            
        }



        // Часть 3
        static void mov(ref int[] array, int index)
        {
            int[] ful = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                ful[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
                ful[i - 1] = array[i];

            array = ful;
        }

        static void fics(ref int[] array)
        {
            mov(ref array, 0);
        }
       
        
        static void last(ref int[] array)
        {
            mov(ref array, array.Length - 1);
        }
        
        
        static void NoMain(string[] args)
        {
            int[] myArray = { 2, 5, 4, 1 };
        }
    }
}

