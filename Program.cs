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




