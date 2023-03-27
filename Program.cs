using System;

class Program
{
    static void Main(){
        Console.WriteLine("+==========================================+");
        Console.WriteLine("|  Selamat datang di Kalkulator Sederhana  |");
        Console.WriteLine("|         Istianmuhammad - Game 14         |");
        Console.WriteLine("+==========================================+");
        bool exit = false;
        do{    
            Console.Write("Masukkan bilangan pertama\t: ");
            double bilangan1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan bilangan kedua\t\t: ");
            double bilangan2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pilih operasi matematika yang ingin dilakukan:");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("Pilihan Anda (1-4): ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            double hasil = 0;
            var operasi =""; 
            switch (pilihan)
            {
                case 1:
                    hasil = bilangan1 + bilangan2;
                    operasi = "+";
                    break;

                case 2:
                    hasil = bilangan1 - bilangan2;
                    operasi = "-";
                    break;

                case 3:
                    hasil = bilangan1 * bilangan2;
                    operasi = "*";    
                    break;

                case 4:
                    hasil = bilangan1 / bilangan2;
                    operasi = "/";
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid!");
                    break;
            }
            var temp = "";
            if(operasi == ""){
                Console.WriteLine("===============================================");
                Console.WriteLine("\nIngin Mengulang? (Y/N)...");
                temp = Console.ReadLine();
            }else{
                Console.WriteLine("===============================================");
                Console.WriteLine(bilangan1 + " " + operasi + " " + bilangan2 + " = " + hasil);
                Console.WriteLine("Hasilnya adalah\t: " + hasil);
                Console.WriteLine("\nIngin Kembali menghitung? (Y/N)...");
                temp = Console.ReadLine();
            }
            if(temp == "Y" || temp == "y"){
                Console.Clear();
            }else{
                exit = true;
            }
        }while (!exit);    
    }
}
