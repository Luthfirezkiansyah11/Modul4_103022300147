// See https://aka.ms/new-console-template for more information
using Modul4_103022300147;

Console.WriteLine("Input Nama Produk: ");
string inputProduk = Console.ReadLine();

if (Enum.TryParse(inputProduk, out KodeProduk.produk harga))
{
    string kodeProduk = KodeProduk.GetKodeProduk(harga);
    Console.WriteLine($"Kode Produk : {kodeProduk}");
}
else
{
    Console.WriteLine($"Harga {inputProduk} : Tidak ada!");
}

Console.WriteLine("\n");

FanLaptop mode = new FanLaptop();

while (true) {
    Console.WriteLine("Input Mode Fan (Quiet, Balanced, Performance, Turbo / Keluar): ");
    string inputMode = Console.ReadLine();

    if (inputMode == "Quiet")
    {
        Console.WriteLine("Sudah Mode Quiet");
    }
    else if (inputMode == "Balanced")
    {
        mode.modeBalanced();
    }
    else if (inputMode == "Performance")
    {
        mode.modePerformance();
    }
    else if (inputMode == "Turbo")
    {
        mode.modeTurbo();
    }
    else if (inputMode == "Exit")
    {
        break;
    }
    else
    {
        Console.WriteLine("Mode Fan Tidak Ada!");
    }
}

