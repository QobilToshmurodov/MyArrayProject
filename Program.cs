using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
   {  // 2. Shunday metod yozingki, u metodga uzatilgan int turidagi elementlardan tashkil topgan qatorda(int[] numbers)
      // nechta toq va nechta juft sonlar borligini hisoblab, natijani konsolga chiqarib bersin.
//3. Shunday metod yozingki, u metodning ikkita argumenti bo’lsin.Birinchi argumenti int[] numbers,
//ikkinchisi int numberToSearch.Metodning qiladigan ishi, numbers qatoridan, numberToSearch soni bor
//yoki yo’qligini izlab topish.Agar u son qatorda mavjud bo’lsa, konsolga “topildi” deb chiqaring.
//Aks holda konsolga “topilmadi” chiqaring.

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int number = 2; 
            // Console.WriteLine(myArray);
            // PrintReversedArray(myArray);
            Console.WriteLine($"Toq sonlar: {Hisobla(myArray)[0]}\nJuft sonlar: {Hisobla(myArray)[1]}");
            Search(myArray, number);
        }
        static void PrintReversedArray(int[] numbers) 
        {
            for (int i = (numbers.Length-1); i >= 0;i--)
            { 
             
                Console.WriteLine(numbers[i]);
            }
           
        }
        static List<int> Hisobla(int[] numbers1) 
        {
            int toq = 0;
            int juft = 0;
            for (int i = 0; i < numbers1.Length; i++)
            {
                if (numbers1[i] % 2 == 0)
                {
                    juft++;
                }
                else
                { 
                    toq++;
                }
                
            }
            List<int> list = new List<int>();
            list.Add(toq);
            list.Add(juft);

            return list;    
        }
        static void Search(int[] numbers,int numberToSearch)
        {
            int result=0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numberToSearch)
                {
                 result++;
                }
            }
            if (result == 0)
            {
                Console.WriteLine("Topilmadi");
            }
            else { Console.WriteLine("Topildi"); }
        }
    }
}
