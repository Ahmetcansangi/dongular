﻿using System;

namespace dongular
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "Proglamlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array - dizi


            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu",
                "Proglamlamaya başlangıç için temel kurs","Java","phyton"};




            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }




            Console.WriteLine("sayfa sonu - footer");



        }
    }
}
