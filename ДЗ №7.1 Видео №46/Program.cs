using System;

namespace ДЗ__7._1_Видео__46
{
    class Program
    {
        
            static int Keu(int[] masiv, int ox)
            {
                for (int i = 0; i < masiv.Length; i++)
                {
                    if (masiv[i] == ox)
                    {
                        return i;
                    }

                }

                return -1;
            }
            static void Main(string[] args)
            {
                int[] dog = { 3, 1, 5, 26, 1 };
                int cat = Keu(dog, 26);

                Console.WriteLine(cat);
                Console.ReadLine();
            }
        }

    }
