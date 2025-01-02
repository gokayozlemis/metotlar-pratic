using System;

class Program
{
    static void Main()
    {
        // 1. Geriye Değer Döndürmeyen Void 
        YazdirSevdigimSarki();  

        // 2. Geriye Tamsayı Döndüren
        int kalan = RastgeleSayininKalaniniBul();
        Console.WriteLine("Rastgele sayının 2'ye bölümünden kalan: " + kalan);

        // 3. Parametre Alan ve Geriye Değer Döndüren 
        int carpim = CarpimHesapla(7, 8);  
        Console.WriteLine("7 ile 8'in çarpımı: " + carpim);

        // 4. Parametre Alan ve Geriye Değer Döndürmeyen 
        HoşGeldinizMesajı("Ajda", "Pekkan");  
    }

    // 1. Geriye Değer Döndürmeyen Void 
    static void YazdirSevdigimSarki()
    {
        Console.WriteLine("Şarkı Sözü: 'Ben sende tutuklu kaldım.'");
    }

    // 2. Geriye Tamsayı Döndüren 
    static int RastgeleSayininKalaniniBul()
    {
        Random random = new Random();  // Random sınıfını kullanarak rastgele sayı üretelim
        int rastgeleSayi = random.Next(1, 100);  // 1 ile 100 arasında bir sayı üret
        Console.WriteLine("Üretilen Rastgele Sayı: " + rastgeleSayi);
        return rastgeleSayi % 2;  // Sayının 2'ye bölümünden kalanı döndür
    }

    // 3. Parametre Alan ve Geriye Değer Döndüren 
    static int CarpimHesapla(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;  // İki sayıyı çarpıp döndür
    }

    // 4. Parametre Alan ve Geriye Değer Döndürmeyen 
    static void HoşGeldinizMesajı(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}!");
    }
}
