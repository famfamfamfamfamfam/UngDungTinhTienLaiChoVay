using System;

namespace THUCHANHCAULENHLAP
{
    class UngDungTinhTienChoVayNangLai
    {
        static void Main(string[] args)
        {
            double sotien;
            int sothang;
            double laisuat;

            Console.WriteLine("Vui long nhap lan luot so tien gui, so thang gui va ti le lai suat");
            sotien = double.Parse(Console.ReadLine());
            sothang = int.Parse(Console.ReadLine());
            laisuat = double.Parse(Console.ReadLine());

            double tonglaisuat = 0;
            for (int i = 0; i < sothang; i++)
            {
                tonglaisuat += sotien * (laisuat/100)/12;
            }
            Console.WriteLine("Lai suat la "+tonglaisuat);
        }
    }
}