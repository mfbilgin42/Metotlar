using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            int[] numbers1 = new int[] {10,20,30};
            int[] numbers2 = new int[] {100,200,300};
            numbers1 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]);
            //int,decimal,float,double,bool bunlar değer tiplerdir.
            //array, class, interface vs. ise referans tiptir.
            //Referans tiplerde veri tutma olayı.
            //steak                                        heap
            //array1[]            ->                     101/{10,20,30}
            //array2[]            ->                     102/{100,200,300}

            //array1[] = array2[] olunca
            //array1[]
        }
    }
}
