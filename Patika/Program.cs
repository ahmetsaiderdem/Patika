using System;

namespace Patika
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("bir sayı girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string[] Kelimeler = new string[sayi];
            for (int i = 0; i < Kelimeler.Length; i++)
            {
                Kelimeler[i] = Console.ReadLine();

            }
            Array.Reverse(Kelimeler);
            foreach (var item in Kelimeler)
            {
                Console.WriteLine(item);
            }









            Console.Write("İki sayı girin :");
            int[] nums = new int[2];


            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("bir sayı girin:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < 1; i++)
            {
                if (nums[1] == sayi && nums[1] % sayi == 0)
                {
                    Console.WriteLine(sayi1);
                }
                else
                {
                    Console.WriteLine("yanlış sayı girdiniz");
                }
            }
            foreach (var item in nums)
            {

                if (item == sayi && item % 2 == 0)
                {


                    Console.WriteLine(sayi);


                }
                else
                {
                    Console.WriteLine("yanlış sayı girdiniz");
                }



                //if (item%2==0)
                //{

                // Console.WriteLine(item);

                // }
            }




        }
    }
}

