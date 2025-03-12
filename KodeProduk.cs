using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_103022300147
{
    internal class KodeProduk
    {
        public enum produk {
            Laptop,
            Smartphone,
            Tablet,
            Headset,
            Keyboard,
            Mouse,
            Printer,
            Monitor,
            Smartwatch,
            Kamera,
        }

        public static string GetKodeProduk(produk produk)
        {
            string[] kodeProduk = new string[] { "E100", "E101", "E102", "E103", "E104",
                "E105", "E106", "E107", "E108", "E109" };

            return kodeProduk[(int)produk];
        }
    }
}
