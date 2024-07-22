using System;

class Program
{
    // Random nesnesi sınıf seviyesinde tanımlanır
    private static Random rnd = new Random();

    static void Main(string[] args)
    {
        // Geriye Değer Döndürmeyen Bir void metot
        sarkiYaz();

        // Geriye Tamsayı Döndüren Bir metot
        Console.WriteLine($"Sayı: {sayiUret()}");

        // Parametre Alan ve Geriye Değer Döndüren Bir Metot
        Console.WriteLine("Çarpım: " + Carp(5, 7));

        // Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
        Console.Write("Adınızı Yazınız: ");
        string isim = Console.ReadLine();
        Console.Write("Soyadınızı Yazınız: ");
        string soyIsim = Console.ReadLine();
        selamla(isim, soyIsim);
    }

    // Geriye Değer Döndürmeyen Bir void metot
    static void sarkiYaz()
    {
        Console.WriteLine("Koyduğum nokta belki son\r\nBen bunu bilemem aynı bomb\r\nGibi gelir sana belki de aynı ton\r\nDibi delik gelebilir ama aynı fon\r\nKendini bilemez montofon\r\nVe monoton yaşar hep alt aynı don\r\nAnlatırım ben derdimi yalnız\r\nEy, bi' mini microphone\r\n\nŞimdi bana bi' bakınız hadi\r\nMuamelesi kesebilir hasi\r\nVe de Muhammed Ali gibi gelir asi\r\nBana bak, beni gör ve de öl vasi\r\nSesim hep duyulur tepeden bariton\r\nMekanım olabilir her an ozon\r\nYanıma gelenin canına girecektir\r\nEy, bi' mini microphone");
    }

    // Geriye Tamsayı Döndüren Bir metot
    static int sayiUret()
    {
        int i = rnd.Next(1, 100);
        return i % 2;
    }

    // Parametre Alan ve Geriye Değer Döndüren Bir Metot
    static int Carp(int a, int b)
    {
        return a * b;
    }

    // Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
    static void selamla(string a, string b)
    {
        Console.WriteLine($"Hoş Geldiniz {a} {b}!");
    }
}
