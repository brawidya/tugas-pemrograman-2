using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Kalkulator Sederhana");
            Console.WriteLine("Pilih operasi:");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("5. Keluar");

            Console.Write("Masukkan pilihan (1-5): ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 5)
            {
                Console.WriteLine("Keluar dari kalkulator.");
                break;
            }

            Console.Write("Masukkan bilangan pertama: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Masukkan bilangan kedua: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Hasil: {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Hasil: {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Hasil: {result}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Hasil: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Pembagian dengan nol tidak diperbolehkan.");
                    }
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih kembali.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
