using System;

namespace _26._09._2023_Lekcja
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        
        /*
         * byte (8 bitów => 1 bajt)                                         0                                   -              255
         * sbyte (8bitów => 1 bajt)                                         -128                                -              127
         * short (16bitów => 2 bajty)                                       -32768                              -              32767
         * ushort (16bitów => 2 bajty)                                      0                                   -              65535
         * int (32bitów => 4 bajt)                                          -2 147 483 648                      -              2 147 483 647
         * uint (32bitów => 4 bajt)                                         0                                   -              4 294 967 295
         * long (64bity => 8 bajtów)                                        -9 223 372 036 854 775 808          -              9 223 372 036 854 775 807    | Sufix L
         * ulong (64bity => 8 bajtów)                                       0                                   -              18 446 744 073 709 551 615   | Sufix UL
         * bool (true / false)                                              true                                -              false
         * char (16 bitów => 2 bajty, znak z tablicy Unicode)               U+0000                              -              U+FFFF
         * float (32 bity => 4 bajty)                                       -3.4 * 10^38                        -              3.4 * 10^38
         * double (64 bity => 8 bajtów)
         * decimal (128 bitów => 16 bajtów)
         */





        long l = 69L;
        ulong ul = 69UL;
        float f = 10.5F;
        float f1 = 10;
        Console.WriteLine("Liczba l to {0}, a liczba ul to {1}, a liczba f to {2}, f1: {3}\n", l, ul, f, f1);

        Console.WriteLine("Ilość bajtów w pamięci typu float to " + sizeof(float));
        Console.WriteLine("Ilość bajtów w pamięci typu int to " + sizeof(int) + "\n \n");
        
        /*
         * Zapisy systemów liczbowych
         */
        
        //binarny
        Console.WriteLine("Binarny: " + 0b0101); //5
        //oktalny
        int oktalny = Convert.ToInt32("12", 8);
        Console.WriteLine("Oktalny: " + 012);
        //hexadecymalny
        Console.WriteLine("Hexadecymalny: " + 0xA);
        //dziesiętny
        Console.WriteLine("Dziesiętny: " + 420);
        
        //Zakres typów danych
        Console.WriteLine($"Zakres byte: {byte.MinValue} - {byte.MaxValue}");
        Console.WriteLine($"Zakres sbyte: {sbyte.MinValue} - {sbyte.MaxValue}");
        Console.WriteLine();
        
        Console.WriteLine(Console.ReadKey());
        





        }
    }
}
