using System;

///C# kodu Görevi Bu zorluğu tamamlamak için, stdin'den bir değişkene, print Hello, World'e bir girdi satırı kaydetmeniz gerekir. tek bir satırda ve son olarak değişkeninizin değerini ikinci bir satırda yazdırın.

namespace HAKERRANK
{
    using System;

class Program4 {
    static void Main(string[] args) {
        // Sabit Değer
        Console.WriteLine("Hello, World.");

         // Bizim belirlediğimiz değişken kısım
        string degisken = Console.ReadLine();

        // Belirlediğimiz değişken çıktı
        Console.WriteLine(degisken);
    }
}
}