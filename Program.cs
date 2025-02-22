using System;
using System.Text;

class Program
{
    static string alfabe = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // İngiliz alfabesi (26 harf)

    static void Main()
    {
        Console.WriteLine("1 - Sezar Şifreleme");
        Console.WriteLine("2 - Sezar Çözme");
        Console.WriteLine("3 - Affine Şifreleme");
        Console.WriteLine("4 - Affine Çözme");
        Console.Write("Seçiminizi yapın: ");
        int secim = int.Parse(Console.ReadLine());

        Console.Write("Metni girin: ");
        string metin = Console.ReadLine().ToUpper();

        if (secim == 1 || secim == 2)
        {
            Console.Write("Sezar için anahtar değerini girin: ");
            int anahtar = int.Parse(Console.ReadLine());
            if (secim == 1)
                Console.WriteLine($"Şifreli Metin: {SezarSifrele(metin, anahtar)}");
            else
                Console.WriteLine($"Çözülmüş Metin: {SezarCoz(metin, anahtar)}");
        }
        else if (secim == 3 || secim == 4)
        {
            Console.Write("Affine için (a) anahtarını girin: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Affine için (b) anahtarını girin: ");
            int b = int.Parse(Console.ReadLine());

            if (GCD(a, 26) != 1)
            {
                Console.WriteLine("Hata: (a) anahtarı 26 ile aralarında asal olmalıdır!");
                return;
            }

            if (secim == 3)
                Console.WriteLine($"Şifreli Metin: {AffineSifrele(metin, a, b)}");
            else
                Console.WriteLine($"Çözülmüş Metin: {AffineCoz(metin, a, b)}");
        }
        else
        {
            Console.WriteLine("Geçersiz seçim!");
        }
    }

    // Sezar Şifreleme Fonksiyonu
    static string SezarSifrele(string metin, int anahtar)
    {
        StringBuilder sonuc = new StringBuilder();
        foreach (char karakter in metin)
        {
            int index = alfabe.IndexOf(karakter);
            if (index != -1)
            {
                int yeniIndex = (index + anahtar) % 26;
                if (yeniIndex < 0) yeniIndex += 26; // Negatif indeks için düzeltme
                sonuc.Append(alfabe[yeniIndex]);
            }
            else
            {
                sonuc.Append(karakter);
            }
        }
        return sonuc.ToString();
    }

    // Sezar Çözme Fonksiyonu
    static string SezarCoz(string sifreliMetin, int anahtar)
    {
        return SezarSifrele(sifreliMetin, -anahtar); // Sezar şifrelemenin tersi
    }

    // Affine Şifreleme Fonksiyonu
    static string AffineSifrele(string metin, int a, int b)
    {
        StringBuilder sonuc = new StringBuilder();
        foreach (char karakter in metin)
        {
            int index = alfabe.IndexOf(karakter);
            if (index != -1)
            {
                int yeniIndex = (a * index + b) % 26;
                sonuc.Append(alfabe[yeniIndex]);
            }
            else
            {
                sonuc.Append(karakter);
            }
        }
        return sonuc.ToString();
    }

    // Affine Şifre Çözme Fonksiyonu
    static string AffineCoz(string sifreliMetin, int a, int b)
    {
        int aTersi = ModInverse(a, 26);
        if (aTersi == -1)
        {
            Console.WriteLine("Hata: Modüler ters hesaplanamadı!");
            return "";
        }

        StringBuilder sonuc = new StringBuilder();
        foreach (char karakter in sifreliMetin)
        {
            int index = alfabe.IndexOf(karakter);
            if (index != -1)
            {
                int yeniIndex = (aTersi * (index - b + 26)) % 26;
                sonuc.Append(alfabe[yeniIndex]);
            }
            else
            {
                sonuc.Append(karakter);
            }
        }
        return sonuc.ToString();
    }

    // En Büyük Ortak Bölen (GCD) Fonksiyonu
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Modüler Ters Hesaplama (a^(-1) mod m)
    static int ModInverse(int a, int m)
    {
        for (int x = 1; x < m; x++)
        {
            if ((a * x) % m == 1)
                return x;
        }
        return -1;
    }
}
